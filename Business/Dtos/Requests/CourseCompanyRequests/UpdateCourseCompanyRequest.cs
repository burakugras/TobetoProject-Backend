﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseCompanyRequests
{
    public class UpdateCourseCompanyRequest
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CompanyId { get; set; }
    }
}
