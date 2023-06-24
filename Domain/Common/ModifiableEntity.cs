using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class ModifiableEntity
    {
        protected ModifiableEntity()
        {
            CreatedOn = DateTime.UtcNow;
            ModifierUserId = null;
            ModifiedOn = null;
            IsDeleted = false;
            DeletingUserId = null;
            DeletedOn = null;
        }

        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public Guid CreatorUserId { get; set; }
        public Guid? ModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Guid? DeletingUserId { get; set; }
    }
}
