using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IngredientTracker.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Remote("IsCUNameExits", "Managers", ErrorMessage = "user Name Already Exits!")]
        public string ChefUserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string ChefPassword { get; set; }
    }
}