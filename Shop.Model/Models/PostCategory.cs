﻿using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(250)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string Alias { set; get; }

        public int ParentID { set; get; }

        [StringLength(500)]
        public string Description { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posst { set; get; }

    }
}