﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.SocialMediaRequests
{
    public class UpdateSocialMediaRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
