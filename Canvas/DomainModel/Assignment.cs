using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Assignment
    {
        public Guid id;
        public string name;
        public string description;
        public Array<string> acceptedFileTypes;
        
    }
}