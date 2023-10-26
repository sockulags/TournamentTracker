﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Competing persons first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Competing persons last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Competing persons email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Competing persons phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
