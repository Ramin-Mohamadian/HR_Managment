using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.MVC.Models
{
    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
       
        [Required]
       
        public int DefaultDay { get; set; }
    }
}
