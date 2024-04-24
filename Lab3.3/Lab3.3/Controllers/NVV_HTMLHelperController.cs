using Lab3._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3._3.Controllers
{
    public class NVV_HTMLHelperController : Controller
    {
        // GET: HTML_Helper_Methods
        public ActionResult FormRegister()
        {
            // tạo list cho droplist
            ViewBag.listCountry = new List<country>() {
        new country(){ID="0",Name="-- Chọn Quốc Gia --"},
        new country(){ID="VN",Name="Việt Nam"},
        new country(){ID="AT",Name="AUSTRALIA"},
        new country(){ID="UK",Name="Anh"},
        new country(){ID="FR",Name="Pháp"},
        new country(){ID="US",Name="Mỹ"},
        new country(){ID="KP",Name="Hàn Quốc"},
        new country(){ID="HU",Name="Hồng Kong"},
        new country(){ID="CN",Name="Trung Quốc"},
};
            return View();
        }

        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            string fvr = "";
            TempData["UName"] = Request["txtUName"];
            TempData["Pass"] = Request["txtPass"];
            TempData["FName"] = Request["txtFName"];
            TempData["Gender"] = Request["Gender"];
            TempData["Address"] = Request["txtAddress"];
            TempData["Email"] = Request["txtEmail"];
            TempData["Country"] = Request["Country"];

            if (Request["Reading"].ToString().Contains("true")) fvr
            += "Reading ,";
            if (Request["Shopping"].ToString().Contains("true")) fvr +=
            "Shopping ,";
            if (Request["Sport"].ToString().Contains("true")) fvr += "Sport,";

TempData["Favourist"] = fvr;

            return View();
        }
        public ActionResult PrimeNumbers()
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return View(primes);
        }
        public ActionResult Factorials()
        {
            Dictionary<int, long> factorials = new Dictionary<int, long>();

            for (int i = 1; i <= 10; i++)
            {
                long factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                factorials.Add(i, factorial);
            }

            return View(factorials);
        }
        public ActionResult MultiplicationTable()
        {
            Dictionary<int, List<int>> multiplicationTable = new Dictionary<int, List<int>>();

            for (int i = 2; i <= 9; i++)
            {
                List<int> row = new List<int>();
                for (int j = 1; j <= 10; j++)
                {
                    row.Add(i * j);
                }
                multiplicationTable.Add(i, row);
            }

            return View(multiplicationTable);
        }
    }
}