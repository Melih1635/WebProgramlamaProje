﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Odev.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required,StringLength(50,ErrorMessage ="En fazla 50 karakter olabilir!")]
        public string Eposta  { get; set; }
        [Required,StringLength(50,ErrorMessage ="En fazla 50 karakter olabilir!")]
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}