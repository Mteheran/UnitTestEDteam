using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class User
    {
        public Guid UserId {get;set;} = Guid.NewGuid();

        public string Name {get;set;}

        public string LastName {get;set;}

        public string Phone {get;set;}

        public DateTime DateCreated {get;set;} = DateTime.Now;

        public bool Active {get;set;}  = true;
    }
}