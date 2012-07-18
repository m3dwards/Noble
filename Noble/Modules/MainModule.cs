namespace Noble
{
    using System;
    using System.Dynamic;
    using Nancy;
    using Nancy.Authentication.Forms;
    using Nancy.Extensions;
    using Nancy.Security;

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