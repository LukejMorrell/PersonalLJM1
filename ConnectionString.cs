using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLJM1
{
    public class ConnectionString
    {
        public string cs {get; set;}
        public ConnectionString(){
            string server ="erxv1bzckceve5lh.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "uru8h8lv3ooowtk9";
            string port ="3306";
            string userName = "ywa1tw4yw39szay1";
            string password = "u49117dh9c9y22ta";

            cs = $@"server = {server};user = {userName};database={database};port={port};password={password};";

        }
    }
}