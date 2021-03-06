﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitTests.EF6.Model
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome"), Required]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}