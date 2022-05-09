using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenHuy_Winform3.Manage;
using NguyenHuy_Winform3.ADO;
using System.Collections;
using System.Text.RegularExpressions;

namespace NguyenHuy_Winform3
{
    public partial class TeacherForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        public TeacherForm()
        {
            InitializeComponent();
            LoadDatagridView();
           //dataGridViewTeacher.Columns[0].Visible = false;
           // dataGridViewTeacher.Columns[6].Visible = false;
           // dataGridViewTeacher.Columns[7].Visible = false;
            Load_combobox();
           

        }
        string checkedRadiobutton()
        {
            string str;
            if (radioButton1.Checked) { str = radioButton1.Text; }
            else { str = radioButton2.Text; }
            return str;
        }
        public void LoadDatagridView()
        {

            //var teachers = from p in TeacherManage.TeacherList
            //               join c in BatchManage.BatchList
            //               on p.Id_batch equals c.Id_batch
            //               select new
            //               {
            //                   p.Id_teacher,
            //                   p.Teacher_name,
            //                   p.Birthday,
            //                   p.Phone,
            //                   p.Gender,
            //                   p.Email,
            //                   p.Id_user,
            //                   p.Id_batch,
            //                   c.Batch_name
            //               };

            //bindingSource.DataSource = teachers;
            //dataGridViewTeacher.DataSource= bindingSource;
            //bindingSource.DataSource = DBO.TeacherData.Tables[0];
            dataGridViewTeacher.DataSource = DBO.TeacherData.Tables[0];




           // addTearcherBinding();
           

        }
        void addTearcherBinding()
        {
            textBoxName.DataBindings.Add(new Binding("Text", dataGridViewTeacher.DataSource, "Teacher_name"));
            dateTimePickerBirthday.DataBindings.Add(new Binding("value", dataGridViewTeacher.DataSource, "Birthday"));
            textBoxPhone.DataBindings.Add(new Binding("Text", dataGridViewTeacher.DataSource, "Phone"));
            textBoxMail.DataBindings.Add(new Binding("Text", dataGridViewTeacher.DataSource, "Email"));
            comboBoxBatch.DataBindings.Add(new Binding("Text", dataGridViewTeacher.DataSource, "Batch_name"));

        }
        void Load_combobox()
        {
         
          
            foreach (Batch batch in BatchManage.BatchList)
            {
                comboBoxBatch.Items.Add(batch);
            }
            comboBoxBatch.DisplayMember = "Batch_name";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Batch batch = comboBoxBatch.SelectedItem as Batch;
            if (textBoxName.Text.Equals("") || dateTimePickerBirthday.Value.ToString().Equals("") ||
                textBoxPhone.Text.Equals("")  || textBoxMail.Text.Equals("")
                                         || comboBoxBatch.Text.ToString().Equals(""))
            {
                labelNotification.Text = "Not enought information";
            }
            else if (!Regex.IsMatch(textBoxPhone.Text, "(0|\\\\+d{2})\\d{9}"))
            {
                labelValidatePhone.Text = "Input Number";
            }

            else if (!Regex.IsMatch(textBoxMail.Text, "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$"))
            {
                labelValidateMail.Text = "Format is Wrong!";
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want insert this teacher into database?","ADD Teacher",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                  int i=  new DAO().ExcuteNonQuery("insert into teachers(teacher_name ,birthday ,phone ,gender ,email,id_batch) " +
                        "values('" +
                        textBoxName.Text +
                        "', '" +
                        dateTimePickerBirthday.Value.ToString() +
                        "', '" +
                        textBoxPhone.Text +
                        "', '" +
                        checkedRadiobutton() +
                        "', '" +
                        textBoxMail.Text +
                        "', '" +
                        batch.Id_batch.ToString() +
                        "')");
                    labelNotification.Text = "Add " + i + " student into database Success!!";
                }
            }
        }

        
    }
}
