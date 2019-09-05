using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_SQL_ADO_NET
{
    class Names
    {
        private int number;
        private string firstName;

        //constructor
        public Names(int number, string firstName)
        {
            this.number = number;
            this.firstName = firstName;
        }
        //get / set number
        public int Number
        {
            get { return this.number; }
            set
            {
                if(value > 0)
                {
                    this.number = value;
                }
            }
        }
        //get / set name
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }
    }
}
