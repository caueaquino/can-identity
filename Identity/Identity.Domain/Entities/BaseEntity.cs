using System;

namespace Identity.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset LastChangeDate { get; set; }
    
        public BaseEntity()
        {
            this.CreationDate = new DateTimeOffset();
            this.LastChangeDate = new DateTimeOffset();
        }

    }
}
