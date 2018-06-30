using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.classes
{
    public interface IEmployeeFactory
    {
        IEmployee CreateEmployee(EmployeeType type);
    }
}
