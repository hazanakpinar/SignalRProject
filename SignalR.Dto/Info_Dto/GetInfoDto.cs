using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Dto.Info_Dto
{
    public class GetInfoDto
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
