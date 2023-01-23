using System;


namespace PlayersAdminPortal.DomainModels
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageURL { get; set; }
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
