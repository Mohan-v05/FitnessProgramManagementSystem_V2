using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgramRepository
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;database=FitnessProgramManagement  ;";

        //1 insert new Finess program
        public void InsertNewFitnessprograms(FitnessPrograms fitnessProgram)
        {
            string query = "INSERT INTO FitnessPrograms (FitnessProgramId,Title, Duration, Price) VALUES (@id,@Title,@Duration,@Price);";

            try
            {
                using (SqlConnection Connection = new SqlConnection(connectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@id", fitnessProgram.FitnessProgramId);

                        Command.Parameters.AddWithValue("@Title", fitnessProgram.Title);
                        
                        Command.Parameters.AddWithValue("@Duration", fitnessProgram.Duration);

                        Command.Parameters.AddWithValue("@Price", fitnessProgram.Price);
                        
                        Command.ExecuteNonQuery();
                        Console.WriteLine("Title Added");
                    };
                }
                Console.WriteLine("Fitness program inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting" + ex.Message);
            }

        }
        public void UpdateFitnessprogram(FitnessPrograms fitnessProgram, int id)
        {
            string query = "Update  FitnessPrograms (Title=@Title, Duration=@Duration, Price=@Price) where FitnessProgramId=@id";

            try
            {
                using (SqlConnection Connection = new SqlConnection(connectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Title", fitnessProgram.Title);
                        Command.Parameters.AddWithValue("@id", id);
                        Command.Parameters.AddWithValue("@Duration", fitnessProgram.Duration);
                        Command.Parameters.AddWithValue("@Price", fitnessProgram.Price);
                        Command.ExecuteNonQuery();
                    };
                }
                Console.WriteLine("Fitness program Updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while Updating" + ex.Message);
            }

        }
        public void DeleteFromtable(FitnessPrograms fitnessProgram, int id)
        {
            string query = "delete from FitnessPrograms  where FitnessProgramId=@id";

            try
            {
                using (SqlConnection Connection = new SqlConnection(connectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {

                        Command.Parameters.AddWithValue("@id", id);

                        Command.ExecuteNonQuery();
                    };
                }
                Console.WriteLine("Fitness program Deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while Deleting" + ex.Message);
            }
        }
    }
}


