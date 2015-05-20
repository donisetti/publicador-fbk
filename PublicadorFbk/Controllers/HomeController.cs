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
        private string user_token = "CAACEdEose0cBAGUZCpNRXv7b03uVsc6pbqKTbHgUEVm90Bd3nreTW4KM7w467FQe7i5rdd1JnvPZBvbmMk3P8DpjmaBlKrXwPvvC4DQV3nlQzyDkb1aIp6LjQBnRmqXXWDXMws2Rkmgwo1sfHPeu6cINVvih245ZBt9H5seKTIm1WJkpZBnJ2RmipuAr7YH5CCZCdQLOf8f79ZBlDV3W28MjVZAKuBcGjwZD";

       
        
        private string app_token = "620671961402849|ufNXr14R9t2m7aZJD6KyjlKIRnI";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ler()
        {
            var cliente = new FacebookClient(user_token);
            dynamic me = cliente.Get("me/groups");
            ViewBag.Me = me;


            //string teste = "183306468352624";


            ////var cliente = new FacebookClient(user_token);

            //var cliente = new FacebookClient();
            //dynamic me = cliente.Get(teste);


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