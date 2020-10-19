using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MillionAndUp.Admin.Domain
{
    public class Editorial
    {
        protected Editorial()
        {

        }

        public Editorial(string name, string campus, int? id = null)
        {
            Name = name;
            Campus = campus;
            Id = id ?? 0;
        }

        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Campus { get; private set; }
    }
}
