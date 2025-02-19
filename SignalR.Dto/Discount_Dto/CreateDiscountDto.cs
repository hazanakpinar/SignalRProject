using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Dto.Discount_Dto
{
    public class CreateDiscountDto

    {
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
