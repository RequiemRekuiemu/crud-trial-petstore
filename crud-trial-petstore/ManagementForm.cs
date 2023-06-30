using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_trial_petstore
{
    public partial class ManagementForm : Form
    {
        PetService _petService = new PetService();
        PetGroupService _petGroupService = new PetGroupService();
        PetShopMemberService _petShopMemberService = new PetShopMemberService();

        public ManagementForm()
        {
            InitializeComponent();
            initForm();
        }

        private void initForm()
        {
            newStatus = true;
            var petList = _petService.GetAll();
            dgvPetList.DataSource = new BindingSource { DataSource = petList };
            dgvPetList.Columns["PetGroup"].Visible = false;
            dgvPetList.Columns["PetDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtMaxPrice.Text = string.Empty;
            txtMinPrice.Text = string.Empty;
            txtMaxQuantity.Text = string.Empty;
            txtMinQuantity.Text = string.Empty;
            txtPetId.Text = string.Empty;
        }

        private void btnPriceSearch_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(txtMaxPrice.Text);
            double min = Convert.ToDouble(txtMinPrice.Text);
            if (!priceValidation(min, max))
            {
                txtErrorMsg.Text = "Min value cannot exceed max value!";
                return;
            }
            var petList = _petService.GetAll();
            List<Pet> result = new List<Pet>();

            foreach (Pet pet in petList)
            {
                if (pet.PetPrice <= max && pet.PetPrice >= min)
                {
                    result.Add(pet);
                }
            }
            result = result.OrderBy(pet => pet.PetId).ToList();
            dgvPetList.DataSource = new BindingSource { DataSource = result };
            txtErrorMsg.Text = string.Empty;
        }

        private Boolean priceValidation(double min, double max)
        {
            Boolean result = false;
            if (min <= max)
            {
                result = true;
            }
            return result;
        }

        private void btnQuantitySearch_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtMaxQuantity.Text);
            int min = Convert.ToInt32(txtMinQuantity.Text);
            if (!quantityValidation(min, max))
            {
                txtErrorMsg.Text = "Min value cannot exceed max value!";
                return;
            }
            var petList = _petService.GetAll();
            List<Pet> result = new List<Pet>();

            foreach (Pet pet in petList)
            {
                if (pet.Quantity <= max && pet.Quantity >= min)
                {
                    result.Add(pet);
                }
            }
            result = result.OrderBy(pet => pet.PetId).ToList();
            dgvPetList.DataSource = new BindingSource { DataSource = result };
            txtErrorMsg.Text = string.Empty;
        }

        private Boolean quantityValidation(int min, int max)
        {
            Boolean result = false;
            if (min <= max)
            {
                result = true;
            }
            return result;
        }

        public static int globalPetId = 0;
        public static Boolean newStatus = true;

        private void dgvPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPetList.SelectedRows)
            {
                globalPetId = Convert.ToInt32(row.Cells["PetId"].Value.ToString());
                txtPetId.Text = globalPetId.ToString();
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int petId = globalPetId;
            var listPet = _petService.GetAll();
            Pet pet = listPet.FirstOrDefault(x => x.PetId == petId);
            var confirmResult = MessageBox.Show("Are you sure to delete this product? " +
                "This action cannot be undone.",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _petService.Delete(pet);
            }

            initForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            newStatus = false;
            this.Hide();
            Form petDetails = new PetDetailsForm();
            petDetails.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form petDetails = new PetDetailsForm();
            petDetails.ShowDialog();
            this.Close();
        }

        private void txtMaxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtMinQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txtMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMinPrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
