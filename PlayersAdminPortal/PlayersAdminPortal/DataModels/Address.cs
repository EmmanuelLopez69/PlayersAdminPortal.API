using System;
namespace PlayersAdminPortal.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string  PhysicalAddress { get; set; }
        public string  PostalAddress { get; set; }

        //Navigation Properties
        public Guid PlayerId { get; set; }
    }
}