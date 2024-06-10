using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nvv.Lesson08CF.Models
{
    /// <summary>
    ///  tạo ra câu trúc bảng book
    /// </summary>
    public class NvvBook
    {
        [Key]
        public int NvvBookId { get; set; }
        public string NvvMyProperty { get; set; }
        public string NvvAuthor { get; set; }
        public int NvvYear { get; set; }
        public string NvvPublisher { get; set; }
        public string NvvPicture { get; set; }
        public int NvvCategoryId { get; set; }

        // thuộc tính quan hệ 
        public virtual NvvCategory nvvCategory { get; set; }
    }
}