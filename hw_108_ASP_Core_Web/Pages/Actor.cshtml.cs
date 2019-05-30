using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hw_108_ASP_Core_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace hw_108_ASP_Core_Web.Pages
{
    public class ActorsModel : PageModel
    {
        public List<Actor> ActorList; //= new List<Actor>();
        public List<Character> C2List = new List<Character>();

        public void OnGet()
        {
            using (var db = new HP())
            {
                ActorList =
                   (from actors in db.Actors
                    join Char in db.Characters
                    on actors.CharacterID equals Char.CharacterID
           
                select new
                { 
                    name = actors.ActorName,   
                    C = Char.CharacterName
                }).ToList();

                ///C2List = db.Characters.ToList(); 
                // ActorList = db.Actors.ToList();
            }
        }
    }
}