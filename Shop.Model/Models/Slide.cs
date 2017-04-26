﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [StringLength(250)]
        public string Name { set; get; }

        [StringLength(250)]
        public string Description { set; get; }

        [Required]
        [StringLength(500)]
        public string Image { set; get; }

        [Required]
        [StringLength(500)]
        public string URL { set; get; }

        public int? DisPlayOrder { set; get; }

        public bool Status { set; get; }
    }
}
