using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodoApi.Entities
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
