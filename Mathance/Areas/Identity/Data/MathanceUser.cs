using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathance.Models;
using Microsoft.AspNetCore.Identity;

namespace Mathance.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MathanceUser class
    public class MathanceUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public string Social { get; set; }

        [PersonalData]
        public bool IsBlocked { get; set; }
        
        [PersonalData]
        public DateTime RegDate { get; set; }

        [PersonalData]
        public List<Post> Posts = new List<Post>();

        [PersonalData]
        public List<Answer> RightAnswers = new List<Answer>();
    }
}
