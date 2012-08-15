//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Machine.Specifications;
//using System.Dynamic;
//using Nancy;
//using Nancy.Testing;

//namespace Noble.Tests.Specs
//{
//    //Subject/It/Because of/Establish context/Cleanup after
//    [Subject("Login")]
//    public class When_using_correct_credentials : BrowserTestBase
//    {
        
//        Because of = () => response = browser.Post("/login/", (with) =>
//            {
//                with.HttpRequest();
//                with.FormValue("Username", "username");
//                with.FormValue("Password", "wrongpassword");
//            });

//        It should_display_a_login_screen =
//            () =>
//            {
//                response.ShouldHaveRedirectedTo("/login?error=true&username=username");
//            };

//        //Cleanup after = () => ExpandoObject = null;
//    }
//}
