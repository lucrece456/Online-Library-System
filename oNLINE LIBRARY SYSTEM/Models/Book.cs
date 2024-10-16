using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oNLINE_LIBRARY_SYSTEM.Models
{
    public class Book
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }


        // Add other properties as needed

        // Navigation properties if relationships are needed
        // public int UserId { get; set; }
        // public User User { get; set; }

    }
}