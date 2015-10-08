using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RevStack.Pattern;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Entity.Models
{
    public class SampleModel : IEntity<Guid>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}