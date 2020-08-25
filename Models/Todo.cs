using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Office.Models;
using Office.Validations;

namespace Office.Models
{
    public class Todo
    {
        [Key]
        public int TodoId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        [Future]
        public DateTime DueDate {get;set;}
        [Required]
        public int Difficulty {get;set;}
        [Required]
        public string Description {get;set;}
        public Boolean Completed {get;set;} = false;
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int UserId {get;set;}

        public User Giver {get;set;}
        public List<Participation> Supporters {get;set;}

    }
}