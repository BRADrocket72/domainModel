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
        public Array<Guid> studentIds;
        public Array<Student> students;
        public Array<Guid> assignmentIds;
        public virtual Array<Assignment> assignments;


        public void addAssignment(Assignment assignment){
            assignments.add(assignment);
        }
    }
}