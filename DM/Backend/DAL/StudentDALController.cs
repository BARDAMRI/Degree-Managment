using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DM.Backend.DAL.DALO;

namespace DM.Backend.DAL
{
    public class StudentDALController : DALController
    {
        private const string UserTableName = "Student";
        public StudentDALController() : base(UserTableName)
        {

        }

        public bool Insert(DALStudent user)
        {
            int res = 0;
            using (var connection = new SQLiteConnection(connectionString))
            {

                SQLiteCommand command = new SQLiteCommand(null, connection);
                {
                    
                    try
                    {
                        command.CommandText = $"INSERT INTO {UserTableName} ({DALStudent.StudentNameColumn},{DALStudent.StudentPasswordColumn},{DALStudent.StudentIdColumn})" +
                            $"VALUES (@nameVal,@passwordVal,@idVal)";

                        SQLiteParameter nameParam = new SQLiteParameter(@"nameVal", user.Name);
                        SQLiteParameter passwordParam = new SQLiteParameter(@"passwordVal", user.Password);
                        SQLiteParameter idParam = new SQLiteParameter(@"idVal", user.Id);
                        command.Parameters.Add(nameParam);
                        command.Parameters.Add(passwordParam);
                        command.Parameters.Add(idParam);
                        command.Prepare();
                        connection.Open();

                        res = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        if (e != null)
                            res = -1;
                    }
                    finally
                    {
                        command.Dispose();
                        connection.Close();

                    }

                }
            }

            return res > 0;

        }


        public Dictionary<int, DALStudent> LoadUsers()
        {
            List<DALStudent> result = Select().Cast<DALStudent>().ToList();
            Dictionary<int, DALStudent> output = new Dictionary<int, DALStudent>();
            foreach (DALStudent user in result)
            {
                output.Add(user.Id, user);
            }
            return output;
        }
        protected override DALObj ConvertReaderToObject(SQLiteDataReader reader)
        {
            DALStudent ret = new DALStudent(reader.GetString(0), reader.GetInt32(1), reader.GetString(2));
            return ret;

        }
    }
}
