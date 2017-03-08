﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LSFDictionary.Models
{
    [Table("WordsDictionary")]
    public class Dictionary : IComparable<Dictionary>
    {
        public int Id { get; set; }
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public string Cate { get; set; }
        [Required]
        public int Niveau { get; set; }
        [Required]
        public string FontAwe { get; set; }

        public int CompareTo(Dictionary other)
        {
            if (other == null) return 1;
            return this.Key.CompareTo(other.Key);

        }
    }
}