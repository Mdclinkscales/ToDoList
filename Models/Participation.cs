using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Office.Models;

namespace Office.Models
{
    public class Participation
    {
        [Key]
        public int ParticipationId {get;set;}
        public int UserId {get;set;}
        public int TodoId {get;set;}
        public User User {get;set;}
        public Todo Todo {get;set;}
    }
}