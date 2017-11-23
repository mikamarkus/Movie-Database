using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_database
{
    class Actor
    {
        private string actorName { get; set; }
        private int actorId { get; set; }

        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private string postal_code { get; set; }
        private string city { get; set; }
        private string nationality { get; set; }

        public Actor(string actorName, int actorId)
        {
            this.actorName = actorName;
            this.actorId = actorId;
        }

        public Actor()
        {

        }

        public string ActorName
        {
            get { return actorName; }
        }

        public int ActorId
        {
            get { return actorId; }
            set { actorId = value; }
        }

        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Postalcode
        {
            get { return postal_code; }
            set { postal_code = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
    }
}
