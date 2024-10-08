using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using JetBrains.Annotations;

using Volo.Abp;

namespace Sabeco_Factsheet.TbLogSendEmails
{
    public class TbLogSendEmail : TbLogSendEmailBase
    {
        //<suite-custom-code-autogenerated>
        public TbLogSendEmail()
        {

        }

        public TbLogSendEmail(DateTime timeSend, bool isSuccess, string? userSend = null, string? typeEmail = null, string? failedReason = null)
            : base(timeSend, isSuccess, userSend, typeEmail, failedReason)
        {
        }
        //</suite-custom-code-autogenerated>

        //Write your custom code...
    }
}