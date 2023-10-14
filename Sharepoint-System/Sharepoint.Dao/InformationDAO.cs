using Microsoft.Extensions.Configuration;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using Sharepoint.Data.Convert;

namespace Sharepoint.Dao
{
    public class InformationDAO : DatabaseHelperBase
    {
        public InformationDAO(IConfiguration configuration) : base(configuration) { }

        public async Task<Boolean> AddInformation(List<Information> informations)
        {
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Type");
            table.Columns.Add("ImageUrl");
            table.Columns.Add("Title");
            table.Columns.Add("Description");
            table.Columns.Add("CreateDate");
            table.Columns.Add("Extension");

            foreach (var item in informations.Select(InformationConvert.ToEntity))
            {
                table.Rows.Add(item.Id,
                    item.Type,
                    item.ImageUrl,
                    item.Title,
                    item.Description,
                    item.CreatedDate,
                    item.Extension
                    );
            }
            using (var conn = await GetSqlConnectionAsync())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "BatchAddInformation";
                    cmd.Parameters.Add(new SqlParameter("informations", table));

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<Information> FindById(String id)
        {
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Information WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("Id", id));
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var entity = ReadEntity(reader);
                        return InformationConvert.ToInformation(entity);
                    }
                }
            }
            return null;
        }
        public async Task<List<Information>> FindAllByType(InformationType type)
        {
            var result = new List<Information>();
            using (var conn = await this.GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM [Information] WHERE [Type] = @Type";
                cmd.Parameters.Add(new SqlParameter("Type", type));

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        result.Add(InformationConvert.ToInformation(entity));
                    }
                }
            }
            return result;
        }
        private InformationEntity ReadEntity(SqlDataReader reader)
        {
            var result = new InformationEntity();

            result.Id = (String)reader["Id"];
            result.Type = (Int32)reader["Type"];
            result.ImageUrl = (String)reader["ImageUrl"];
            result.Title = (String)reader["Title"];
            result.Description = (String)reader["Description"];
            DateTime dateTime = (DateTime)reader["CreateDate"];
            result.CreatedDate = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            result.Extension = (String)reader["Extension"];

            return result;
        }

        public async Task<Boolean> Delete(String id)
        {
            var isExits = this.FindById(id);
            if (isExits == null)
            {
                return false;
            }
            using (var conn = await this.GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Information WHERE Id =@Id";
                cmd.Parameters.Add(new SqlParameter("Id", id));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        public async Task<Boolean> Update(Information information)
        {
            var informationEntity = InformationConvert.ToEntity(information);
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE Information SET Type = @Type, ImageUrl = @ImageUrl, Title= @Title, [Description]" +
                    " = @Description, [CreateDate] = @CreateDate, [Extension]= @Extension WHERE Id =@Id";
                cmd.Parameters.Add(new SqlParameter("Id", informationEntity.Id));
                cmd.Parameters.Add(new SqlParameter("Type", informationEntity.Type));
                cmd.Parameters.Add(new SqlParameter("ImageUrl", informationEntity.ImageUrl));
                cmd.Parameters.Add(new SqlParameter("Title", informationEntity.Title));
                cmd.Parameters.Add(new SqlParameter("Description", informationEntity.Description));
                cmd.Parameters.Add(new SqlParameter("CreateDate", informationEntity.CreatedDate.ToString()));
                cmd.Parameters.Add(new SqlParameter("Extension", informationEntity.Extension));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
    }
}



