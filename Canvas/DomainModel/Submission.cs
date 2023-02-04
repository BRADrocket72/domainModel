using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace DomainModel
{
    public class Submission
    {
        public Guid id;
        public File file;
        public Guid submittedById;
        public virtual Student submittedBy;

    }
}