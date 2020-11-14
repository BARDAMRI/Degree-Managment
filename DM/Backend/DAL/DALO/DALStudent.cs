using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    public class DALStudent : DALObj
    {
        private string name;
        private string password;
        private int id;
        public const string StudentNameColumn = "Name";
        public const string StudentPasswordColumn = "Password";

        public const string StudentIdColumn = "ID";

        public DALStudent(string name) : base(new StudentDALController())
        {
            this.name = name;
        }
        public DALStudent(string name,int id , string password) : base(new StudentDALController())
        {

            this.name = name;
            this.password = password;
            this.id = id;
        }
        public string Name
        {
            get { return name; }
            set
            {
                Controller.Update(id, StudentNameColumn, value);
                name = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                Controller.Update(id, StudentPasswordColumn, value);
                password = value;
            }
        }
        public int Id
        {
            get { return this.id; }
            set
            {
                Controller.Update(id, StudentIdColumn, value);
                id = value;
            }
        }
    }
}
