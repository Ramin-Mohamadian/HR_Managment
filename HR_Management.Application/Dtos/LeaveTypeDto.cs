using HR_Management.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Dtos
{
    public  class LeaveTypeDto:BaseDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
