using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_trial_petstore
{
    public partial class LoginForm : Form
    {
        PetService _petService = new PetService();
        PetGroupService _petGroupService = new PetGroupService();
        PetShopMemberService _petShopMemberService = new PetShopMemberService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean result = authUserLogin();
            if (result)
            {
                this.Hide();
                Form management = new ManagementForm();
                management.ShowDialog();
                this.Close();
            }
        }

        private Boolean authUserLogin()
        {
            Boolean result = false;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            int? role = 0;
            var listUser = _petShopMemberService.GetAll();
            foreach (var user in listUser)
            {
                if (email.Equals(user.EmailAddress) && password.Equals(user.MemberPassword))
                {
                    role = user.MemberRole;
                    break;
                }
            }
            if (role == 2)
            {
                result = true;
            }
            else
            {
                txtErrorMsg.Text = "You have no permission to access this function!";
                result = false;
            }
            return result;
        }
    }
}
