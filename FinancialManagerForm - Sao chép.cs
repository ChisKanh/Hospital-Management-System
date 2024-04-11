using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostpitalManagerSystem
{
    public partial class FinancialManagerForm : Form
    {
        public FinancialManagerForm()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelMenuMedicinesAndMedicalSupplies.Visible = false;
            panelMenuFinancialManagement.Visible = false;
            
        }

        private void showMenu(Panel Menu)
        {
            if (Menu.Visible == false)
            {
                hideSubMenu();
                Menu.Visible = true;
            }
            else
                Menu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form Dashboard)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Dashboard;
            Dashboard.TopLevel = false;
            Dashboard.FormBorderStyle = FormBorderStyle.None;
            Dashboard.Dock = DockStyle.Fill;
            panelDashBoard.Controls.Add(Dashboard);
            panelDashBoard.Tag = Dashboard;
            Dashboard.BringToFront();
            Dashboard.Show();
        }

        private void btnMedicineandmedicalsupplies_Click(object sender, EventArgs e)
        {
            showMenu(panelMenuMedicinesAndMedicalSupplies);
        }

        private void btnFinancialmanagement_Click(object sender, EventArgs e)
        {
            showMenu(panelMenuFinancialManagement);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new medicine());
            hideSubMenu();
        }

        private void btnMedicalsupplies_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Medical_supplies());
            hideSubMenu();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Revenue());
            hideSubMenu();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Revenue_and_Costs());
            hideSubMenu();
        }

        private void pictureBoxMedicine_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new medicine());
            hideSubMenu();
        }

        private void pictureBoxRevenue_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Revenue());
            hideSubMenu();
        }
    }

}
