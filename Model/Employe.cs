using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Finance_WebForm_OIL.Model
{
    public class Employe
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public int PersonCode { get; set; }
        public int HourPay { get; set; }
    }

    public class MyContext : DbContext 
    {
        public MyContext():base("Server=.;Database=Finanace;Trusted_Connection=True;")
        {
                
        }


        public DbSet<Employe> employes { get; set; }
    }

}