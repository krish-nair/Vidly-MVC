﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public int MembershipTypeId { get; set; }

        [Min18YeasIfaMember]
        public DateTime? BirthDate { get; set; }
    }
}