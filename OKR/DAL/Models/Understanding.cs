﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Understanding
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
