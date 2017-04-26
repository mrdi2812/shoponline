﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]     
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}
