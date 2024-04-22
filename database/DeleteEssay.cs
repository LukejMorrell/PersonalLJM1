using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PersonalLJM1.interfaces;

namespace PersonalLJM1.database
{
    public class DeleteEssay : IDeleteEssay
    {
        public static void DropEssayTable(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS essays";
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }
        void IDeleteEssay.DeleteEssay(int id)
        {
            throw new NotImplementedException();
        }
    }
}