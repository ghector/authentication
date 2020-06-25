using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Onoma.Models
{
    public static class RoleName
    {
        public const string Administrators = "Administrators";
        public const string Spectators = "Spectators";
    }

    enum RoleOnoma //Gia sigkrisi
    {
        Administrators,
        Spectators
    }

    class Student
    {
        [Required]
        public int Name { get; set; }
    }
}