using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvvLesson06.Models
{
    public class NvvSong
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Nvv:Hãy nhập tên bài hát")]
        [DisplayName("Tiêu đề")]
        public string NvvTitle { get; set; }
        [Required (ErrorMessage = "Nvv: Hãy nhập tên tác giả bài hát" )]
        [DisplayName("Tác giả ")]
        public string NvvAuthor { get; set; }
        [Required(ErrorMessage ="Nvv: Hãy nhập nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Nvv: độ dài trong khoảng[2-100]")]
        [DisplayName("Nghệ sĩ")]
        public string NvvArtist { get; set; }
        [Required(ErrorMessage ="Nvv:Hãy nhập năm sản xuất")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Nvv: Nhập năm xuất bản là 4 ký tự số")]
        [Range(1900,2020,ErrorMessage ="Nvv: Nhập năm trong khoảng [1900-2020]")]
        [DisplayName("Năm xuất bản")]
        public int NvvYearRelease { get; set; }
    }
}