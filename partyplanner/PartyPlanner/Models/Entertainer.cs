using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyPlanner.Models
{
    public class Entertainer
    {
        public int id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "House / Street")]
        public string Street { get; set; }

        public string Town { get; set; }

        public string City { get; set; }

        [Display(Name = "Contact Number")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Magician")]
        public bool IsMagician { get; set; }

        [Display(Name = "Clown")]
        public bool IsClown { get; set; }

        [Display(Name = "Balloon Animals")]
        public bool IsBalloonAnimals { get; set; }

        [Display(Name = "Petting Zoo")]
        public bool IsPettingZoo { get; set; }

        [Display(Name = "Birthday Cake")]
        public bool IsCakes { get; set; }

        [Display(Name = "Catering Service")]
        public bool IsCatering { get; set; }

        [Display(Name = "Face Painting")]
        public bool IsFacePainting { get; set; }

        [Display(Name = "Juggling")]
        public bool IsJuggling { get; set; }

        [Display(Name = "DJ")]
        public bool IsDJ { get; set; }

        [Display(Name = "Party Games")]
        public bool IsPartyGames { get; set; }

        [Display(Name = "Bouncy Castle")]
        public bool IsBouncyCastle { get; set; }

        [Display(Name = "Puppet Show")]
        public bool IsPuppets { get; set; }

        [Display(Name = "Henna Tattoos")]
        public bool IsHennaTattoos { get; set; }

        [Display(Name = "Hair Braiding")]
        public bool IsHairBraiding { get; set; }

        [Display(Name = "Other?")]
        public bool IsOther { get; set; }

    }
}