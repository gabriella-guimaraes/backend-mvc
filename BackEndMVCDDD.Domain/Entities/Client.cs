using System;

namespace BackEndMVCDDD.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public bool IsActive { get; set; }

        //Regra de Negócio
        public bool SpecialClient(Client client)
        {
            return client.IsActive && DateTime.Now.Year - client.SubscriptionDate.Year >= 5;
        }

    }
}
