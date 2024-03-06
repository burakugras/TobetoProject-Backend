﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserSocialMediaRequests
{
    public class UpdateUserSocialMediaRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SocialMediaId { get; set; }
        public string Url { get; set; }
    }
}
