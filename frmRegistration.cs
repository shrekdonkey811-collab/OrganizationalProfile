using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizationalProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();
        }


        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }
        public long StudentNumber(string studNum)
        {
            if (string.IsNullOrWhiteSpace(studNum) || !Regex.IsMatch(studNum, @"^0200\d{6}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new IndexOutOfRangeException("Student number must be in the format 02000XXXXXX.");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new OverflowException("Contact number should be 10 to 11 digits long.");
            }
            return _ContactNo;

        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("Name must contain only letters.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new ArgumentNullException("Age must be a number between 1 and 3 digits long.");
            }
            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                frmConfirmation frm = new frmConfirmation();
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
                frm.ShowDialog();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid input error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Invalid input error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Invalid input error: " + ex.Message);
            }
            finally
            {
                txtStudentNo.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleInitial.Clear();
                cbPrograms.SelectedIndex = -1;
                cbGender.SelectedIndex = -1;
                txtContactNo.Clear();
                txtAge.Clear();
                datePickerBirthday.Value = DateTime.Now;
            }
        }
    }
}
