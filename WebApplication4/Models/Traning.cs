using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Traning
    {
        [Key]
        public int Id_traning { get; set; }
        public string DST { get; set; }
        public string TM { get; set; }
        public string AVG { get; set; }
        public string MAX { get; set; }
        public string KM1 { get; set; }
        public string DATE { get; set; }
        public string TEMP { get; set; }
        public string WEATHER { get; set; }
        public string ENDMNDO { get; set; }

        public class TraningContext : DbContext
        {
            public DbSet<Traning> Movies { get; set; }
        }

    }
}