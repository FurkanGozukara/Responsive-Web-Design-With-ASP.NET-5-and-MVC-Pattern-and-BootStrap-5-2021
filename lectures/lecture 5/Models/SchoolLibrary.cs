using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace lecture_1.Models
{
    public class SchoolLibrary
    {
        public string srManagerName { get; set; }

        public List<string> lstNameofBooks;

        public DataTable dtSomeVals = new DataTable();

        public SchoolLibrary()
        {
            dtSomeVals.Columns.Add("name");
            dtSomeVals.Columns.Add("price");

        }

        public class test
        {
            public string gg = "test";

            public void testa()
            {
                gg = "dfsd";
            }
        }

        
    }
}
