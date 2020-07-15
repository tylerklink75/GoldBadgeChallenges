using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    //Create Read Update Delete
    public class ClaimsRepo
    {
        private Queue<Claim> _queueofClaims = new Queue<Claim>();
        // be able to see all the claims.
        public Queue<Claim> ShowAllClaims()
        {
            return _queueofClaims;
        }
        // be able to add a claim
        public void addNewClaim(Claim claim)
        {
            _queueofClaims.Enqueue(claim);

        }
        // show next claim in queue without deleting it
        public Claim ShowNextClaim()
        {
            return _queueofClaims.Peek();
        }
        //also want to be able to delete the claim when done with it
        public Queue<Claim> RemoveItem()
        {
            _queueofClaims.Dequeue();
            return _queueofClaims;
        }
    }
}
