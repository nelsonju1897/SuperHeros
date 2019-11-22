using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHero_Creator.Models
{
    public class SuperHero
    {
        [Key]
        public  int Id { get; set; }

        [DisplayName ("SuperHero Name")]
        public string superHeroName { get; set; }

        [DisplayName("Alter Ego")]
        public string alterEgo { get; set; }

        [DisplayName("Primary Ability")]
        public string primaryAbility { get; set; }

        [DisplayName("Secondary Ability")]
        public string secondaryAbility { get; set; }

        [DisplayName("Catchphrase")]
        public string catchphrase { get; set; }

    }
}