using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Travelland.Domain.DomainModels
{
    public class BaseEntity
    {
        [Key]
        public Guid id { get; set; }
    }
}
