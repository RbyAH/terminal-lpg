using System;

namespace TAS.API.Models.Customer
{
    public class CustomerDto
    {
        public int CustomerId;

        public string SoldToCode;

        public string SoldToName;

        public string SoldToAddress;

        public string SoldToPhone;

        public string SoldToCity;

        public string ShipToCode;

        public string ShipToName;

        public string ShipToAddress;

        public string ShipToPhone;

        public string ShipToCity;

        public string ShipToSpbuCode;

        public string PrimaryContactNumber;

        public string SecondaryContactNumber;

        public string CustomerGroup;

        public string DistanceFromTerminal;

        public string SalesOrganization;

        public string DistributionChannel;
    }
}