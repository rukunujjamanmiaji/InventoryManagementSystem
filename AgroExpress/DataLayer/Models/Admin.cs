﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AgroExpress.DataLayer.Models
{
    [Table("ADMIN")]
    public class Admin
    {
        #region
        [Key]
        public int PKAdminId { get; set; }

        [Display(Name = "Admin Full Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Admin Full Name required")]
        public string FullName { get; set; }


        [Display(Name = "Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address required")]
        [MaxLength(200, ErrorMessage = "Address can be Maximum 200 characters")]
        public string Address { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mobile Number required")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Mobile Number must be 11 characters")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile Number must be numeric")]
        public string Mobile { get; set; }

        [Display(Name = "Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address required")]
        public string Email { get; set; }

        [Column(Order = 1)]
        [ForeignKey("userLogin")]
        public int LoginUserID { get; set; }
        public virtual UserLogin userLogin { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}