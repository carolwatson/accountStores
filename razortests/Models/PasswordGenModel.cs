using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountStore.Models
{
    public class PasswordGenModel
    {


        public int MaxLength { get; set; } = 15;

        public Strength IsStrong { get; set; }

       
        public string GeneratedPassword { get; set; }

        public bool UseCaps { get; set; }

        public bool UseSymb { get; set; }

        public bool UseNumbers { get; set; }


    }

    public enum Strength
    {
        Weak,
        Medium,
        Strong
    }


}

