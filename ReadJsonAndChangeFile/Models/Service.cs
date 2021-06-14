using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReadJsonAndChangeFile.Models
{
    public class Service
    {
        public string Description { get; set; }
        public string EndPoint { get; set; }
        public string Template { get; set; }
        public string Time { get; set; }

        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
    }
}
