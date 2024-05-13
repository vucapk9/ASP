using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvvLab04_2.Models
{
    public class nvvICustomerRepositoryController : Controller
    {
        //định nghĩa giao diện khách hàng
        public interface ICustomerRepository
        {
            //khai báo phương thức lấy danh sách khách hàng
            IList<nvvCustomer> GetCustomers();
            //khai báo phương thức lấy khách hàng
            nvvCustomer GetCustomer(string customerId);
            //khai báo phương thức thêm khách hàng
            void AddCustomer(nvvCustomer cus);
            //khai báo phương thức cập nhật khách hàng
            void UpdateCustomer(nvvCustomer cus);
            //khai báo phương thức tìm kiếm khách hàng
            IList<nvvCustomer> SearchCustomer(string name);
            //khai báo phương thức xóa khách hàng
            void DeleteCustomer(nvvCustomer cus);
        }
    }
    //định nghĩa lớp CustomerRepository thực thi từ giao diện ICustomerRepository
    public class CustomerRepository : ICustomerRepository
    {
        //khởi tạo danh sách khách hàng
        static readonly List<nvvCustomer> data = new List<nvvCustomer>()
{
new nvvCustomer(){ CustomerId = "KH001",
FullName = "Trịnh Văn Chung",Address = "Hà Nội",
Email = "devmaster.founder@gmail.com",
Phone = "0978.611.889",Balance = 15200000},
new nvvCustomer(){ CustomerId = "KH002",
FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
Email = "cucdt@gmail.com",Phone = "0986.767.444",
Balance = 2200000},
new nvvCustomer(){ CustomerId = "KH003",
FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
Email = "thangnt@gmail.com",Phone = "0924.656.542",
Balance = 1200000},
new nvvCustomer(){ CustomerId = "KH004",
FullName = "Lê Ngọc Hải",Address = "Hà Nội",
Email = "hailn@gmail.com",Phone = "0996.555.267",
Balance = 6200000}
};
        //thực thi phương thức lấy danh sách khách hàng
        public IList<nvvCustomer> GetCustomers()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<nvvCustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public nvvCustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        //thực thi phương thức thêm khách hàng
        public void AddCustomer(nvvCustomer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void UpdateCustomer(nvvCustomer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }
        //thực thi phương thức xóa khách hàng
        public void DeleteCustomer(nvvCustomer cus)
        {
            data.Remove(cus);
        }
    }
    //Bước 6: Tạo Controller “CustomerController” trong thư mục Controllers
    public class CustomerController : Controller
    {
        //khai báo biến CustomerRepository
        static CustomerRepository listCustomer;
        public CustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new CustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult GetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(nvvCustomer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(nvvCustomer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("GetCustomers");
        }
    }
}