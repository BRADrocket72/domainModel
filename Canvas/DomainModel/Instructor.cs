using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Instructor
    {
        public Guid id;
        public string name;
        public string profilePhotoUrl;
        public string pronouns;
        public Array<Class> classes;
        

    }
}