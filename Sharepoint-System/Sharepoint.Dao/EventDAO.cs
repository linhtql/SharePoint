using Microsoft.Extensions.Configuration;
using Sharepoint.Data.Convert;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Dao
{
    public class EventDAO : DatabaseHelperBase
    {
        public EventDAO(IConfiguration configuration) : base(configuration) { }

        public async Task<Boolean> AddEvents(List<Event> events)
        {
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("CreateDate");
            table.Columns.Add("StartTime");
            table.Columns.Add("EndTime");

            foreach (var item in events.Select(EventConvert.ToEntity))
            {
                table.Rows.Add(item.Id,
                    item.Name,
                    item.CreateDate,
                    item.StartTime,
                    item.EndTime
                    );
            }
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BatchAddEvent";
                cmd.Parameters.Add(new SqlParameter("@events", table));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        public async Task<Event> FindById(String Id)
        {
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM [Event] WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("Id", Id));
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        return EventConvert.ToEvent(entity);
                    }
                }
            }
            return null;
        }
        public async Task<List<Event>> FindAll()
        {
            var result = new List<Event>();
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM [Event]";
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var entity = this.ReadEntity(reader);
                        result.Add(EventConvert.ToEvent(entity));
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
                    cmd.CommandText = "DELETE FROM [Event] WHERE Id=@Id";
                    cmd.Parameters.Add(new SqlParameter("Id", Id));

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }

            }
            return false;
        }
        public async Task<Boolean> Update(Event eventt)
        {
            var eventEntity = EventConvert.ToEntity(eventt);
            using (var conn = await GetSqlConnectionAsync())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE [Event] SET Name=@Name, CreateDate=@CreateDate, StartTime=@StartTime, EndTime=@EndTime WHERE Id=@Id";
                cmd.Parameters.Add(new SqlParameter("CreateDate", eventEntity.CreateDate.ToString()));
                cmd.Parameters.Add(new SqlParameter("Name", eventEntity.Name));
                cmd.Parameters.Add(new SqlParameter("StartTime", eventEntity.StartTime.ToString()));
                cmd.Parameters.Add(new SqlParameter("EndTime", eventEntity.EndTime.ToString()));
                cmd.Parameters.Add(new SqlParameter("Id", eventEntity.Id));

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        private EventEntity ReadEntity(SqlDataReader reader)
        {
            var result = new EventEntity();

            result.Id = (String)reader["Id"];
            result.Name = (String)reader["Name"];
            result.CreateDate = (DateOnly.FromDateTime((DateTime)reader["CreateDate"]));
            result.StartTime = TimeOnly.FromTimeSpan((TimeSpan)reader["StartTime"]);
            result.EndTime = TimeOnly.FromTimeSpan((TimeSpan)reader["EndTime"]);

            return result;
        }
    }
}
