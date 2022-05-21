using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4FormApplication
{
   public class UserCommand : EntityValidator
    {
        [Range(1,100)]
        public String commandSent { get; set; }
 
    }
}
