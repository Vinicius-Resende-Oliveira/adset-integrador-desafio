﻿namespace ADSET.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public void Add()
        {
            this.Id = Guid.NewGuid();
            this.IsActive = true;
            this.DateCreated = DateTime.Now;
            this.DateUpdated = DateTime.Now;
        }

        public void Delete()
        {
            this.IsActive = false;
            this.DateUpdated = DateTime.Now;
        }
    }
}
