﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Dto.About_Dto
{
    public class GetAboutDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
