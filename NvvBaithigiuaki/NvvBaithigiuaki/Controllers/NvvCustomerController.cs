using NvvBaithigiuaki.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

public class NvvCustomerControllers : Controller
{
    private static List<NvvCustomer> nvvCustomers = new List<NvvCustomer>
    {
        new NvvCustomer{NvvId=221090081,NvvFullName="Nguyễn Văn Vũ",NvvEmail="nguyenvanvu642004@gmail.com",NvvPhone="0812056108",NvvAge=22},
        new NvvCustomer{NvvId=23141516,NvvFullName="Nguyễn Văn Ngọc",NvvEmail="nguyenvanngoc@gmail.com",NvvPhone="0812056108",NvvAge=11},
        new NvvCustomer {NvvId =1224526, NvvFullName = "Nguyễn Văn Bảo", NvvEmail = "nguyenvanbo@gmail.com", NvvPhone = "0812056108", NvvAge = 5 }
    };

    public ActionResult List()
    {
        return View(nvvCustomers);
    }

    // GET: NvvCustomer
    public ActionResult Index()
    {
        return View(nvvCustomers);
    }

    // GET: HvtCustomer/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: HvtCustomer/Create
    [HttpPost]
    public ActionResult Create(NvvCustomer customer)
    {
        if (ModelState.IsValid)
        {
            nvvCustomers.Add(customer);
            return RedirectToAction("Index");
        }

        return View(customer);
    }

    // GET: HvtCustomer/Edit/5
    public ActionResult Edit(int id)
    {
        var customer = nvvCustomers.FirstOrDefault(c => c.NvvId == id);
        if (customer == null)
        {
            return HttpNotFound();
        }
        return View(customer);
    }

    // POST: HvtCustomer/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, NvvCustomer customer)
    {
        if (ModelState.IsValid)
        {
            var existingCustomer = nvvCustomers.FirstOrDefault(c => c.NvvId == id);
            if (existingCustomer != null)
            {
                // Update customer details
                existingCustomer.NvvFullName = customer.NvvFullName;
                existingCustomer.NvvEmail = customer.NvvEmail;
                existingCustomer.NvvPhone = customer.NvvPhone;
                existingCustomer.NvvAge = customer.NvvAge;
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }
        return View(customer);
    }
}