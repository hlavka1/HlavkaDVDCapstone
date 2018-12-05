using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HlavkaDVDCapstone.Model
{
    public class DVD
    {
        public int ID { get; set; }
        public bool Sequel { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }
        public double Year { get; set; }
        public string Actor { get; set; }

        
    }
}
