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
            var petList = _petService.GetAll();
            dgvPetList.DataSource = new BindingSource { DataSource = petList };
        }

        private void btnPriceSearch_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtMaxPrice.Text);
            int min = Convert.ToInt32(txtMinPrice.Text);
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
        }

        private void btnQuantitySearch_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtMaxQuantity.Text);
            int min = Convert.ToInt32(txtMinQuantity.Text);
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
        }

        public int globalPetId;

        private void dgvPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPetList.Rows)
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
    }
}
