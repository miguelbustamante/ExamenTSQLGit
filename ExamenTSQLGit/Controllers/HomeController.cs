using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamenTSQLGit.Models;
using Newtonsoft.Json;

namespace ExamenTSQLGit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveExam([FromBody] Examen exam) {

            

            if (exam != null)
            {
                try
                {
                    var logPath = exam.NombreEvaluado + DateTime.Now.ToString("yyyyMMdd");
                    var logFile = System.IO.File.Create(logPath + ".json");
                    var logWriter = new System.IO.StreamWriter(logFile);
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(logWriter, exam);
                    logWriter.Dispose();
                    return Json("Examen guardado exitosamente, !Suerte¡");
                }
                catch (Exception ex)
                {

                    return Json("An error has ocured " + ex.Message);
                }
            }
            else
            {
                return Json("An Error Has occoured");
            }
        }
    }
}
