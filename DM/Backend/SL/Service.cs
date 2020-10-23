using DM.Backend.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.SL
{
    public class Service
    {
        private UserService userService;

        public Service()
        {
            userService = new UserService();
            LoadData();
        }

        public Response LoadData()
        {
           return userService.LoadData();
        }
        public Response DeleteData()
        {
            return userService.DeleteData();
        }
        public Response Register(string name, int id, string password)
        {
            return userService.Register(name, id, password);
        }


        public Response<Student> Login(int id, string password)
        {
                return userService.Login(id, password);

        }



        public Response Logout(int id)
        {
                return userService.Logout(id);
        }



        public Response startDegree(int id, int years, string name, int credits)
        {
                return userService.startDegree(id, years, name, credits);
        }



        public Response startDegree(int id, int years, string name, int expectedAvg, int credits)
        {
            return userService.startDegree(id, years, name, expectedAvg, credits);
        }



        public Response addCourse(int id, int sem, Course course)
        {
            return userService.addCourse(id, sem, course);
        }



        public Response addCourse(int id, int sem, string name, int credit)
        {

            return userService.addCourse(id, sem, name, credit);
        }



        public Response addCourse(int id, int year, int sem, string name, int credit)
        {
            return userService.addCourse(id, year, sem, name, credit);
        }



        public Response addCourse(int id, int year, int sem, Course course)
        {
           return userService.addCourse(id, year, sem, course);
          
        }



        public Response addSemester(int id, Semester sem)
        {
               return userService.addSemester(id, sem);
        }



        public Response addSemester(int id, int sem)
        {
              return  userService.addSemester(id, sem);
        }



        public Response<double> getDifference(int id)
        {
                return userService.getDifference(id);
        }



        public Response deleteSemester(int id, int sem)
        {
          return  userService.deleteSemester(id, sem);
        }



        public Response deleteSemester(int id, Semester sem)
        {
            return userService.deleteSemester(id, sem);
        }



        public Response deleteCourse(int id, string name)
        {
           return userService.deleteCourse(id, name);
        }



        public Response deleteCourse(int id, string password, Course cour)
        {
           return userService.deleteCourse(id, password, cour);
        }



        public Response setGrade(int id, string password, string course, int grade)
        {
          return userService.setGrade(id, password, course, grade);
        }



        public Response<double> getAverage(int id)
        {
            return userService.getAverage(id);
        }



        public Response<Semester> getSemester(int id, string password, int sem)
        {
            return userService.getSemester(id, password, sem);
        }



        public Response<Course> getCourse(int id, string password, Course cour)
        {
            return userService.getCourse(id, password, cour);
        }



        public Response<Course> getCourse(int id, string password, string cour)
        {
            return userService.getCourse(id, password, cour);
        }



        public Response setName(int id, string name)
        {
            return userService.setName(id, name);
        }



    }
}
