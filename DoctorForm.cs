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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelMenuMedicalRecord.Visible = false;
            panelMenuSchedulesAndClinics.Visible = false;
            panelMenuTestingAndDiagnosis.Visible = false;
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
            panelDASHBOARD.Controls.Add(Dashboard);
            panelDASHBOARD.Tag = Dashboard;
            Dashboard.BringToFront();
            Dashboard.Show();
        }

        private void btnMedicalrecord_Click(object sender, EventArgs e)
        {
            showMenu(panelMenuMedicalRecord);
        }

        private void btnSchedulesandclinics_Click(object sender, EventArgs e)
        {
            showMenu(panelMenuSchedulesAndClinics);
        }

        private void btnTestinganddiagnosis_Click(object sender, EventArgs e)
        {
            showMenu(panelMenuTestingAndDiagnosis);
        }

        private void pictureBoxInfor_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new InforPatient());
            hideSubMenu();
        }

        private void pictureBoxSche_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new schedule_appointment());
            hideSubMenu();
        }

        private void pictureBoxTest_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new test_results_and_diagnosis());
            hideSubMenu();
        }

        private void pictureBoxPlan_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Treatment_Plan());
            hideSubMenu();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new InforPatient());
            hideSubMenu();
        }

        private void btnRehistory_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new History());
            hideSubMenu();
        }

        private void btnTestresult_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new testresults());
            hideSubMenu();
        }

        private void btnTreatmentschedule_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new treatment_schedule());
            hideSubMenu();
        }

        private void btnScheduleappointment_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new schedule_appointment());
            hideSubMenu();
        }

        private void btnClinicandequipment_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new clinicandequipment());
            hideSubMenu();
        }

        private void btnTestresultsanddiagnosis_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new test_results_and_diagnosis());
            hideSubMenu();
        }

        private void btnTreatmentplan_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Treatment_Plan());
            hideSubMenu();
        }
    }
}
