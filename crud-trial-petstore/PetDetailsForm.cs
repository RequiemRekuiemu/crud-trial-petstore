using Repository.Models;
using Repository.Services;
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

namespace crud_trial_petstore
{
    public partial class PetDetailsForm : Form
    {
        PetService _petService = new PetService();
        PetGroupService _petGroupService = new PetGroupService();
        PetShopMemberService _petShopMemberService = new PetShopMemberService();

        public PetDetailsForm()
        {
            InitializeComponent();
            initForm();
        }

        public void initForm()
        {
            cbbGroupInitializer();
            if (ManagementForm.newStatus)
            {
                txtId.Text = autoIdGenerator().ToString();
                dtpImportDateInitializer();
                btnAdd.Visible = true;
            }
            else
            {
                var petList = _petService.GetAll();
                txtId.Text = ManagementForm.globalPetId.ToString();
                Pet pet = petList.FirstOrDefault(x => x.PetId == ManagementForm.globalPetId);
                txtName.Text = pet.PetName;
                dtpImportDate.Value = (DateTime)pet.ImportDate;
                txtDescription.Text = pet.PetDescription;
                txtQuantity.Text = pet.Quantity.ToString();
                txtPrice.Text = pet.PetPrice.ToString();
                var grouplist = _petGroupService.GetAll();
                PetGroup group = grouplist.FirstOrDefault(x => x.PetGroupId == pet.PetGroupId);
                cbbGroup.Text = group.PetGroupName;
                btnUpdate.Visible = true;
            }
        }

        public int autoIdGenerator()
        {
            List<Pet> list = _petService.GetAll();
            int id = 0;
            int result = 1;
            if (!list.Any())
            {
                return id;
            }
            else
            {
                foreach (Pet pet in list)
                {
                    int idNumber = pet.PetId;
                    if (result == pet.PetId)
                    {
                        result = idNumber + 1;
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        private void cbbGroupInitializer()
        {
            List<String> result = new List<string>();
            var groupList = _petGroupService.GetAll();
            foreach (var group in groupList)
            {
                result.Add(group.PetGroupName.ToString());
            }
            foreach (String group in result)
            {
                cbbGroup.Items.Add(group);
            }
        }

        private void dtpImportDateInitializer()
        {
            dtpImportDate.Value = DateTime.Now;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            // Calculate the number of lines required based on the text and font size
            int numLines = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;

            // Calculate the height of a single line of text
            int lineHeight = textBox.Font.Height;

            // Set the new height of the textbox based on the number of lines
            textBox.Height = lineHeight * numLines;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();

            int id = Convert.ToInt32(txtId.Text);

            String name = txtName.Text;
            if (!checkName(name))
            {
                txtErrorMsg.Text = "Name is not valid!";
                return;
            }

            DateTime importDate = DateTime.Now;

            String description = txtDescription.Text;
            if (!checkDescription(description))
            {
                txtErrorMsg.Text = "Description is not valid!";
                return;
            }

            int quantity = Convert.ToInt32(txtQuantity.Text);
            if (!checkQuantity(quantity))
            {
                txtErrorMsg.Text = "Quantity must be an integer higher than 0!";
                return;
            }

            double price = Convert.ToDouble(txtPrice.Text);
            if (!checkPrice(price))
            {
                txtErrorMsg.Text = "Price must be a double higher than 0!";
                return;
            }

            String groupStr = cbbGroup.Text;
            if (!checkGroup(groupStr))
            {
                txtErrorMsg.Text = "Group must be chosen!";
                return;
            }
            var grouplist = _petGroupService.GetAll();
            PetGroup group = grouplist.FirstOrDefault(x => x.PetGroupName == groupStr);
            String groupId = group.PetGroupId;

            try
            {
                pet.PetId = id;
                pet.PetName = name;
                pet.ImportDate = importDate;
                pet.PetDescription = description;
                pet.PetPrice = price;
                pet.Quantity = quantity;
                pet.PetGroupId = groupId;
                _petService.Create(pet);

                this.Hide();
                Form management = new ManagementForm();
                management.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private Boolean checkName(String name)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(name))
            {
                result = true;
            }

            return result;
        }

        private Boolean checkPrice(double price)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(price.ToString()))
            {
                result = true;
            }
            return result;
        }

        private Boolean checkQuantity(int quantity)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(quantity.ToString()))
            {
                result = true;
            }
            return result;
        }

        private Boolean checkDescription(String description)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(description))
            {
                result = true;
            }
            return result;
        }

        private Boolean checkGroup(String group)
        {
            Boolean result = false;
            if (!String.IsNullOrEmpty(group))
            {
                result = true;
            }
            return result;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string text = textbox.Text;
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            textbox.Text = string.Join(" ", words);
            textbox.SelectionStart = textbox.Text.Length;
            textbox.SelectionLength = 0;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, a decimal separator (dot), or a control key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal separator
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            var petList = _petService.GetAll();
            Pet pet = petList.FirstOrDefault(x => x.PetId == id);           

            String name = txtName.Text;
            if (!checkName(name))
            {
                txtErrorMsg.Text = "Name is not valid!";
                return;
            }

            DateTime importDate = DateTime.Now;

            String description = txtDescription.Text;
            if (!checkDescription(description))
            {
                txtErrorMsg.Text = "Description is not valid!";
                return;
            }

            int quantity = Convert.ToInt32(txtQuantity.Text);
            if (!checkQuantity(quantity))
            {
                txtErrorMsg.Text = "Quantity must be an integer higher than 0!";
                return;
            }

            double price = Convert.ToDouble(txtPrice.Text);
            if (!checkPrice(price))
            {
                txtErrorMsg.Text = "Price must be a double higher than 0!";
                return;
            }

            String groupStr = cbbGroup.Text;
            if (!checkGroup(groupStr))
            {
                txtErrorMsg.Text = "Group must be chosen!";
                return;
            }
            var grouplist = _petGroupService.GetAll();
            PetGroup group = grouplist.FirstOrDefault(x => x.PetGroupName == groupStr);
            String groupId = group.PetGroupId;

            try
            {
                pet.PetName = name;
                pet.ImportDate = importDate;
                pet.PetDescription = description;
                pet.PetPrice = price;
                pet.Quantity = quantity;
                pet.PetGroupId = groupId;
                _petService.Update(pet);

                this.Hide();
                Form management = new ManagementForm();
                management.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form management = new ManagementForm();
            management.ShowDialog();
            this.Close();
        }
    }
}
