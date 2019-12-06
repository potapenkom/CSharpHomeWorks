using LessonsNinth.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonsNinth
{
    public partial class FormToDb : Form
    {
        public FormToDb()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var firstName = FirstName.Text;
            var lastName = LastName.Text;
            var birthDate = DateTime.Parse(DataBirth.Text.ToString());


            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            dataContext.GetTable<Director>().InsertOnSubmit(new Director()
            { FirstName = firstName, LastName = lastName, BirthDate = birthDate });
            dataContext.SubmitChanges();
        }
    }
}
