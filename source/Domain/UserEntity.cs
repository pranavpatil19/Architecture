using Architecture.CrossCutting;
using DotNetCore.Domain;
using System.Collections.Generic;

namespace Architecture.Domain
{
    public class UserEntity : Entity<long>
    {
        public UserEntity
        (
            long id,
            FullName fullName,
            Email email,
            Auth auth,
            Status status
        )
        : base(id)
        {
            FullName = fullName;
            Email = email;
            Auth = auth;
            Status = status;
        }

        public UserEntity(long id) : base(id) { }

        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        public Auth Auth { get; private set; }

        public Status Status { get; private set; }

        public IReadOnlyCollection<UserLogEntity> UsersLogs { get; private set; }

        public void Add()
        {
            Status = Status.Active;
        }

        public void ChangeEmail(string address)
        {
            Email = new Email(address);
        }

        public void ChangeFullName(string name, string surname)
        {
            FullName = new FullName(name, surname);
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }
    }
}
