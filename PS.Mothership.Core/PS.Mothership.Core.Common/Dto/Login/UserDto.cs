﻿using System.Net;
using System.Runtime.Serialization;
using PS.Mothership.Core.Common.Template.Usr;

namespace PS.Mothership.Core.Common.Dto.Login
{
    public class UserDto
    {
        // To manage on client side
        private HttpStatusCode _statusCode = HttpStatusCode.OK;
        public HttpStatusCode StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }

        [DataMember]        
        public UsrLoginResultEnum Status { get; set; }

        [DataMember]
        public string Message { get; set; }        

        [DataMember]
        public UserProfileDto UserProfileDto { get; set; }        
    }
}
