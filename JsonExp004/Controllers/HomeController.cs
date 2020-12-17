using JsonExp004.DataAccess;
using JsonExp004.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Providers.Entities;

namespace JsonExp004.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(Company company)
        //{
        //    //string json = JsonConvert.SerializeObject(company);
        //    using (MongoRepository<Company> mongoRepository = new MongoRepository<Company>())
        //    {
        //        Company companyisnull = mongoRepository.Get(x => x.VKN == company.VKN);
        //        if (companyisnull == null)
        //        {
        //            //var companyJson = JsonConvert.SerializeObject(company);
        //            mongoRepository.Add(company);
        //        }
        //        else
        //        {
        //            company.Id = companyisnull.Id;
        //            //company.Name = "Emre";
        //            //company.Address = "Zara";
        //            mongoRepository.Update(x => x.Id == companyisnull.Id, company);
        //            //mongoRepository.Delete(x => x.VKN == company.VKN);
        //        }

        //        var ab = mongoRepository.GetAll().ToList();
        //    }

        //    return View();
        //}
        public IActionResult Show()
        {
            List<Comp> com = new List<Comp>();
            using (MongoRepository<CompanyJson> mongoRepository = new MongoRepository<CompanyJson>())
            {
                //var companyJson = JsonConvert.SerializeObject(company);

                var ab = mongoRepository.GetAll().ToList();
                foreach (var item in ab)
                {
                    Comp comp = JsonConvert.DeserializeObject<Comp>(item.Companies);
                    com.Add(comp);
                }

            }
            //using (UnitOfWork uow = new UnitOfWork())
            //{
            //user = uow.GetRepository<User>().GetAll(x => x.Numbers == number).FirstOrDefault();

            //user = uow.GetRepository<User>().GetAll().ToList();
            //}
            return View(com);
        }

        [HttpPost]
        public IActionResult Index(Comp company)
        {
            string json = JsonConvert.SerializeObject(company);
            using (MongoRepository<CompanyJson> mongoRepository = new MongoRepository<CompanyJson>())
            {
                //var companyJson = JsonConvert.SerializeObject(company);
                mongoRepository.Add(new CompanyJson()
                {
                    Companies = json
                });
                var ab = mongoRepository.GetAll().ToList();

            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
