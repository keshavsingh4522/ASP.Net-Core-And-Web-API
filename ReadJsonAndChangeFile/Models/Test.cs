using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadJsonAndChangeFile.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<Service> Services { get; set; }
    }
}
