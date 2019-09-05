using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_SQL_ADO_NET
{
    class DBSQL:DBAccess
    {
        private static string conString;
        private static DBSQL instance;

        private DBSQL(string conString) : base(conString) { }
        
        public static DBSQL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DBSQL(conString);
                }
                return instance;
            }
        }

        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + value + ";Persist Security Info=False;";
            }
        }
        //inserting student into a data base
        public void InsertStudent(Students Item)
        {
            string cmdStr = "INSERT INTO Students (id, studentName, studentCity) VALUES (@id,@studentName,@studentCity)";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                if (Item.Id == -1)
                {
                    command.Parameters.AddWithValue("@id", GetStudentNumber());
                }
                else
                {
                    command.Parameters.AddWithValue("@id", Item.Id);
                }
                command.Parameters.AddWithValue("@studentName", Item.FirstName);
                command.Parameters.AddWithValue("@studentName", Item.CityName);
                base.ExecuteSimpleQuery(command);
            }
        }
        //inserting a new city to data base
        public void InsertCity(City Item)
        {
            string cmdStr = "INSERT INTO City (CityName) VALUES (@CityName)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@CityName", Item.CityName);
                base.ExecuteSimpleQuery(command);
            }
        }
        //inserting a new name to data base
        public void InsertName(Names Item)
        {
            string cmdStr = "INSERT INTO [Names](FirstName) VALUES (@FirstName)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {               
                command.Parameters.AddWithValue("@FirstName", Item.FirstName);
                base.ExecuteSimpleQuery(command);
            }
        }
        //getting number of student in data base
        public int GetStudentNumber()
        {
                int result;
                string cmdStr = "SELECT COUNT(*) FROM [Students]";

                using(OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    result = ExecuteScalarIntQuery(command);
                }
            return result;
        }
        //getting number of names in data base
        public int GetNamesNumber()
        {
            int result;
            string cmdStr = "SELECT COUNT(FirstName) FROM [Names]";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //getting array of cites from data base
        public City[] GetCityData()
        {
            DataSet ds = new DataSet();
            ArrayList city = new ArrayList();
            string cmdStr = "SELECT * FROM City";

            using(OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultiQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach(DataRow tType in dt.Rows)
            {
                City cityName = new City();
                cityName.CityName = tType[0].ToString();

                city.Add(cityName);
            }
            return (City[])city.ToArray(typeof(City));
        }
        //getting array with names from data base
        public Names[] GetNamesData()
        {            
            DataSet ds = new DataSet();
            ArrayList names = new ArrayList();
            string cmdStr = "SELECT FirstName FROM [Names]";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultiQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            int i = 0;
            foreach (DataRow tType in dt.Rows)
            {
                Names name = new Names(i, "");
                name.FirstName = tType[0].ToString();

                names.Add(name);
            }
            return (Names[])names.ToArray(typeof(Names));
        }
        //getting array of students from data base
        public Students[] GetStudentsData()
        {
            DataSet ds = new DataSet();
            ArrayList students = new ArrayList();
            string cmdStr = "SELECT [studentName], studentCity FROM [Students]";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultiQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            int i = 0;
            foreach (DataRow tType in dt.Rows)
            {
                Students student = new Students(i, tType[0].ToString(), tType[1].ToString());
                students.Add(student);
            }
            return (Students[])students.ToArray(typeof(Students));
        }
    }
}
