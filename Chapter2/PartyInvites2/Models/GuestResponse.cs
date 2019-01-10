﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}