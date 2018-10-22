using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotExample.Model
{
   public class Robot:Location
    {
        public string Name { get; set; }
        public string Direction { get; set; }
        public Char[] Movement { get; set; }
    }
}
