using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ServiceAppointmentSystem.Models.Entities
{
    public class AppUser : IdentityUser //Extends the IdentityUser Class
    {
        [Required]
        public string FullName { get; set; }    

        [Required]
        public byte[] ProfileImage { get; set; }

        [Display(Name = "City")]
        public string CityAddress { get; set; }

        [Display(Name = "Region")]
        public string RegionName { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
		//The ICollection<T> interface provides functionality for managing a collection of objects, in this case, appointments.
	}
}
