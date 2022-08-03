﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class ImportedObject : ImportedObjectBaseClass
    {
        public new string Name { get; set; }
        public string Schema { get; set; } 
        public string ParentName { get; set; }
        public string ParentType { get; set; } 
        public string DataType { get; set; }
        public string IsNullable { get; set; }
        public double NumberOfChildren { get; set; }
    }
}
