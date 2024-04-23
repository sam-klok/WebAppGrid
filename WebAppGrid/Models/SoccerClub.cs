using System.Collections.Generic;
using System.Web.Mvc;

namespace WebAppGrid.Models
{
    public class SoccerClub
    {
        public string Name { get; set; }
        public string[] Players { get; set; }
        public IEnumerable<SelectListItem> PlayersOptions { get; set; }
    }
}