//Targil 9 ilya khenkin and roman aronov
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8_SQL_ADO_NET
{
    public partial class Form1 : Form
    {
        private DBSQL dataB;

        public Form1()
        {
            InitializeComponent();
            string strPath = Application.StartupPath; //
            Console.WriteLine(strPath);               //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            listBoxNames.Items.Clear();
            comboBoxCites.Items.Clear();
            DBSQL.ConnectionString = Application.StartupPath + "\\DBSample.accdb"; //getting 
            DBSQL db = DBSQL.Instance; // creating object from DBSQL
            City[] citiesList = db.GetCityData();
            for(int i = 0; i < citiesList.Length; i++)
            {
                comboBoxCites.Items.Add(citiesList[i].CityName);
            }
            Names[] namesList = db.GetNamesData();
            for (int i = 0; i < namesList.Length; i++)
            {
                listBoxNames.Items.Add(namesList[i].FirstName);
            }            
        }
        //adding new city
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if(txtBoxCity.TextLength > 0)
            {
                City newCity = new City(txtBoxCity.Text);
                DBSQL.ConnectionString = Application.StartupPath + "\\DBSample.accdb"; //getting 
                DBSQL db = DBSQL.Instance; // creating object from DBSQL
                db.InsertCity(newCity);
                txtBoxCity.Clear();
            }
        }
        //adding new name
        private void btnAddName_Click(object sender, EventArgs e)
        {
            if(txtBoxNames.TextLength > 0)
            {
                DBSQL.ConnectionString = Application.StartupPath + "\\DBSample.accdb"; //getting 
                DBSQL db = DBSQL.Instance; // creating object from DBSQL
                int itemNumber = db.GetNamesNumber();
                Names newName = new Names(itemNumber,txtBoxNames.Text);
                db.InsertName(newName);
                txtBoxNames.Clear();
            }
        }
        //adding a new student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listBoxNames.SelectedIndex >= 0 && comboBoxCites.SelectedIndex >= 0)
            {
                DBSQL.ConnectionString = Application.StartupPath + "\\DBSample.accdb"; //getting 
                DBSQL db = DBSQL.Instance; // creating object from DBSQL
                int stdId = db.GetStudentNumber();
                Students newStudent = new Students(stdId, listBoxNames.SelectedItem.ToString(),comboBoxCites.SelectedItem.ToString());
                db.InsertStudent(newStudent);
            }
        }
        //getting a PDF file with table
        private void btnPdfTable_Click(object sender, EventArgs e)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\DBSample.accdb"; //getting 
            DBSQL db = DBSQL.Instance; // creating object from DBSQL
            MyPDF temp = new MyPDF("Student Table");
            temp.SetTitle("The Student Table");
            temp.SetImage("image.jpg");
            Students[] tmpStud = db.GetStudentsData();
            temp.SetStudentTable(tmpStud);
            temp.CloseReport();
        }
    }
}
