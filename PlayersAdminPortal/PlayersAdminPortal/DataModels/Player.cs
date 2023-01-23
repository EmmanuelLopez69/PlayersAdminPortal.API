using System;

namespace PlayersAdminPortal.DataModels
{
    public class Player
    {
        
        public  Guid Id { get; set; }
        public  string FirstName{ get; set; }
        public  string LastName { get; set; }
        public  DateTime DateofBirth { get; set; }
        public  string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageURL { get; set; }
        public Guid GenderId { get; set; }
        
        //Navigation Properties

        public Gender Gender { get; set; }
        public Address Address { get; set; }


    }
}
