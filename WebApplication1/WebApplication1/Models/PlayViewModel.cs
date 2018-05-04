using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PlayViewModel
    {
        public PlayViewModel(string Errand)
        {
            this.ErrandTitle = "Bibliotek";
        }
        

        [Key]
        public int KeyId { get; set; }
        public string ErrandTitle { get; set; }
        public string Status { get; set; }
        public string OrderedByCompany { get; set; }
        public string OrderedByPerson { get; set; }
        public string Overseer { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }
        public DateTime Closed { get; set; }
        public DateTime ExpectedClosingDate { get; set; }
        public DateTime Altered { get; set; }
        public DateTime Created { get; set; }
    }
}
