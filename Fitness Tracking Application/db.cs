using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Fitness_Tracking_Application
{
    class db 
    {
       public SQLiteConnection myConnection = new SQLiteConnection("Data Source=../../fitnessdb.db;Version=3;");
    }
}
