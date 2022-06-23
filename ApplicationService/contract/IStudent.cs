using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.contract
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetSingle(int id);
        String AddRecord(Student record);
        String UpdateRecord(Student record);
        String DeleteRecord(int id);

    }
}
