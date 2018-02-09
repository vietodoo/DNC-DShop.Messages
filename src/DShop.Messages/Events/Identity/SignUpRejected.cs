using System;

namespace DShop.Messages.Events.Identity
{
    public class SignUpRejected : IRejectedEvent
    {
        public Guid RequestId { get; }

        public Guid UserId { get; }

        public string Reason { get; }

        public string Code { get; }

        protected SignUpRejected()
        {
        }

        public SignUpRejected(Guid requestId, Guid userId,
            string reason, string code)
        {
            RequestId = requestId;
            UserId = userId;
            Reason = reason;
            Code = code;
        }
    }
}