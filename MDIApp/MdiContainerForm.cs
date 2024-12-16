using System;
using System.Linq;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class MdiContainerForm : Form
    {
        public MdiContainerForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FirstChildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FirstChildForm));
        }

        private void SecondChildFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(SecondChildForm));
        }

        private void CloseFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
        }

        private void OpenChildForm(Type formType)
        {
            try
            {
                var existingForm = IsFormOpen(formType);
                if (existingForm != null)
                {
                    existingForm.Activate();
                }
                else
                {
                    Form? childForm = Activator.CreateInstance(formType) as Form;
                    if (childForm != null)
                    {
                        childForm.MdiParent = this;
                        childForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось создать экземпляр формы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Form? IsFormOpen(Type formType)
        {
            try
            {
                return this.MdiChildren.FirstOrDefault(child => child.GetType() == formType);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при проверке открытых форм: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CloseAllChildForms()
        {
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
        }
    }
}