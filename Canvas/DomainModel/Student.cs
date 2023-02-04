using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Student
    {
        public Guid id;
        public string name;
        public string pronouns;
        public string profilePhotoUrl;
        public double GPA;
        public Array<Guid> enrolledClassIds;
        public virtual Array<Class> enrolledClasses;
        
    }
}