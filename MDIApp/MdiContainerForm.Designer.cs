namespace MDIApp
{
    partial class MdiContainerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MdiMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            FirstChildFormToolStripMenuItem = new ToolStripMenuItem();
            SecondChildFormToolStripMenuItem = new ToolStripMenuItem();
            ActionsToolStripMenuItem = new ToolStripMenuItem();
            CloseFormsToolStripMenuItem = new ToolStripMenuItem();
            MdiMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MdiMenuStrip
            // 
            MdiMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, ActionsToolStripMenuItem });
            MdiMenuStrip.Location = new Point(0, 0);
            MdiMenuStrip.Name = "MdiMenuStrip";
            MdiMenuStrip.Size = new Size(584, 24);
            MdiMenuStrip.TabIndex = 1;
            MdiMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FirstChildFormToolStripMenuItem, SecondChildFormToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // FirstChildFormToolStripMenuItem
            // 
            FirstChildFormToolStripMenuItem.Name = "FirstChildFormToolStripMenuItem";
            FirstChildFormToolStripMenuItem.Size = new Size(210, 22);
            FirstChildFormToolStripMenuItem.Text = "Первая дочерняя форма";
            FirstChildFormToolStripMenuItem.Click += FirstChildFormToolStripMenuItem_Click;
            // 
            // SecondChildFormToolStripMenuItem
            // 
            SecondChildFormToolStripMenuItem.Name = "SecondChildFormToolStripMenuItem";
            SecondChildFormToolStripMenuItem.Size = new Size(210, 22);
            SecondChildFormToolStripMenuItem.Text = "Вторая дочерняя форма";
            SecondChildFormToolStripMenuItem.Click += SecondChildFormToolStripMenuItem_Click;
            // 
            // ActionsToolStripMenuItem
            // 
            ActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CloseFormsToolStripMenuItem });
            ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            ActionsToolStripMenuItem.Size = new Size(70, 20);
            ActionsToolStripMenuItem.Text = "Действия";
            // 
            // CloseFormsToolStripMenuItem
            // 
            CloseFormsToolStripMenuItem.Name = "CloseFormsToolStripMenuItem";
            CloseFormsToolStripMenuItem.Size = new Size(180, 22);
            CloseFormsToolStripMenuItem.Text = "Закрыть формы";
            CloseFormsToolStripMenuItem.Click += CloseFormsToolStripMenuItem_Click;
            // 
            // MdiContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(MdiMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MdiMenuStrip;
            Name = "MdiContainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mdi";
            MdiMenuStrip.ResumeLayout(false);
            MdiMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MdiMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem FirstChildFormToolStripMenuItem;
        private ToolStripMenuItem SecondChildFormToolStripMenuItem;
        private ToolStripMenuItem ActionsToolStripMenuItem;
        private ToolStripMenuItem CloseFormsToolStripMenuItem;
    }
}