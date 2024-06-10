using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nvv.Lesson08CF.Models
{
    //<summary>
    //tạo cấu trúc bảng dữ liệu
    //</summary>
    public class NvvCategory
    {
        [Key]
        public int NvvCategoryId { get; set; }
        public string NvvCategoryName { get; set; }
        
        //thuộc tính quan hệ 
        public virtual ICollection<NvvBook> NvvBooks { get; set; }
    }
}