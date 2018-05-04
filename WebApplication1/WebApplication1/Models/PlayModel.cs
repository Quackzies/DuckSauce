using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PlayModel
    {
        [Key]
        int KeyId { get; set; }
        string ErrandTitle { get; set; }
        string Status { get; set; }
        string OrderedByCompany { get; set; }
        string OrderedByPerson { get; set; }
        string Overseer { get; set; }
        string Description { get; set; }
        DateTime Started { get; set; }
        DateTime Closed { get; set; }
        DateTime ExpectedClosingDate { get; set; }
        DateTime Altered { get; set; }
        DateTime Created { get; set; }
        string AlteredBy { get; set; }
        string CreatedBy { get; set; }
    }
}
