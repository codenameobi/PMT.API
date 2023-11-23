using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Data.Models
{
    internal class Action
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public Project project { get; set;}
    }
}
