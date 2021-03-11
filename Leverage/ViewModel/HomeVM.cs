using Leverage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leverage.ViewModel
{
    public class HomeVM
    {
        public Start Start { get; set; }
        public List<Portfolio> Portfolio { get; set; }
        public List<Services> Services { get; set; }
    }
}
