using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_SQL_ADO_NET
{
    class Students
    {
        private int id;
        private string studentName;
        private string studentCity;
        
        //constructor
        public Students(int id, string studentName, string studentCity)
        {
            this.id = id;
            this.studentCity = studentCity;
            this.studentName = studentName;
        }
        //get / set
        public int Id
        {
            get { return this.id; }
            set
            {
                if (value > 0) this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.studentName; }
            set
            {
                this.studentName = value;
            }
        }
        public string CityName
        {
            get { return this.studentCity; }
            set
            {
                this.studentCity = value;
            }
        }
    }
}
