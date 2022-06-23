using ApplicationService.contract;
using DomainLayer.Models;
using DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.implement
{
    public class StudentService : IStudent
    {
        private readonly RepoContext repoContext1;
        public StudentService(RepoContext repoContext)
        {
            this.repoContext1 = repoContext;

        }
        public string AddRecord(Student record)
        {
           this.repoContext1.Students.Add(record);
            this.repoContext1.SaveChanges();
            return "success";


        }

        public string DeleteRecord(int id)
        {
            try
            {
                var student = this.repoContext1.Students.Find(id);
                this.repoContext1.Students.Remove(student);
                this.repoContext1.SaveChanges();
                return "successfully deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        //sakiyo
        public List<Student> GetAll()
        {
            return repoContext1.Students.ToList();
        }

        public Student GetSingle(int id)
        {
            //first way
           // return repoContext1.Students.Where(x=>x.StudentId == id).FirstOrDefault();
           return this.repoContext1.Students.Find(id);
        }

        public string UpdateRecord(Student record)
        {
            try
            {
                var student = repoContext1.Students.Find(record.StudentId);
                if(student != null)
                {
                    student.Name = record.Name;
                    return "update successfully";
                }
                else
                {
                    return "record not found";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            
            }
        }
    }
}
