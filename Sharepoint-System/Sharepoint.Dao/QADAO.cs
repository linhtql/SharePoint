using Microsoft.Extensions.Configuration;
using Sharepoint.Data.Convert;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System.Data;
using System.Data.SqlClient;

namespace Sharepoint.Dao
{
    public class QADAO : DatabaseHelperBase
    {
        public QADAO(IConfiguration configuration) : base(configuration)
        {

        }
        public async Task<Boolean> AddQas(List<QA> qas)
        {
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Question");
            table.Columns.Add("Answer");

            foreach (var item in qas.Select(QAConvert.ToEntity))
            {
                table.Rows.Add(item.Id,
                    item.Question,
                    item.Answer
                    );
            }
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BatchAddQA";
                cmd.Parameters.Add(new SqlParameter("qas", table));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        public async Task<QA> FindById(String Id)
        {
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM QA WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("Id", Id));
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        return QAConvert.ToQA(entity);
                    }
                }
            }
            return null;
        }
        public async Task<List<QA>> FindAll()
        {
            var result = new List<QA>();
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM QA";
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        result.Add(QAConvert.ToQA(entity));
                    }
                }
            }
            return result;
        }
        public async Task<Boolean> Delete(String Id)
        {
            var isExits = this.FindById(Id);
            if (isExits != null)
            {
                using (var conn = await GetSqlConnectionAsync())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM QA WHERE Id=@Id";
                    cmd.Parameters.Add(new SqlParameter("Id", Id));

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }

            }
            return false;
        }
        public async Task<Boolean> Update(QA qa)
        {
            var qaEntity = QAConvert.ToEntity(qa);
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE QA SET Question=@Question, Answer=@Answer WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("Question", qaEntity.Question));
                cmd.Parameters.Add(new SqlParameter("Answer", qaEntity.Answer));
                cmd.Parameters.Add(new SqlParameter("Id", qaEntity.Id));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        private QAEntity ReadEntity(SqlDataReader reader)
        {
            var result = new QAEntity();

            result.Id = (String)reader["Id"];
            result.Question = (String)reader["Question"];
            result.Answer = (String)reader["Answer"];

            return result;
        }

    }
}
