using System;
using System.Dynamic;
using Nancy;
using Nancy.Authentication.Forms;
using Nancy.Extensions;
using Nancy.Security;
using MongoDB.Bson;
using MongoDB.Driver;
using Noble.Infrastructure.Data;
using Noble.Models;

namespace Noble
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            //this.RequiresAuthentication();

            Get["/"] = x =>
            {
                var repo = new MongoRepository<User>();
                var users = repo.GetAll();
                return View["index", users];
            };

            Post["/"] = x =>
            {
                var repo = new MongoRepository<User>();
                var user = new User { Username = "Max" };
                repo.Save(user);

                return Response.AsRedirect("/");
            };
        }
    }
}