using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
    public class AutoViewModel
    {
        public int Id { get; set; }
        
        public string Regnomer { get; set; }
        
        public string Autoname  { get; set; }
        
        public int Age { get; set; }
        
        public bool Crash { get; set; }

        public int Numbercrash { get; set; }
    }
}
