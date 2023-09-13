using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistration.Domain.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [MaxLength(100)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string last_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string email { get; set; }

        [Required]
        [MaxLength(100)]
        public string phone { get; set; }
    }
}
