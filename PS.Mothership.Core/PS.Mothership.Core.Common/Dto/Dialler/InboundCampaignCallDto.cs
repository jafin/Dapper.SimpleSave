﻿using PS.Mothership.Core.Common.Template.Dial;
using System;
using System.Runtime.Serialization;

namespace PS.Mothership.Core.Common.Dto.Dialler
{
    [DataContract]
    public class InboundCampaignCallDto
    {       
        [DataMember]
        public Guid InboundCampaignCallGuid { get; set; }
        [DataMember]
        public Guid CampaignGuid { get; set; }
        [DataMember]
        public string Keyword { get; set; }
        [DataMember]
        public string ReferrerUrl { get; set; }
        [DataMember]
        public DialInboundCampaignCallResolutionEnum InboundCampaignCallResolutionKey { get; set; }
    }
}