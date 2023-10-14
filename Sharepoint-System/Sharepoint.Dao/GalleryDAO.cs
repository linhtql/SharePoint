using Microsoft.Extensions.Configuration;
using Sharepoint.Data.Convert;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System.Data;
using System.Data.SqlClient;


namespace Sharepoint.Dao
{
    public class GalleryDAO : DatabaseHelperBase
    {
        public GalleryDAO(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<Boolean> AddGalleries(List<Gallery> galleries)
        {
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Type");
            table.Columns.Add("Extension");

            foreach (var item in galleries.Select(GalleryConvert.ToEntity))
            {
                table.Rows.Add(item.Id,
                    item.Name,
                    item.Type,
                    item.Extension
                    );
            }
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BatchAddGallery";
                cmd.Parameters.Add(new SqlParameter("galleries", table));
                return await cmd.ExecuteNonQueryAsync() > 0;
            }

        }
        public async Task<List<Gallery>> FindAllByType(GalleryType type)
        {
            var result = new List<Gallery>();
            using (var conn = await this.GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Gallery WHERE [Type] = @Type";
                cmd.Parameters.Add(new SqlParameter("Type", type));

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        result.Add(GalleryConvert.ToGallery(entity));
                    }
                }
            }
            return result;
        }
        public async Task<Gallery> FindById(String id)
        {
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Gallery WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("Id", id));
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var entity = ReadEntity(reader);
                        return GalleryConvert.ToGallery(entity);
                    }
                }
            }
            return null;
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
                cmd.CommandText = "DELETE FROM Gallery WHERE Id =@Id";
                cmd.Parameters.Add(new SqlParameter("Id", id));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        public async Task<Boolean> Update(Gallery gallery)
        {
            var galleryEntity = GalleryConvert.ToEntity(gallery);
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE Gallery SET Name = @Name Type = @Type, Extension = @Extension WHERE Id =@Id";
                cmd.Parameters.Add(new SqlParameter("Id", galleryEntity.Id));
                cmd.Parameters.Add(new SqlParameter("Name", galleryEntity.Name));
                cmd.Parameters.Add(new SqlParameter("Type", galleryEntity.Type));
                cmd.Parameters.Add(new SqlParameter("Extension", galleryEntity.Extension));


                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }

        private GalleryEntity ReadEntity(SqlDataReader reader)
        {
            var entity = new GalleryEntity();
            entity.Id = (String)reader["Id"];
            entity.Name = (String)reader["Name"];
            entity.Type = (Int32)reader["Type"];
            entity.Extension = (String)reader["Extension"];

            return entity;
        }
    }
}
