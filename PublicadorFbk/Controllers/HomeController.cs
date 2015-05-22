using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Facebook;

namespace PublicadorFbk.Controllers
{
    public class HomeController : Controller
    {
        private string user_token = "CAACEdEose0cBAFoFYNiwMJGGCZCxYOJZCZBGFISUbWZCfs0CdMUjUrMBv7N03bLdGlBWZC2GW38WVhaZBfHYq0xbYHc5ZBZCH1TuZB8OYu10aojsBGpZBcQXDYeWGonmqP0Ox6SPtW4kn3PuuGW3SUV9F62RtE4keZC8iRSZBeC3bZAr6lMyOOmeeHqqoZARnVbRXAmKLxjD1llosQFDtQRv8wYHAQKOcZAeGsnchEZD";

        private string appId = "620671961402849";
        private string appSecret = "62bbc5fb92ec3f07691dcc1cd5bbaac9";
        
        private string app_token = "620671961402849|ufNXr14R9t2m7aZJD6KyjlKIRnI";
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LerAmigos()
        {
            ViewBag.Title = "Amigos";
            var cliente = new FacebookClient(user_token);
            dynamic me = cliente.Get("me/friends");
            //dynamic me = cliente.Get("638732383");
            ViewBag.Me = me;


            //string teste = "183306468352624";


            ////var cliente = new FacebookClient(user_token);

            //var cliente = new FacebookClient();
            //dynamic me = cliente.Get(teste);


           // cliente.Post("/me/feed", new {message="Testando Publicador FBK com C#."});

 


            ViewBag.Me = me;

           

            return View("Ler");
        }

        public ActionResult LerGrupos()
        {
            ViewBag.Title = "Grupos";
            var cliente = new FacebookClient(user_token);




            dynamic me = cliente.Get("me/groups");
         
            ViewBag.Me = me;


            ViewBag.Me = me;



            return View("Ler");
        }

        public ActionResult LerNoticias()
        {
            ViewBag.Title = "Grupos";
            var cliente = new FacebookClient(user_token);




            dynamic me = cliente.Get("me/feed");
            
            ViewBag.Me = me;




            return View("Ler");
        }



        public ActionResult PublicarMensagem()
        {
            ViewBag.Title = "Mensagem";
            var cliente = new FacebookClient(user_token);

             dynamic messagePost = new ExpandoObject();

                messagePost.access_token = user_token;
                messagePost.picture = "https://s3-sa-east-1.amazonaws.com/vegasoft/Treinamento/turma2015.png";
                messagePost.link = "http://vegasoft.com.br/";
                messagePost.name = "Treinamento de Programação .Net";
                messagePost.caption = "Vegasoft TI";
                messagePost.description = "Venha conhecer uma das linguagens mais poderosas da atualidade. O C# juntamente com o Visual Studio podem auxiliar você a criar softwares de qualidade e em pouco tempo.";
                messagePost.message = "Aprenda com os truques do dia-a-dia como é desenvolver aplicações web de forma ágil com ASP .NET MVC 5, Entity Framework e Microsoft Azure.";


                //List<string> lista = new List<string> { "31394651017500932", "126901304095629", "1394651017500932" };


                var result = cliente.Post("/me/feed", messagePost);

                //foreach (var item in lista)
                //{
                //    Thread.Sleep(60000);
                //     result = cliente.Post(string.Format("/{0}/feed",item), messagePost);
                //}

           

            dynamic me = cliente.Get("me/feed");




            ViewBag.Me = me;




            return View("Ler");
        }




        public ActionResult LerFotos()
        {
            ViewBag.Title = "Fotos";
            var cliente = new FacebookClient(user_token);




            dynamic me = cliente.Get("me/photos");
           


            ViewBag.Me = me;



            return View("Ler");
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