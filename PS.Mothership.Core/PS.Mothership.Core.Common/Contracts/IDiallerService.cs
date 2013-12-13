﻿using PS.Mothership.Core.Common.Rellaid.Dto;
using PS.Mothership.Core.Common.Template.Dial;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace PS.Mothership.Core.Common.Contracts
{
    [ServiceContract(Name = "DiallerService")]
    public interface IDiallerService
    {
        [OperationContract]
        ValidUserInfoDto ValidateUser(Guid mothershipSessionGuid);

        [OperationContract]
        void LogDiallerSessionSubscribe(Guid mothershipSessionGuid, DateTime startDateTime);

        [OperationContract]
        void LogDiallerSessionUnsubscribe(Guid mothershipSessionGuid, DateTime endDateTime, bool wasForcedLogout, LogoutReasonEnum logoutReason);

        [OperationContract]
        List<InboundQueueDetailsDto> GetInboundQueueDetails();

        [OperationContract]
        List<MissingCallRecordingsDto> GetMissingCallRecordings(DateTime dateStart, DateTime dateEnd);

        [OperationContract]
        void UpdateRecorderCallIdForCallGuid(Guid callGuid, long recorderCallId, Guid mothershipSessionGuid);

        [OperationContract]
        Dictionary<long, long> TryToFindDiallerDepartmentsByUserGuid(Guid userGuid);

        [OperationContract]
        List<CallStatsDto> GetCallTotalsForToday();

        [OperationContract]
        void InsertCallRecordingEvent(CallRecordingEventDto callRecordingEvent);

        [OperationContract]
        void LogFinalisedCall(DiallerCallDto diallerCall);

        [OperationContract]
        Guid LogDiallerModeChange(Guid mothershipSessionGuid, DateTime diallerStartTime, ModeEnum diallerMode);
    }
}
