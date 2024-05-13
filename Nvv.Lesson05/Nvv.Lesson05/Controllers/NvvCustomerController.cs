using Nvv.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvv.Lesson05.Controllers
{
    public class NvvCustomerController : Controller
    {
        // GET: NvvCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action: NvvCustomerDetail
        public ActionResult NvvCustomerDetail() 
        {
            // tạo đối tượng dữ liệu
            var customer = new NvvCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyễn Văn",
                LastName = "Vũ",
                Address = "K22CNT2",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        // GET: NvvListCustơer
        public ActionResult NvvListCutomer() 
        {
            var list = new List<NvvCustomer>()
            {
                new NvvCustomer()
                {
                CustomerId = 1,
                FirstName = "Nguyễn Văn",
                LastName = "Vũ",
                Address = "K22CNT2",
                YearOfBirth = 2004
                },
                new NvvCustomer()
                { 
                CustomerId = 2,
                FirstName = "Nguyễn Như",
                LastName = "Ngọc",
                Address = "Sư phạm 1",
                YearOfBirth = 2002
                },
                 new NvvCustomer()
                {
                CustomerId = 3,
                FirstName = "Nguyễn Bùi",
                LastName = "Phượng",
                Address = "Sư phạm 2",
                YearOfBirth = 2002
                },
                  new NvvCustomer()
                {
                CustomerId = 4,
                FirstName = "Nguyễn Linh",
                LastName = "Chi",
                Address = "Sư phạm 3",
                YearOfBirth = 2002
                }
            };
            ViewBag.list = list;  // đưa dữ liệu view bằng đối tượng ViewBag

        return View();
        }
    }
}