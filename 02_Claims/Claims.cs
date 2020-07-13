﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public enum ClaimType { Car=1, Home, Theft }
    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimType TypeofClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                TimeSpan validOpportunity = DateOfClaim - DateOfIncident;
                if(validOpportunity.Days < 30)
                {
                    return true;
                }
                return false;
            }
        }
        public Claims() { }
        public Claims(int claimID, ClaimType typeOfClaim, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            TypeofClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
}