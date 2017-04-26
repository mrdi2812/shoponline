using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeywords { set; get; }
        [MaxLength(256)]
        public string MetaDesciptions { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public bool Status { set; get; }
    }
}
