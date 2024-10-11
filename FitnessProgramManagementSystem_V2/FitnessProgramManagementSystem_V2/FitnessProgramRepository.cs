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
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=FitnessProgramManagement2;";

        //1 insert new Finess program
        public void InsertNewFitnessprogram(FitnessPrograms fitnessProgram)
        {
            string query = "INSERT INTO FitnessPrograms (Title, Duration, Price) VALUES (@Title,@Duration,@Price);";

            try
            {
                using (SqlConnection Connection = new SqlConnection(connectionString))
                {
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Title", fitnessProgram.Title);
                        Console.WriteLine("Title Added");
                        Command.Parameters.AddWithValue("@Duration", fitnessProgram.Duration);
                        Command.Parameters.AddWithValue("@Price", fitnessProgram.Price);
                        Command.ExecuteNonQuery();
                    };
                }
                Console.WriteLine("Fitness program inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting" + ex.Message);
            }

        }


    }
}

