﻿using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string todo { get; set; } = "";
        public Boolean Completed { get; set; } = false;
        [DataType(DataType.DateTime)]
        public DateTime? CompletetionDate { get; set; }
    }
}
