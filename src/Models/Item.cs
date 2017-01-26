using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OnlineStore.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Item
    {
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(30)]
		public string Name { get; set; }

		[Required]
		[MinLength(10)]
		[MaxLength(300)]
		public string Description {get;set;}

		[Required]
		public decimal Price  { get; set; }
    }
}
