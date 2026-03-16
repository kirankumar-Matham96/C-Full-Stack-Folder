using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dispBtn_Click(object sender, EventArgs e)
        {
            string fName = firstName.Text;
            string lName = lastName.Text;
            string Email = email.Text;
            FisrstNameLabel.Text = fName;
            LastNameLabel.Text = lName;
            EmailLabel.Text = Email;

            firstName.Text = "";
            lastName.Text  = "";
            email.Text = "";
            password.Text = "";

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Num1.Text);
            int num2 = Convert.ToInt32(Num2.Text);
            Result.Text = (num1 + num2).ToString();
        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Num1.Text);
            int num2 = Convert.ToInt32(Num2.Text);
            Result.Text = (num1 - num2).ToString();
        }

        protected void MulBtn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Num1.Text);
            int num2 = Convert.ToInt32(Num2.Text);
            Result.Text = (num1 * num2).ToString();
        }

        protected void Div_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Num1.Text);
            int num2 = Convert.ToInt32(Num2.Text);
            Result.Text = (num1 / num2).ToString();
        }

        string[] skills = { null, null, null, null };

        protected void Java_CheckedChanged(object sender, EventArgs e)
        {
            skills[0] = Java.Text;
        }

        protected void Dotnet_CheckedChanged(object sender, EventArgs e)
        {
            skills[1] = Dotnet.Text;
        }

        protected void Javascript_CheckedChanged(object sender, EventArgs e)
        {
            skills[2] = Javascript.Text;
        }

        protected void Python_CheckedChanged(object sender, EventArgs e)
        {
            skills[3] = Python.Text;
        }

        protected void SkillsBtn_Click(object sender, EventArgs e)
        {
            SkillsLabel.Text = skills[0];
        }
    }
}