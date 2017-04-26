using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeywords { set; get; }
        string MetaDesciptions { set; get; }
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        bool Status { set; get; }

    }
}
