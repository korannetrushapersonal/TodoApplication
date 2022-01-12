using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Entities
{
    public class TodoItem
    {
        [Key]
        public int ItemId {get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person person { get; set; }

        public DateTime AddedDateTime { get; set; }
    }   
}