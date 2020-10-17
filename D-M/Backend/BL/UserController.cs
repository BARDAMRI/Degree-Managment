using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.Backend.BL
{
    class UserController
    {
        private Dictionary<int, Student> users;
        Student logged;

        public UserController()
        {
            this.users = new Dictionary<int, Student>();
            logged = null;
        }
        public Student logIn(int id, string password)
        {
            if (logged == null)
            {
                logged = users[id];
                return logged;
            }
            throw new DException("A user is already sighned in");
        }
        public void Logout(int id, string password)
        {
            if (logged.Id() == id)
            {
                logged = null;
            }
            else
            {
                throw new DException("the student is already sighned out");
            }
        }
        public bool isLogged(int id) => logged.Id() == id;
        public void Register(string name, int id, string password)
        {
            if (isLegalId(id))
            {
                users.Add(id, new Student(name, id, password));
            }
        }

        public void startDegree(int id, int years, string name, int credits)
        {
            if (isLogged(id))
                users[id].startDegree(years, name,  credits);

            else
                throw new DException("Student is not logged in");
        }
        public void startDegree(int id, int years, string name, int expectedAvg, int credits)
        {
            if (isLogged(id))
                users[id].startDegree(years, name, expectedAvg, credits);

            else
                throw new DException("Student is not logged in");
        }
        private void addCourse(int id, int sem, Course course)
        {
            if (isLogged(id))
                users[id].addCourse(sem, course);

            else
                throw new DException("Student is not logged in");
        }
        private void addCourse(int id,  int sem, string name, int credit)
        {
            if (isLogged(id))
                users[id].addCourse(sem, name, credit);

            else
                throw new DException("Student is not logged in");
          
        }
        private void addCourse(int id,  int year, int sem, string name, int credit)
        {
            if (isLogged(id))
                users[id].addCourse(year, sem, name, credit);

            else
                throw new DException("Student is not logged in");
        }
        private void addCourse(int id, int year, int sem, Course course)
        {
            if (isLogged(id))
                users[id].addCourse(year, sem, course);

            else
                throw new DException("Student is not logged in");
        }
        public void addSemester(int id, Semester sem)
        {
            if (isLogged(id))
                users[id].addSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public void addSemester(int id, int sem)
        {
            if (isLogged(id))
                users[id].addSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public double getDifference(int id)
        {
            if (isLogged(id))
                return users[id].getDifference();

            else
                throw new DException("Student is not logged in");
           
        }
        public void deleteSemester(int id, int sem)
        {
            if (isLogged(id))
                users[id].deleteSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteSemester(int id, Semester sem)
        {
            if (isLogged(id))
                users[id].deleteSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteCourse(int id,  string name)
        {
            if (isLogged(id))
                users[id].deleteCourse(name);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteCourse(int id, string password, Course cour)
        {
            if (isLogged(id))
                users[id].deleteCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public void setGrade(int id, string password, string course, int grade)
        {
            if (isLogged(id))
                users[id].setGrade(course, grade);

            else
                throw new DException("Student is not logged in");
        }

        public double getAverage(int id)
        {
            if (isLogged(id))
               return users[id].getAverage();


            else
                throw new DException("Student is not logged in");
        }
        public Semester getSemester(int id, string password, int sem)
        {
            if (isLogged(id))
                return users[id].getSemester(sem);

            else
                throw new DException("Student is not logged in");
           
        }
        public Course getCourse(int id, string password, Course cour)
        {
            if (isLogged(id))
                return users[id].getCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public Course getCourse(int id, string password, string cour)
        {
            if (isLogged(id))
                return users[id].getCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public void setName(int id, string name)
        {
            if (isLogged(id))
                 users[id].setName(name);

            else
                throw new DException("Student is not logged in");
        }
        private bool isLegalId(int id)
        {
            string sid = id.ToString();
            if (sid.Length == 9)
            {
                string withoutfirst = sid.Substring(1);
                int sum = 0;
                for (int i = 1; i <= 8; i++)
                {
                    int b = (Convert.ToInt32(withoutfirst.ElementAt(i)));
                    if (i % 2 != 0)
                        sum += b;
                    else
                    {
                        if ((b * 2) >= 10)
                        {
                            sum += ((b * 2) % 10) + ((b * 2) % 10);
                        }
                        else
                            sum += b * 2;
                    }
                }
                if (sum + Convert.ToInt32(sid.ElementAt(0)) % 10 == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                int leak = 8 - sid.Length;
                for (int i = 1; i <= leak; i++)
                {
                    sid = "0" + sid;
                }
                int sum = 0;
                for (int i = 1; i <= 8; i++)
                {
                    int b = (Convert.ToInt32(sid.ElementAt(i)));
                    if (i % 2 != 0)
                        sum += b;
                    else
                    {
                        if ((b * 2) >= 10)
                        {
                            sum += ((b * 2) % 10) + ((b * 2) % 10);
                        }
                        else
                            sum += b * 2;
                    }
                }
                if (sum % 10 == 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
