using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Class
    {
       public Guid id;
       public string name;
       public string courseNumber;
       public Guid instructorId;
       public virtual Instructor instructor;
       
    }
}