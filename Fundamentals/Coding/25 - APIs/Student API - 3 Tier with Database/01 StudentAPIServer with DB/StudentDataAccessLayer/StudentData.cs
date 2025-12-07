using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentModels;

namespace StudentDataAccessLayer
{
    public class StudentData
    {
        static string _connectionString = "Server=localhost;Database=StudentsApiDB;User Id=sa;Password=sa123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        // Async-only versions
        public static async Task<List<StudentDTO>> GetAllStudentsAsync(CancellationToken ct = default)
        {
            var studentsList = new List<StudentDTO>();

            await using (var conn = new SqlConnection(_connectionString))
            await using (var cmd = new SqlCommand("SP_GetAllStudents", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                await conn.OpenAsync(ct);
                await using var reader = await cmd.ExecuteReaderAsync(ct);
                while (await reader.ReadAsync(ct))
                {
                    studentsList.Add(new StudentDTO
                    (
                        reader.GetInt32(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetInt32(reader.GetOrdinal("Age")),
                        reader.GetInt32(reader.GetOrdinal("Grade"))
                    ));
                }
            }

            return studentsList;
        }

        public static async Task<List<StudentDTO>> GetPassedStudentsAsync(CancellationToken ct = default)
        {
            var studentsList = new List<StudentDTO>();

            await using (var conn = new SqlConnection(_connectionString))
            await using (var cmd = new SqlCommand("SP_GetPassedStudents", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                await conn.OpenAsync(ct);
                await using var reader = await cmd.ExecuteReaderAsync(ct);
                while (await reader.ReadAsync(ct))
                {
                    studentsList.Add(new StudentDTO
                    (
                        reader.GetInt32(reader.GetOrdinal("Id")),
                        reader.GetString(reader.GetOrdinal("Name")),
                        reader.GetInt32(reader.GetOrdinal("Age")),
                        reader.GetInt32(reader.GetOrdinal("Grade"))
                    ));
                }
            }

            return studentsList;
        }

        public static async Task<double> GetAverageGradeAsync(CancellationToken ct = default)
        {
            await using var conn = new SqlConnection(_connectionString);
            await using var cmd = new SqlCommand("SP_GetAverageGrade", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            await conn.OpenAsync(ct);
            var result = await cmd.ExecuteScalarAsync(ct);
            return result is DBNull or null ? 0 : Convert.ToDouble(result);
        }

        public static async Task<StudentDTO?> GetStudentByIdAsync(int studentId, CancellationToken ct = default)
        {
            await using var connection = new SqlConnection(_connectionString);
            await using var command = new SqlCommand("SP_GetStudentById", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@StudentId", studentId);

            await connection.OpenAsync(ct);
            await using var reader = await command.ExecuteReaderAsync(ct);
            if (await reader.ReadAsync(ct))
            {
                return new StudentDTO
                (
                    reader.GetInt32(reader.GetOrdinal("Id")),
                    reader.GetString(reader.GetOrdinal("Name")),
                    reader.GetInt32(reader.GetOrdinal("Age")),
                    reader.GetInt32(reader.GetOrdinal("Grade"))
                );
            }

            return null;
        }

        public static async Task<int> AddStudentAsync(StudentDTO StudentDTO, CancellationToken ct = default)
        {
            await using var connection = new SqlConnection(_connectionString);
            await using var command = new SqlCommand("SP_AddStudent", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Name", StudentDTO.Name);
            command.Parameters.AddWithValue("@Age", StudentDTO.Age);
            command.Parameters.AddWithValue("@Grade", StudentDTO.Grade);
            var outputIdParam = new SqlParameter("@NewStudentId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(outputIdParam);

            await connection.OpenAsync(ct);
            await command.ExecuteNonQueryAsync(ct);

            return (int)outputIdParam.Value;
        }

        public static async Task<bool> UpdateStudentAsync(StudentDTO StudentDTO, CancellationToken ct = default)
        {
            await using var connection = new SqlConnection(_connectionString);
            await using var command = new SqlCommand("SP_UpdateStudent", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@StudentId", StudentDTO.Id);
            command.Parameters.AddWithValue("@Name", StudentDTO.Name);
            command.Parameters.AddWithValue("@Age", StudentDTO.Age);
            command.Parameters.AddWithValue("@Grade", StudentDTO.Grade);

            await connection.OpenAsync(ct);
            await command.ExecuteNonQueryAsync(ct);
            return true;
        }

        public static async Task<bool> DeleteStudentAsync(int studentId, CancellationToken ct = default)
        {
            await using var connection = new SqlConnection(_connectionString);
            await using var command = new SqlCommand("SP_DeleteStudent", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@StudentId", studentId);

            await connection.OpenAsync(ct);
            var result = await command.ExecuteScalarAsync(ct);

            int rowsAffected = result is int i ? i : Convert.ToInt32(result ?? 0);
            return rowsAffected == 1;
        }
    }
}
