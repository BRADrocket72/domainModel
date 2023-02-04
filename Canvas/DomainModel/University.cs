using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class University
    {
        public Guid id;
        public string name;
        public Array<Guid> instructorIds;
        public virtual Array<Instructor> instructors;
        public Array<Guid> studentIds;
        public Array<Student> students;
    }
}