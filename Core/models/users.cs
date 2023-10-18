using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Users
    {
    
        [Key]
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
         

        public ICollection<likedFilms> likedFilms { get; set;}

        public ICollection<Viewedfilms> viewedFilms { get; set;}
    }
}
