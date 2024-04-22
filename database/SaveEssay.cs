using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PersonalLJM1.interfaces;
using PersonalLJM1.models;

namespace PersonalLJM1.database{
    
         public class SaveEssay : ISaveEssay
    {
        public static void CreateEssayTable(){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE ESSAYS(id INTEGER PRIMARY KEY AUTO_INCREMENT,name TEXT,date Text,description TEXT,content TEXT)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();   
    }
        
        public void CreateEssay(Essay myEssay)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO ESSAYS(name, date, description, content) VALUES(@name,@date,@description,@content)";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@name",myEssay.Name);
            cmd.Parameters.AddWithValue("@date",myEssay.date);
            cmd.Parameters.AddWithValue("@description",myEssay.Description);
            cmd.Parameters.AddWithValue("@content",myEssay.Content);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        void ISaveEssay.SaveEssay(Essay myEssay)
        {
            throw new NotImplementedException();
        }
    }
}