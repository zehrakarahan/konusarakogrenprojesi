using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KonusarakOgren.WebUI.Models;
using System.Net;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.EntityFrameworkCore.Internal;
using KonusarakOgren.WebUI.Models.Context;

namespace KonusarakOgren.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            const string username ="";
            //ViewBag.Name = HttpContext.Session.GetString(username);
            using (var dbContext = new KonusarakOgrenContext())
            {
                dbContext.Database.EnsureCreated();
                var exam = dbContext.ExamQuestions.ToList();
                foreach (var item in exam)
                {
                    dbContext.ExamQuestions.Remove(item);
                    dbContext.SaveChanges();
                }
               
            }
            string html;
            try
            {
                Uri url = new Uri("https://www.wired.com");

                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(html);
                MakaleProperty makaleProperty = new MakaleProperty();
                makaleProperty.Makalatitle = new List<string>();
                var nodes = doc.DocumentNode.SelectNodes("//div[@class='cards-component__row']/div");
                for (int i = 0; i < nodes.Skip(4).Count(); i++)
                {
                    var veri = nodes[i].SelectSingleNode(".//h2").InnerText;

                    makaleProperty.Makalatitle.Add(veri);
                }
                return View(makaleProperty);

            }
            catch (Exception)
            {

                throw;
            }
            


        }
        //Soruları Eklediğimiz Kısım
        public IActionResult ExamCreate()
        {
            ExamProperty model = new ExamProperty();
            model.ExamQuestions = new List<ExamQuestions>();
            model.MakaleContext = new List<string>();
            try
            {

                IWebDriver driver = new ChromeDriver();//Seleniumla istek atıyorum siteye  
                string link = "https://www.wired.com";
                driver.Navigate().GoToUrl(link); //asagıda seleniumla ikinci makaleye tıklıyoruz 
                IWebElement element = driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]/h2"));
                model.makaletitle = element.Text;
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]")).Click();
                // ve yukarıda ikinci makaleye tıkladık

                IList<IWebElement> elements = driver.FindElements(By.TagName("p")); //tıkladıgımız sayfadaki p etiketlerini al dedik
                foreach (var item in elements)    //bunu listeye attık.
                {
                    model.MakaleContext.Add(item.Text);
                }
                return View(model);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        //Soruları kaydettigimiz kısım
        [HttpPost]
        public IActionResult ExamCreate(List<ExamQuestions> examQuestions)
        {
            try
            {
                
                using (var dbContext = new KonusarakOgrenContext())
                {
                    dbContext.Database.EnsureCreated();

                    for (int i = 0; i < examQuestions.Count(); i++)
                    {
                        dbContext.ExamQuestions.Add(examQuestions[i]);
                        dbContext.SaveChanges();
                    }

                    //foreach (var item in examQuestions)
                    //{
                    //    dbContext.ExamQuestions.Add(item);
                    //    dbContext.SaveChanges();
                    //}

                }
                return RedirectToAction("ExamList");
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        //Silme işlemi
        public IActionResult ExamSil(int vid)
        {
            using (var dbContext = new KonusarakOgrenContext())
            {
                dbContext.Database.EnsureCreated();
                var exam = dbContext.ExamQuestions.Where(x=>x.Id==vid).FirstOrDefault();
                dbContext.ExamQuestions.Remove(exam);
                dbContext.SaveChanges();
            }
            return RedirectToAction("ExamList");
        }
        //Sorulari  listeleme ve silme islemine gidilen kısım
        public IActionResult ExamList()
        {
            ExampleModelList model = new ExampleModelList();
            model.examQuestions = new List<ExamQuestions>();
            model.Response = new List<string>();
         
            using (var dbContext = new KonusarakOgrenContext())
            {
                
                var list = dbContext.ExamQuestions.ToList();
                foreach (var item in list)
                {
                    model.examQuestions.Add(item);
                   
                }
            }
            return View(model);

        }

        public IActionResult BeingQuizz()
        {
            try
            {
            ExamProperty examProperty = new ExamProperty();
            examProperty.MakaleContext = new List<string>();
            examProperty.ExamQuestions = new List<ExamQuestions>();
            using (var dbContext = new KonusarakOgrenContext())
            {
          
                dbContext.Database.EnsureCreated();
                var list=dbContext.ExamQuestions.ToList();
                if (list.Count()==0)
                {
                        return RedirectToAction("ExamCreate");
                }
                foreach (var item in list)
                {
                    examProperty.ExamQuestions.Add(item);
                }
            }
                IWebDriver driver = new ChromeDriver();//Seleniumla istek atıyorum siteye  
                string link = "https://www.wired.com";
                driver.Navigate().GoToUrl(link); //asagıda seleniumla ikinci makaleye tıklıyoruz 
                IWebElement element = driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]/h2"));
                examProperty.makaletitle = element.Text;
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]")).Click();
                // ve yukarıda ikinci makaleye tıkladık

                IList<IWebElement> elements = driver.FindElements(By.TagName("p")); //tıkladıgımız sayfadaki p etiketlerini al dedik
                foreach (var item in elements)    //bunu listeye attık.
                {
                    examProperty.MakaleContext.Add(item.Text);
                }
                return View(examProperty);
            }
            catch (Exception)
            {

                throw;
            }

           
        }

        public IActionResult ExamSonuc(string dizi)
        {
            string[] hobiListe = dizi.Split(',');
            ExamRequiredModel model = new ExamRequiredModel();
            model.ExamQuestions = new List<ExamQuestions>();
            model.Makalecontent = new List<string>();
            model.Usercevap = new List<string>();
            using (var dbContext = new KonusarakOgrenContext())
            {

                dbContext.Database.EnsureCreated();
                var list = dbContext.ExamQuestions.ToList();
                if (list.Count() == 0)
                {
                    return RedirectToAction("ExamCreate");
                }
                for (int i = 0; i <hobiListe.Count(); i++)
                {
                    model.Usercevap.Add(hobiListe[i]);
                }
                foreach (var item in list)
                {

                    model.ExamQuestions.Add(item);
                  
                }
            }
            IWebDriver driver = new ChromeDriver();//Seleniumla istek atıyorum siteye  
            string link = "https://www.wired.com";
            driver.Navigate().GoToUrl(link); //asagıda seleniumla ikinci makaleye tıklıyoruz 
            IWebElement element = driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]/h2"));
            model.makaletitle = element.Text;
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@class='card-component card-component--narrow card-component--left card-component--border']/div/ul/li[2]/a[2]")).Click();
            // ve yukarıda ikinci makaleye tıkladık

            IList<IWebElement> elements = driver.FindElements(By.TagName("p")); //tıkladıgımız sayfadaki p etiketlerini al dedik
            foreach (var item in elements)    //bunu listeye attık.
            {
                model.Makalecontent.Add(item.Text);
            }

            return View(model);
        }
    }
}
