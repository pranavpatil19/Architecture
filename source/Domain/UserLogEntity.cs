using Architecture.CrossCutting;
using DotNetCore.Domain;
using System;

namespace Architecture.Domain
{
    public class UserLogEntity : Entity<long>
    {
        public UserLogEntity(long userId, LogType logType) : base(default)
        {
            UserId = userId;
            LogType = logType;
            DateTime = DateTime.UtcNow;
        }

        public long UserId { get; private set; }

        public LogType LogType { get; private set; }

        public DateTime DateTime { get; private set; }

        public UserEntity User { get; private set; }
    }
}
