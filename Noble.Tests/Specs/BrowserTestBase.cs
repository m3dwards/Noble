using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using System.Dynamic;
using Nancy;
using Nancy.Testing;


namespace Noble.Tests.Specs
{
    public class BrowserTestBase
    {
        protected static DefaultNancyBootstrapper bootstrapper;
        protected static Browser browser;
        protected static BrowserResponse response;

        protected Establish a = () =>
        {
            bootstrapper = new TestBootstrapper();
            browser = new Browser(bootstrapper);
        };

    }
}
