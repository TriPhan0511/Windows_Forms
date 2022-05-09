using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenHuy_Winform3.StudentManage;
using NguyenHuy_Winform3.ADO;
using System.Data.SqlClient;

namespace NguyenHuy_Winform3
{
    public partial class StudentManageForm : Form
    {
        public StudentManageForm()
        {
            InitializeComponent();
            Load_listview();
            listView1.Show();
            Load_combobox();
        }
        void Load_listview()
        {
            DataRowCollection data = DBO.StudentData.Tables[0].Rows;
            foreach (DataRow row in data)
            {
                Student student = new Student(row[1].ToString(), row[2].ToString(), Convert.ToInt64(row[3]), row[4].ToString(), row[5].ToString(), Convert.ToInt32(row[6]));
                ListViewItem item = new ListViewItem();
                item.Text = student.Name;
                item.SubItems.Add(student.Birthday);
                item.SubItems.Add(student.Phone.ToString());
                item.SubItems.Add(student.Gender);
                item.SubItems.Add(student.Email);
                item.SubItems.Add(student.IdBatch.ToString());
                item.SubItems.Add(row[0].ToString());
                listView1.Items.Add(item);

            }
        }
        void reload_listview()
        {
            listView1.Items.Clear();
            Load_listview();
        }

        void Load_combobox()
        {
            DataRowCollection data = DBO.BatchData.Tables[0].Rows;
            List<Batches> listBatches = new List<Batches>();
            foreach (DataRow row in data)
            {
                Batches batches = new Batches(Convert.ToInt32(row[0]), row[1].ToString());
                listBatches.Add(batches);

            }
            //comboBox1.DataSource = listBatches;
            //comboBox1.DisplayMember = "idBatch";
            foreach (Batches batches in listBatches)
            {
                comboBox1.Items.Add(batches);
            }
            comboBox1.DisplayMember = "idBatch";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Batches batches = comboBox1.SelectedItem as Batches;
            if (textBoxName.Text.Equals("") || dateTimePickerBirthday.Value.ToString().Equals("") ||
                textBoxPhone.Text.Equals("") || checkedRadiobutton().Equals("") || textBoxEmail.Text.Equals("")
                                         || comboBox1.Text.ToString().Equals(""))
            {
                labelNotification.Text = "Not enought information";
            }
            else if (!Regex.IsMatch(textBoxPhone.Text, "(0|\\\\+d{2})\\d{9}"))
            {
                labelPhoneValidate.Text = "Input Number";
            }

            else if (!Regex.IsMatch(textBoxEmail.Text, "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$"))
            {
                labelMailValidate.Text = "Format is Wrong!";
            }
            else
            {
                Student student = new Student(textBoxName.Text,
                                       dateTimePickerBirthday.Value.ToString(),
                                       Convert.ToInt64(textBoxPhone.Text),
                                       checkedRadiobutton(),
                                       textBoxEmail.Text,
                                       batches.IdBatch);
                DialogResult rs = MessageBox.Show("Do You Want Insert New Student?", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                    int i = new DAO().ExcuteNonQuery("insert into students(student_name,birthday,phone,gender,email,id_batch) values ('" +
                    textBoxName.Text +
                    "','" +
                    dateTimePickerBirthday.Value.ToString() +
                    "','" +
                    (textBoxPhone.Text) +
                    "','" +
                    checkedRadiobutton() +
                    "','" +
                    textBoxEmail.Text +
                    "','" +
                    batches.IdBatch +
                    "')");
                    labelNotification.Text = "Add " + i + " student into database Success!!";
                }
                reload_listview();
            }



        }
        string checkedRadiobutton()
        {
            string str;
            if ((radioButton1.Checked = false) && (radioButton2.Checked = false)) { str = ""; }
            if (radioButton1.Checked) { str = radioButton1.Text; }
            else { str = radioButton2.Text; }
            return str;
        }
        void setRadioButton(string str)
        {
            if (str.Equals("m")) { radioButton1.Checked = true; }
            if (str.Equals("f")) { radioButton2.Checked = true; }
        }

       

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Batches batches = comboBox1.SelectedValue as Batches;
            ListViewItem listViewItem = listView1.SelectedItems[0];
            if (textBoxName.Text.Equals("") || dateTimePickerBirthday.Value.ToString().Equals("") ||
                textBoxPhone.Text.Equals("") || checkedRadiobutton().Equals("") || textBoxEmail.Text.Equals("")
                                         || comboBox1.Text.Equals(""))
            {
                labelNotification.Text = "Not enought information";
            }
            else if (!Regex.IsMatch(textBoxPhone.Text, "(0|\\\\+d{2})\\d{9}"))
            {
                labelPhoneValidate.Text = "Input Number";
            }

            else if (!Regex.IsMatch(textBoxEmail.Text, "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$"))
            {
                labelMailValidate.Text = "Format is Wrong!";
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to edit this student?", "Edit Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int i = new DAO().ExcuteNonQuery("update students set student_name='" +
                         textBoxName.Text +
                        "',birthday='" +
                        dateTimePickerBirthday.Value.ToString() +
                        "',phone='" +
                        (textBoxPhone.Text) +
                        "',gender='" +
                        checkedRadiobutton() +
                        "',email='" +
                        textBoxEmail.Text +
                        "',id_batch='" +
                        comboBox1.Text +
                        "' where id_student='" +
                        listViewItem.SubItems[6].Text +
                        "'");
                    if (i > 0)
                        labelNotification.Text = "Update " + i + " student into database Success!!";
                    reload_listview();

                }
            }


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            buttonDelete.Visible = false;
            buttonEdit.Visible = true;
            ListViewItem listViewItem = listView1.SelectedItems[0];
            textBoxName.Text = listViewItem.SubItems[0].Text;
            dateTimePickerBirthday.Value = Convert.ToDateTime(listViewItem.SubItems[1].Text);
            textBoxPhone.Text = listViewItem.SubItems[2].Text;
            setRadioButton(listViewItem.SubItems[3].Text);
            textBoxEmail.Text = listViewItem.SubItems[4].Text;
            comboBox1.Text = listViewItem.SubItems[5].Text;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = true;

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = listView1.SelectedItems[0];
            DialogResult result = MessageBox.Show("Do you want to Delete this student?", "Edit Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int i = new DAO().ExcuteNonQuery("delete students where id_student='" +
                     listViewItem.SubItems[6].Text +
                    "'");
                if (i > 0)
                    labelNotification.Text = "Delete " + i + " student into database Success!!";
                reload_listview();
            }
        }

    }
}