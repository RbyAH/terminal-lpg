using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace TAS.API.Models.Crew
{
    public class CrewDto
    {
        private int crewId;

        private string badgeNumber;

        private string identificationNumber;

        private string name;

        private string role;

        private string placeOfBirth;

        private DateTime? dateOfBirth;

        private DateTime? crewKtpTimestamp;

        private string crewKtpNumber;

        private string crewSimNumber;

        private DateTime? crewSimTimestamp;

        private string crewCompany;

        private string crewAddress;

        private string crewPhoneNumber;

        private string crewMobilePhoneNumber;

        private bool isActive;

        private DateTime? createdTimestamp;

        private SimpleUser createdBy;

        private DateTime? updatedTimestamp;

        private SimpleUser updatedBy;

        [PrimaryKey(PrimaryKeyType.Identity, "Crew_Id")]
        public int CrewId
        {
            get
            {
                return crewId;
            }
            set
            {
                crewId = value;
            }
        }

        [Property("Badge_Number")]
        public string BadgeNumber
        {
            get
            {
                return badgeNumber;
            }
            set
            {
                badgeNumber = value;
            }
        }

        [Property("Identification_Number")]
        public string IdentificationNumber
        {
            get
            {
                return identificationNumber;
            }
            set
            {
                identificationNumber = value;
            }
        }

        [Property("Name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [Property("Role")]
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        [Property("Place_Of_Birth")]
        public string PlaceOfBirth
        {
            get
            {
                return placeOfBirth;
            }
            set
            {
                placeOfBirth = value;
            }
        }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [Property("Date_Of_Birth")]
        public DateTime? DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [Property("Crew_Ktp_Timestamp")]
        public DateTime? CrewKtpTimestamp
        {
            get
            {
                return crewKtpTimestamp;
            }
            set
            {
                crewKtpTimestamp = value;
            }
        }

        [Property("Crew_Ktp_Number")]
        public string CrewKtpNumber
        {
            get
            {
                return crewKtpNumber;
            }
            set
            {
                crewKtpNumber = value;
            }
        }

        [Property("Crew_Sim_Number")]
        public string CrewSimNumber
        {
            get
            {
                return crewSimNumber;
            }
            set
            {
                crewSimNumber = value;
            }
        }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [Property("Crew_Sim_Timestamp")]
        public DateTime? CrewSimTimestamp
        {
            get
            {
                return crewSimTimestamp;
            }
            set
            {
                crewSimTimestamp = value;
            }
        }

        [Property("Crew_Company")]
        public string CrewCompany
        {
            get
            {
                return crewCompany;
            }
            set
            {
                crewCompany = value;
            }
        }

        [Property("Crew_Address")]
        public string CrewAddress
        {
            get
            {
                return crewAddress;
            }
            set
            {
                crewAddress = value;
            }
        }

        [Property("Crew_Phone_Number")]
        public string CrewPhoneNumber
        {
            get
            {
                return crewPhoneNumber;
            }
            set
            {
                crewPhoneNumber = value;
            }
        }

        [Property("Crew_Mobile_Phone_Number")]
        public string CrewMobilePhoneNumber
        {
            get
            {
                return crewMobilePhoneNumber;
            }
            set
            {
                crewMobilePhoneNumber = value;
            }
        }

        [Property("Is_Active")]
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [Property("Created_Timestamp")]
        public DateTime? CreatedTimestamp
        {
            get
            {
                return createdTimestamp;
            }
            set
            {
                createdTimestamp = value;
            }
        }

        [ScriptIgnore]
        [BelongsTo("Created_By")]
        public SimpleUser CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                createdBy = value;
            }
        }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [Property("Updated_Timestamp")]
        public DateTime? UpdatedTimestamp
        {
            get
            {
                return updatedTimestamp;
            }
            set
            {
                updatedTimestamp = value;
            }
        }

        [ScriptIgnore]
        [BelongsTo("Updated_By")]
        public SimpleUser UpdatedBy
        {
            get
            {
                return updatedBy;
            }
            set
            {
                updatedBy = value;
            }
        }

        public string CreatedByName => (createdBy != null) ? createdBy.Username : string.Empty;

        public string UpdatedByName => (updatedBy != null) ? updatedBy.Username : string.Empty;

    }
}