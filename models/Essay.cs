using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalLJM1.database;
using PersonalLJM1.interfaces;

namespace PersonalLJM1.models
{
    public class Essay
    {
        public string Name {get; set;} 
        public string date {get; set;}
        public string Description {get; set;} 
        public string Content {get; set;} 

        public ISaveEssay Save {get; set;}
        public Essay(){
            Save = new SaveEssay();
        }
    }
}