//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

// MODEL CLASS TO FETCH AND SEND DATA 

namespace WebApplication1.Models
{
    public class Student_data
    {
        public int ID{ get; set; }
        public int ROLL_NO { get; set; }
        public string NAME { get; set; }
        public string FIELD { get; set; }

        public string NATIONALITY { get; set; }

        public string BATCH { get; set; }
        public string EMAIL { get; set; }

    }
}