using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArmchairLeague.Models;

namespace ArmchairLeague.Controllers
{
    public class DraftController : Controller
    {
        public ActionResult Index()
        {
			Session["teams"] = new List<Team>()
            {
				new Team("Blue Owls", "http://pre13.deviantart.net/9672/th/pre/f/2015/288/8/3/owl_team_logo_by_lians1264-d9d76fz.jpg"),
                new Team("The Commish", "https://img2.brain3.photobox.com/45861624ffb73df36366d77604320a516bd3eaa378c039980a370284f9608da76239653f.jpg"),
                new Team("The Kareem Always Rises", "http://2.bp.blogspot.com/-aqy6J_gkWH8/Tj8qxcvvjfI/AAAAAAAAJKQ/QMHwy6WNbuo/s1600/Ralph%2527s%2Bheavy%2Bwhipping%2Bcream.jpg"),
				new Team("Trump Train", "http://i.imgur.com/OCyR1zD.png"),
				new Team("Hurricane Ditka", "https://s-media-cache-ak0.pinimg.com/736x/bd/f7/a6/bdf7a6a7b4384abf605a1cb4169a0f1b.jpg"),
                new Team("Roy Moore", "https://i.imgur.com/jPV5w54.jpg"),
				new Team("The Trenchmen", "http://g.espncdn.com/lm-static/ffl17/images/default.svg"),
				new Team("The Continuum", "http://g.espncdn.com/s/ffllm/logos/Marvel-75thAnnivSuperHeroIcons/MsMarvel-01.svg"),
                new Team("Milky Way Space Force", "http://g.espncdn.com/s/ffllm/logos/OldeTymeFootball-AndrewJanik/Warriors_08.svg"),
				new Team("By Any Means Necessary", "http://40.media.tumblr.com/tumblr_mdnhmkxULM1rgam01o1_1280.jpg"),
				new Team("Las Nalgas", "http://g.espncdn.com/s/ffllm/logos/Referee-MartinLaksman/referee-08.svg"),
                new Team("I Feel Like Tiger", "https://www.biography.com/.image/c_fit%2Ccs_srgb%2Ch_406%2Cq_50%2Cw_620/MTE1ODA0OTcxODI5NjU5MTQ5/tiger-woods-9536492-4-raw.jpg"),
			};

            return View ();
        }

        public ActionResult GetNextTeam()
        {
            List<Team> teams = (List<Team>)Session["teams"];

            var random = new Random();
            int index = random.Next(teams.Count);

            Team nextTeam = teams[index];
            teams.Remove(nextTeam);

            Session["teams"] = teams;

            return Json(nextTeam, JsonRequestBehavior.AllowGet);
        }
    }
}
