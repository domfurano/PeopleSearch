using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearch.ViewModels
{
    public class PersonSearchRequest
    {
        public string searchString { get; set; }
        public bool slow { get; set; }
    }
}
