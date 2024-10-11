using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var repository=new FitnessProgramRepository();
            var program = new FitnessPrograms();

            program.FitnessProgramId = 2;
            program.Duration = "3months";
            program.Price = 100;
            program.Title = "Title";
            repository.InsertNewFitnessprograms(program);
        
        }
    }

}



 
    
