using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Classes
{
    public class ClaimsRepo
    {
        private readonly Queue<Claim> _directory = new Queue<Claim>();

       
        
        public void AddClaim(Claim claim)
        {
            
            _directory.Enqueue(claim);
            
            
        }

        public Queue<Claim> GetClaims()
        {
            return _directory;
        }

        public Claim PeekAtClaim()
        {
           
             return _directory.Peek();
            
        }

        public Claim ProcessNextClaim()
        {
            return _directory.Dequeue();
        }

    }
}
