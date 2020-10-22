using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    class CourseDALController : DALController
    {
        private const string CourseTableName = "Course";


        public CourseDALController() : base(CourseTableName)
        {

        }

        public bool Insert(DALCourse course)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(null, connection);
                int res = -1;
                try
                {
                    connection.Open();

                    command.CommandText = $"INSERT INTO {CourseTableName} ({DALCourse.CourseNameColumn} ,{DALCourse.CourseCreditColumn},{DALCourse.CourseGradeColumn},{DALCourse.CourseSemesterColumn},{DALCourse.CourseYearColumn},{DALCourse.CourseDegreeColumn},{DALCourse.CourseStudentIdColumn}) " +
                        $"VALUES (@nameVal,@creditVal,@gradeVal@semesterVal,@yearVal,@degreeVal,@studentIdVal);";


                    SQLiteParameter nameParam = new SQLiteParameter(@"nameVal", course.Name);
                    SQLiteParameter creditParam = new SQLiteParameter(@"creditVal",course.Credit);
                    SQLiteParameter gradeParam = new SQLiteParameter(@"gradeVal", course.Grade);
                    SQLiteParameter semesterParam = new SQLiteParameter(@"semesterVal", course.Semester);
                    SQLiteParameter yearParam = new SQLiteParameter(@"yearVal", course.Year);
                    SQLiteParameter degreeParam = new SQLiteParameter(@"degreeVal", course.Degree);
                    SQLiteParameter studentIdParam = new SQLiteParameter(@"studentIdVal", course.StudentId);
                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(creditParam);
                    command.Parameters.Add(gradeParam);

                    command.Prepare();
                    res = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    if (e.Message != null) { }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();

                }

                return res > 0;

            }
        }
        public bool Update(int studentId, string name, string degree, string columnName, string insertValue)
        {
            int res = -1;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand
                {
                    Connection = connection,
                    CommandText = $"update {CourseTableName} set [{columnName}]=@colNameVal where Name=@nameVal AND Degree=@degreeVal AND Student=@studentIdVal"

                };
                try
                {
                    command.Parameters.Add(new SQLiteParameter(@"colNameVal", insertValue));
                    command.Parameters.Add(new SQLiteParameter(@"nameVal", name));
                    command.Parameters.Add(new SQLiteParameter(@"degreeVal", degree));
                    command.Parameters.Add(new SQLiteParameter(@"studentId", studentId));
                    command.Prepare();
                    res = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    if (e.Message != null) { }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();

                }

            }
            return res > 0;

        }
        public bool Delete(string name, string degree, int studentId)
        {
            int res = -1;

            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand
                {
                    Connection = connection,
                    CommandText = $"delete from {CourseTableName} where Name={name} AND Degree={degree} AND Student={studentId}"
                };
                try
                {
                    connection.Open();
                    res = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    if (e.Message != null) { }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }

            }
            return res > 0;
        }

        public List<DALCourse> LoadCourses()
        {
            List<DALCourse> result = Select().Cast<DALCourse>().ToList();
            return result;
        }

        protected override DALObj ConvertReaderToObject(SQLiteDataReader reader)
        {
            DALCourse ret = new DALCourse(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));

            return ret;

        }
    }
}
