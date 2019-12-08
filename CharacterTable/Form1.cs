using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace CharacterTable
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "First Name"; 
            column1.Width = 100; 
            column1.ReadOnly = true; 
            column1.Name = "firstName"; 
            column1.Frozen = true; 
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Last Name";
            column2.Name = "lastName";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Gender";
            column3.Name = "gender";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Age";
            column4.Name = "age";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);

            dataGridView1.AllowUserToAddRows = false;

            var characters = GetCharasterFromFile.CharasterSerialize();
            foreach(var character in characters)
            {
                dataGridView1.Rows.Add();
                dataGridView1["firstName", dataGridView1.Rows.Count - 1].Value =character.FirstName;
                dataGridView1["lastName", dataGridView1.Rows.Count - 1].Value = character.LastName;
                dataGridView1["gender", dataGridView1.Rows.Count - 1].Value = character.Gender;
                dataGridView1["age", dataGridView1.Rows.Count - 1].Value = character.Age;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var characters = CharactersService.GetCharacters();
            var name = firstName.Text;
            var lastName = lasrName.Text;
            var Gender = bool.Parse(gender.Text);
            var Age = int.Parse(age.Text);
            var character = new Character() { FirstName = name, LastName = lastName, Gender = Gender, Age = Age };
                dataGridView1.Rows.Add();
                dataGridView1["firstName", dataGridView1.Rows.Count - 1].Value = character.FirstName;
                dataGridView1["lastName", dataGridView1.Rows.Count - 1].Value = character.LastName;
                dataGridView1["gender", dataGridView1.Rows.Count - 1].Value = character.Gender;
                dataGridView1["age", dataGridView1.Rows.Count - 1].Value = character.Age;
            characters.Add(character);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var characters = CharactersService.GetCharacters();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Characters";
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.InitialDirectory = @"C:\Projects";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFile.OpenFile();
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, characters);
                stream.Close();
            }
        }
    }
}
