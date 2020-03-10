using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maintenance.IRepository;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using O3BookingApp.DataModel;
using O3BookingApplication.Models;

namespace O3BookingApp.Controllers
{
    public class BookingController : Controller
    {

      
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {

            Task.FromResult(0);
            var client = new MongoClient("mongodb://192.168.0.2:27017");
            var database = client.GetDatabase("user");
            var collec = database.GetCollection<BsonDocument>("Service");
            var document = new BsonDocument
                    {
                     {"Duration",service.Duration },
                     {"ServiceName",service.ServiceName },
                     {"Prize",service.Prize },
                     {"Image",service.Image },
                     {"Description",service.Description }


                  };

            collec.InsertOneAsync(document);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BookingForm()
        {

            return View();
        }
        [HttpPost]
        public IActionResult BookingForm(User user)
        {

            var model = user;
            var client = new MongoClient("mongodb://192.168.0.2:27017");
            var database = client.GetDatabase("user");
            var collec = database.GetCollection<BsonDocument>("userform");
            int id = 0;
            List<User> userList = new List<User>();

            var document = new BsonDocument {

                {"Id",model.Id },
                {"Name",model.Name },
                {"Email",model.Email },
                {"PhNo",model.PhNo },
                {"Service",model.Service },
                {"Price",model.Price },
                {"Duration",model.Duration },
                {"Date",model.Date }
            };
            collec.InsertOneAsync(document);
          
            return View();
        }




    }
}
