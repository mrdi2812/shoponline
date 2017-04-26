using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [StringLength(250)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { set; get; }

        [StringLength(50)]
        public string CreateBy { set; get; }

        [StringLength(250)]
        public string PaymentMethod { set; get; }

        [Required]
        [StringLength(50)]
        public string PaymentStatus { set; get; }

        public bool? Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
