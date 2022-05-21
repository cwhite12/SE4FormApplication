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
        [Display(Name = "Command Sent")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public String commandSent { get; set; }
 
    }
}
