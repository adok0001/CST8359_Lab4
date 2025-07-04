﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class CommunityMembership
    {
        public int StudentId { get; set; }
        public string CommunityId { get; set; }
        // add the proper navigational properties to CommunityMembership, Community and Student models
        public Student Student { get; set; }
        public Community Community { get; set; }
    }
}
