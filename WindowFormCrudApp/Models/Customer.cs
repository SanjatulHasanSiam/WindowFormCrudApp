using System;
using System.Collections.Generic;

namespace WindowFormCrudApp.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
