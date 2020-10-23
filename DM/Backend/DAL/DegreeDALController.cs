using DM.Backend.DAL.DALO;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL
{
    public class DegreeDALController:DALController
    {
        private const string DegreeTableName = "Degree";


        public DegreeDALController() : base(DegreeTableName)
        {

        }

        public bool Insert(DALDegree degree)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(null, connection);
                int res = -1;
                try
                {
                    connection.Open();

                    command.CommandText = $"INSERT INTO {DegreeTableName} ({DALDegree.DegreeNameColumn} ,{DALDegree.DegreeCreditColumn},{DALDegree.DegreeAverageColumn},{DALDegree.DegreeExpectedAverageColumn},{DALDegree.DegreeDonePrecentsColumn},{DALDegree.DegreeDifferenceColumn},{DALDegree.DegreeTotalCreditColumn},{DALDegree.DegreeStudentIdColumn}) " +
                        $"VALUES (@numVal,@creditVal,@averageVal,@expectedAverageVal,@donePrecentVal,@differenceVal,@totalCreditVal,@studentIdVal);";


                    SQLiteParameter nameParam = new SQLiteParameter(@"numVal", degree.Name);
                    SQLiteParameter creditParam = new SQLiteParameter(@"creditVal", degree.Credit);
                    SQLiteParameter averageParam = new SQLiteParameter(@"averageVal", degree.Average);
                    SQLiteParameter expectedverageParam = new SQLiteParameter(@"expectedverageVal", degree.ExpectedAverage);
                    SQLiteParameter donePrecentParam = new SQLiteParameter(@"donePrecent", degree.DonePrecent);
                    SQLiteParameter differenceParam = new SQLiteParameter(@"differenceVal", degree.Difference);
                    SQLiteParameter totalCreditParam = new SQLiteParameter(@"totalCreditVal", degree.TotalCredit);
                    SQLiteParameter studentIdParam = new SQLiteParameter(@"studentIdVal", degree.StudentId);
                    command.Parameters.Add(nameParam);
                    command.Parameters.Add(creditParam);
                    command.Parameters.Add(averageParam);
                    command.Parameters.Add(expectedverageParam);
                    command.Parameters.Add(donePrecentParam);
                    command.Parameters.Add(differenceParam);
                    command.Parameters.Add(totalCreditParam);
                    command.Parameters.Add(studentIdParam);

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
        public bool Update(int studentId, string degree, string columnName, string insertValue)
        {
            int res = -1;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand
                {
                    Connection = connection,
                    CommandText = $"update {DegreeTableName} set [{columnName}]=@colNameVal where Name=@nameVal AND Student=@studentIdVal"

                };
                try
                {
                    command.Parameters.Add(new SQLiteParameter(@"colNameVal", insertValue));
                    command.Parameters.Add(new SQLiteParameter(@"nameVal", degree));
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
        public bool Delete(int number, string degree, int studentId)
        {
            int res = -1;

            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand
                {
                    Connection = connection,
                    CommandText = $"delete from {DegreeTableName} where Name={number} AND Degree={degree} AND Student={studentId}"
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
            DALYear ret = new DALYear(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetString(4), reader.GetInt32(5));
            return ret;
        }
    }
}
