using System;
using System.Dynamic;
using Nancy;
using Nancy.Authentication.Forms;
using Nancy.Extensions;
using Nancy.Security;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Noble
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            this.RequiresAuthentication();

            Get["/"] = x =>
            {
                return View["index"];
            };

        }
    }
}