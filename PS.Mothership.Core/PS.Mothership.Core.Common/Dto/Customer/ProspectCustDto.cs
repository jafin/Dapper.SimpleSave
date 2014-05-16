﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PS.Mothership.Core.Common.Template.Cust;

namespace PS.Mothership.Core.Common.Dto.Customer
{
    [DataContract]
    public class ProspectCustDto
    {
        [DataMember]
        public Guid ProspectGuid { get; set; }

        [DataMember]
        public FullAddressDto Address { get; set; }

        [DataMember]
        public ICollection<ContactDto> Contacts { get; set; }

        [DataMember]
        public virtual string MainPhoneNumber { get; set; }

        [DataMember]
        public ICollection<ProspectCustDto> SimilarNames { get; set; }

        [DataMember]
        public int TotalCount { get; set; } // gives the total count based on selection criteria

        [DataMember]
        public CustBusinessLegalTypeEnum BusinessLegalTypeKey { get; set; }

        [DataMember]
        public CustAnnualTurnoverEnum AnnualTurnoverKey { get; set; }

        [DataMember]
        public CustNumberEmployeesEnum NumberEmployeesKey { get; set; }

        [DataMember]
        public CustNoContactReasonEnum CallRestrictedReasonKey { get; set; }        
    }
}
