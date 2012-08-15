//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Machine.Specifications;
//using System.Dynamic;
//using Nancy.Testing;

//namespace Noble.Tests.Specs
//{
//    //Subject/It/Because of/Establish context/Cleanup after
//    [Subject("Homepage")]
//    public class When_a_non_authenticated_user_visits_the_homepage : BrowserTestBase
//    {
        
//        Because of = () => response = browser.Get("/", (with) =>
//            {
//                with.HttpRequest();
//            });

//        It should_redirect_to_a_login_screen = () => response.ShouldHaveRedirectedTo("/login?returnUrl=/");
        
//    }

//    [Subject("Homepage")]
//    public class When_an_authenticated_user_visits_the_homepage : BrowserTestBase
//    {

//        Because of = () => 
//            {
//                response = browser.Post("/login/", (with) =>
//                {
//                    with.HttpRequest();
//                    with.FormValue("Username", "admin");
//                    with.FormValue("Password", "password");
//                })
                
//                .Then.Get("/", (with) =>
//                {
//                    with.HttpRequest();
//                });

//            };

//        It should_return_the_homepage = () =>
//            {
//                response.Body["h1"].ShouldContain("Welcome to Noble Notes!");
//            };

//    }
   
//}
