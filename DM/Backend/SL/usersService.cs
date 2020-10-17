using DM.Backend.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.SL
{
    class usersService
    {
        private UserController userController;

        public usersService()
        {
            userController = new UserController();
        }
        public Response Register(string name, int id, string password)
        {
            try
            {
                userController.Register(name, id, password);

                return new Response();
            }
            catch (DException e)
            {

                return new Response(e.Message);
            }
            catch (Exception e)
            {

                return new Response(e.Message);
            }
        }

        public Response<Student> Login(int id, string password)
        {
            try
            {
                Student output = userController.login(id, password);
                return new Response<Student>(output);
            }
            catch (DException e)
            {
                return new Response<Student>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<Student>(e.Message);
            }
        }
        public Response Logout(int id)
        {
            try
            {
                userController.logout(id);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response startDegree(int id, int years, string name, int credits)
        {
            try
            {
                userController.startDegree(id, years, name, credits);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response startDegree(int id, int years, string name, int expectedAvg, int credits)
        {
            try
            {
                userController.startDegree(id, years, name, expectedAvg, credits);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        private Response addCourse(int id, int sem, Course course)
        {
            try
            {
                userController.addCourse(id, sem, course);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        private Response addCourse(int id, int sem, string name, int credit)
        {
            try
            {
                userController.addCourse( id, sem, name, credit);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }

        }
        private Response addCourse(int id, int year, int sem, string name, int credit)
        {
            try
            {
                userController.addCourse(id, year, sem, name, credit);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        private Response addCourse(int id, int year, int sem, Course course)
        {
            try
            {
                userController.addCourse( id, year, sem, course);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response addSemester(int id, Semester sem)
        {
            try
            {
                userController.addSemester( id, sem);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response addSemester(int id, int sem)
        {
            try
            {
                userController.addSemester( id, sem);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response<double> getDifference(int id)
        {
            try
            {
                double ans=userController.getDifference(id);
                return new Response <double>(ans);
            }
            catch (DException e)
            {
                return new Response<double>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<double>(e.Message);
            }

        }
        public Response deleteSemester(int id, int sem)
        {
            try
            {
                userController.deleteSemester( id, sem);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response deleteSemester(int id, Semester sem)
        {
            try
            {
                userController.deleteSemester( id, sem);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response deleteCourse(int id, string name)
        {
            try
            {
                userController.deleteCourse( id, name);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response deleteCourse(int id, string password, Course cour)
        {
            try
            {
                userController.deleteCourse( id, password, cour);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }
        public Response setGrade(int id, string password, string course, int grade)
        {
            try
            {
                userController.setGrade( id, password, course, grade);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }

        public Response<double> getAverage(int id)
        {
            try
            {
                double ans=userController.getAverage(id);
                return new Response<double>(ans);
            }
            catch (DException e)
            {
                return new Response<double>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<double>(e.Message);
            }
        }
        public Response<Semester> getSemester(int id, string password, int sem)
        {
            try
            {
                Semester semes= userController.getSemester( id,  password,  sem);
                return new Response<Semester>(semes);
            }
            catch (DException e)
            {
                return new Response<Semester>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<Semester>(e.Message);
            }

        }
        public Response<Course> getCourse(int id, string password, Course cour)
        {
            try
            {
                Course co=userController.getCourse( id, password, cour);
                return new Response<Course>(co);
            }
            catch (DException e)
            {
                return new Response<Course>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<Course>(e.Message);
            }
        }
        public Response<Course> getCourse(int id, string password, string cour)
        {
            try
            {
                Course co = userController.getCourse(id, password, cour);
                return new Response<Course>(co);
            }
            catch (DException e)
            {
                return new Response<Course>(e.Message);
            }
            catch (Exception e)
            {
                return new Response<Course>(e.Message);
            }
        }
        public Response setName(int id, string name)
        {
            try
            {
                userController.setName( id, name);
                return new Response();
            }
            catch (DException e)
            {
                return new Response(e.Message);
            }
            catch (Exception e)
            {
                return new Response(e.Message);
            }
        }

    }
}
