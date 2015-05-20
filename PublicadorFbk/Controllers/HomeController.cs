using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace PublicadorFbk.Controllers
{
    public class HomeController : Controller
    {
        private string user_token ="CAAI0f3PIDeEBABvSCzueKbeia6gCzylAk1QZAqLK0kaOx4hTzJG1tfvZBmZA5EHvCh7xs5JMJNNdVIzcemXZAftZChmAZBC2y7Eo7eBAGP5jKbRfrcXMPGrYM0Ky2NjiZAR8NKeXcVTZBZBjAKMh3OWgb8u5UBOzaV5iZB9fcRrkCIZCNLJbE25lE1pu3oKX9bhWM6miUZA4qZBl2WwaZAmkaxvGjflPNLQhZChaCoZD";

       
        
        private string app_token = "620671961402849|ufNXr14R9t2m7aZJD6KyjlKIRnI";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ler()
        {
            //var cliente = new FacebookClient();
            //dynamic me = cliente.Get("fernandopientka");
            //ViewBag.Me = me;


            string teste = "183306468352624";


            //var cliente = new FacebookClient(user_token);

            var cliente = new FacebookClient();
            dynamic me = cliente.Get(teste);


           // cliente.Post("/me/feed", new {message="Testando Publicador FBK com C#."});

 


            ViewBag.Me = me;

           

            return View();
        }

        public ActionResult Publicar()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}