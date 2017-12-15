﻿using System;
using SQLite;
namespace ICT13580043A2.Models
{
    public class product
    {
        [PrimaryKey,AutoIncrement]
        public int Id{ get; set; } 
        [NotNull]
        [MaxLength(200)]
        public String Name{ get; set;}

        public String Description{ get; set;}
        [NotNull]
        [MaxLength(100)]
        public string Category{ get; set;}

        public decimal ProductPrice{get;set;}
        public decimal sellPrice{get;set;}
        public int Stock{get;set;}
    }
}
