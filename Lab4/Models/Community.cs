﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class Community
    {
        //	make sure this is not database generated by setting the DatabaseGenerated attribute to DatabaseGeneratedOption.None
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // display name should read ‘Registration Number’
        [Display(Name = "Registration Number")]
        [Required]
        public string Id { get; set; }

        [Required]
        //	add the ‘StringLength’ attribute, with a value of max 50 and MinimumLength = 3
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        // attributes to define data type currency and column type money
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }
        //For Navigational properties you define in Community and Student models, name both Membership, and make sure that they navigate to CommunityMembership
        public CommunityMembership Membership { get; set; }

    }

   
}
