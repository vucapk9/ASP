using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvvBaithigiuaki.Models
{
    public class NvvCustomer
    {
        [Key]
        public int NvvId { get; set; }

        [Required(ErrorMessage = "Nvv:mã khách hàng không được bỏ trống")]
        [RegularExpression(@"^[A-Za-z\s]{2,30}$", ErrorMessage = "FullName chỉ chứa ký tự A-Z, a-z và khoảng trắng, tối thiểu 2 ký tự, tối đa 30 ký tự.")]
        public string NvvFullName { get; set; }

        [Required(ErrorMessage = "Nvv :Email không được bỏ trống")]
        [EmailAddress(ErrorMessage = "Email phải đúng định dạng ví dụ example@gmail.com.")]
        public string NvvEmail { get; set; }

        [Required(ErrorMessage = "Nvv :Phone không được bỏ trống")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone phải có 10 ký tự số.")]
        public string NvvPhone { get; set; }

        [Required(ErrorMessage = "Nvv: age không được bỏ trống")]
        [Range(18, 65, ErrorMessage = "Age phải trong phạm vi 18-65.")]
        public int NvvAge { get; set; }

        [Required(ErrorMessage = "Nvv :Gender là không được bỏ trống")]
        [RegularExpression(@"^[01]$", ErrorMessage = "Gender chỉ chứa 1 ký tự là 0 hoặc 1.")]
        public string NvvGender { get; set; }
    }
}