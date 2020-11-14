using DM.Backend.DAL;
using DM.Backend.DAL.DALO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DM.Backend.BL
{
    public class UserController
    {
        private Dictionary<int, Student> users;
        Student logged;
        private StudentDALController stu = new StudentDALController();
        DegreeDALController deg = new DegreeDALController();
        CourseDALController cou = new CourseDALController();
        SemesterDALController seme = new SemesterDALController();
        public UserController()
        {
            this.users = new Dictionary<int, Student>();
            logged = null;
        }
        public Student login(int id, string password)
        {
            if (logged == null)
            {
                if(!users.ContainsKey(id))
                    throw new DException("user don't exists");
                logged = users[id];
                return logged;
            }
            throw new DException("A user is already sighned in");
        }

        internal void Reset()
        {
            logged = null;
            users = new Dictionary<int, Student>();
        }

        public void logout(int id)
        {
            if (logged.Id == id)
            {
                logged = null;
            }
            else
            {
                throw new DException("the student is already sighned out");
            }
        }
        public bool isLogged(int id) => logged.Id == id;

        public void LoadData()
        {
            Dictionary<int, DALStudent> users = stu.LoadUsers();
            foreach (KeyValuePair<int, DALStudent> user in users)
            {
                Student toAdd = new Student(user.Value.Name, user.Key, user.Value.Password);
                this.users.Add(toAdd.Id, toAdd);
            }
        }
        public void DeleteData()
        {
            stu.Destroy();
            logged = null;
            users = new Dictionary<int, Student>();
        }
        public void Register(string name, int id, string password)
        {
            if (isLegalId(id))
            {
                if (isGoodInput(name, id, password))
                {
                    stu.Insert(new DALStudent(name, id, password));
                    users.Add(id, new Student(name, id, password));
                }
                else
                    throw new DException("bad input");
            }
            else
                throw new DException("user already exists");
        }

        public void startDegree(int id, int years, string name, int credits)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                
                deg.Insert(new DALDegree(name,credits,0,0,0,0,0,id,years));
                users[id].startDegree(years, name, credits);
            }
            else
                throw new DException("Student is not logged in");
        }
        public void startDegree(int id, int years, string name, int expectedAvg, int credits)
        {

            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                deg.Insert(new DALDegree(name, credits, 0, 0, 0, 0, 0, id,years));
                users[id].startDegree(years, name, expectedAvg, credits);
            }

            else
                throw new DException("Student is not logged in");
        }
        public void addCourse(int id, int sem, Course course)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                cou.Insert(new DALCourse(course.Name(),course.Credit(), course.Grade(),users[id].Degree.Name,id,setYear(sem),sem));
                users[id].addCourse(sem, course);
            }

            else
                throw new DException("Student is not logged in");
        }
        public void addCourse(int id,  int sem, string name, int credit)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                cou.Insert(new DALCourse(name, credit, -1, users[id].Degree.Name, id, setYear(sem), sem));
                users[id].addCourse(setYear(sem),sem, name, credit);
            }
            else
                throw new DException("Student is not logged in");
          
        }
        public void addCourse(int id,  int year, int sem, string name, int credit)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                cou.Insert(new DALCourse(name, credit, -1, users[id].Degree.Name, id, setYear(sem), sem));
                users[id].addCourse(year,sem, name, credit);
            }
            else
                throw new DException("Student is not logged in");
        }
        public void addCourse(int id, int year, int sem, Course course)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                cou.Insert(new DALCourse(course.Name(), course.Credit(), course.Grade(), users[id].Degree.Name, id, setYear(sem), sem));
                users[id].addCourse(year,sem, course);
            }
            else
                throw new DException("Student is not logged in");
        }
        public void addSemester(int id, Semester sem)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
            {
                seme.Insert(new DALSemester(sem.Number,sem.Credit,sem.Average,setYear(sem.Number), users[id].Degree.Name, id));
                users[id].addSemester(sem);
            }
            else
                throw new DException("Student is not logged in");
        }
        public void addSemester(int id, int sem)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].addSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public double getDifference(int id)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                return users[id].getDifference();

            else
                throw new DException("Student is not logged in");
           
        }
        public void deleteSemester(int id, int sem)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].deleteSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteSemester(int id, Semester sem)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].deleteSemester(sem);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteCourse(int id,  string name)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].deleteCourse(name);

            else
                throw new DException("Student is not logged in");
        }
        public void deleteCourse(int id, string password, Course cour)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].deleteCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public void setGrade(int id, string password, string course, int grade)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                users[id].setGrade(course, grade);

            else
                throw new DException("Student is not logged in");
        }

        public double getAverage(int id)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
               return users[id].getAverage();


            else
                throw new DException("Student is not logged in");
        }
        public Semester getSemester(int id, string password, int sem)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                return users[id].getSemester(sem);

            else
                throw new DException("Student is not logged in");
           
        }
        public Course getCourse(int id, string password, Course cour)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                return users[id].getCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public Course getCourse(int id, string password, string cour)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                return users[id].getCourse(cour);

            else
                throw new DException("Student is not logged in");
        }
        public void setName(int id, string name)
        {
            if (!isLegalId(id))
                throw new DException("illegal id number");
            if (isLogged(id))
                 users[id].setName(name);

            else
                throw new DException("Student is not logged in");
        }
        public bool isLegalId(int id)
        {
            string sid = id.ToString();
            if (sid.Length == 9)
            {
                Char[] chars = sid.ToCharArray();
                int sum = 0;
                for (int i = 0; i < chars.Length; i++)
                {
                    int b = (Convert.ToInt32(chars[i].ToString()));
                    if ((i+1) % 2 != 0)
                        sum += b;
                    else
                    {
                        if ((b * 2) >= 10)
                        {
                            sum += ((b * 2) / 10) + ((b * 2) % 10);
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
        public bool isGoodInput(string name,int id,string pass)
        {
            if (users.ContainsKey(id))
                return false;
            if (!isLegalId(id))
                return false;
            return true;
        }
        public int setYear(int sem)
        {
            if (sem % 2 == 0)
            {
                return sem / 2;
            }
            else
                return (sem + 1) / 2;
        }
    }
}
