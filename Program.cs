using System;
using PersonalLJM1.database;
using PersonalLJM1.models;
namespace PersonalLJM1{
    class Program{
        static void Main(string[] args){
           // DeleteEssay.DropEssayTable();
          //  SaveEssay.CreateEssayTable();
          Essay myEssay=new Essay(){Name="Test",date="2021-22-12",Description="this is a test",Content="this is essay"};
          myEssay.Save.CreateEssay(myEssay);
        }
    }
}