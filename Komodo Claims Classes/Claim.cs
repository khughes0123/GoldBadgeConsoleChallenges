using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims_Classes
{
    public enum ClaimType { car, home, theft}
    public class Claim
    {
        public int ClaimId { get; set; }

        public ClaimType ClaimType { get; set; }

        public string Description { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid { get; set; }

        public Claim() { }

        public Claim(int claimid, ClaimType claimtype, string description, decimal claimamount, DateTime dateofincident, DateTime dateofclaim, bool isvalid)
        {
            ClaimId = claimid;
            ClaimType = claimtype;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            IsValid = isvalid;
        }

    }
}
