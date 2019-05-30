using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_108_ASP_Core_Web.Models
{
    public partial class Movies
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public int YearReleased { get; set; }
    }
}
