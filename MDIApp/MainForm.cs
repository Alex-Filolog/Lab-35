using System;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            OpenChildFormInNonMDI(true);
        }

        private void OpenDialogFormButton_Click(object sender, EventArgs e)
        {
            Form? selectedForm = GetSelectedForm();
            if (selectedForm != null)
            {
                selectedForm.ShowDialog();
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void OpenMdiFormButton_Click(object sender, EventArgs e)
        {
            OpenMdiContainer();
        }

        private void OpenChildFormInNonMDI(bool closeFirstForm)
        {
            Form? selectedForm = GetSelectedForm();

            if (selectedForm != null)
            {
                if (closeFirstForm)
                {
                    var existingForm = IsFormOpen(selectedForm.GetType());
                    if (existingForm != null)
                    {
                        existingForm.Close();
                    }
                }

                var existingOpenForm = IsFormOpen(selectedForm.GetType());
                if (existingOpenForm == null)
                {
                    selectedForm.Show();
                }
                else
                {
                    existingOpenForm.Activate();
                }
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void OpenMdiContainer()
        {
            var mdiContainer = new MdiContainerForm();
            mdiContainer.Show();
        }

        private Form? GetSelectedForm()
        {
            if (FirstChildFormToolStripMenuItem.Checked)
            {
                return new FirstChildForm();
            }
            else if (SecondChildFormToolStripMenuItem.Checked)
            {
                return new SecondChildForm();
            }
            return null;
        }

        private Form? IsFormOpen(Type formType)
        {
            foreach (Form child in Application.OpenForms)
            {
                if (child.GetType() == formType)
                {
                    return child;
                }
            };
            return null;
        }


        private void ShowErrorMessage()
        {
            MessageBox.Show("Пожалуйста, выберите форму для открытия.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}