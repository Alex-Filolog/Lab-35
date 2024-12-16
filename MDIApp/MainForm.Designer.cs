namespace MDIApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenFormButton = new Button();
            OpenDialogFormButton = new Button();
            MainMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            FirstChildFormToolStripMenuItem = new ToolStripMenuItem();
            SecondChildFormToolStripMenuItem = new ToolStripMenuItem();
            OpenMdiFormButton = new Button();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFormButton
            // 
            OpenFormButton.Location = new Point(12, 37);
            OpenFormButton.Name = "OpenFormButton";
            OpenFormButton.Size = new Size(278, 23);
            OpenFormButton.TabIndex = 1;
            OpenFormButton.Text = "Открыть форму";
            OpenFormButton.UseVisualStyleBackColor = true;
            OpenFormButton.Click += OpenFormButton_Click;
            // 
            // OpenDialogFormButton
            // 
            OpenDialogFormButton.Location = new Point(12, 66);
            OpenDialogFormButton.Name = "OpenDialogFormButton";
            OpenDialogFormButton.Size = new Size(278, 23);
            OpenDialogFormButton.TabIndex = 2;
            OpenDialogFormButton.Text = "Открыть форму в диалоговом режиме";
            OpenDialogFormButton.UseVisualStyleBackColor = true;
            OpenDialogFormButton.Click += OpenDialogFormButton_Click;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(308, 24);
            MainMenuStrip.TabIndex = 3;
            MainMenuStrip.Text = "menuStrip1";
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
            FirstChildFormToolStripMenuItem.CheckOnClick = true;
            FirstChildFormToolStripMenuItem.Name = "FirstChildFormToolStripMenuItem";
            FirstChildFormToolStripMenuItem.Size = new Size(210, 22);
            FirstChildFormToolStripMenuItem.Text = "Первая дочерняя форма";
            // 
            // SecondChildFormToolStripMenuItem
            // 
            SecondChildFormToolStripMenuItem.CheckOnClick = true;
            SecondChildFormToolStripMenuItem.Name = "SecondChildFormToolStripMenuItem";
            SecondChildFormToolStripMenuItem.Size = new Size(210, 22);
            SecondChildFormToolStripMenuItem.Text = "Вторая дочерняя форма";
            // 
            // OpenMdiFormButton
            // 
            OpenMdiFormButton.Location = new Point(12, 95);
            OpenMdiFormButton.Name = "OpenMdiFormButton";
            OpenMdiFormButton.Size = new Size(278, 23);
            OpenMdiFormButton.TabIndex = 5;
            OpenMdiFormButton.Text = "Открыть mdi-форму";
            OpenMdiFormButton.UseVisualStyleBackColor = true;
            OpenMdiFormButton.Click += OpenMdiFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 139);
            Controls.Add(OpenMdiFormButton);
            Controls.Add(OpenDialogFormButton);
            Controls.Add(OpenFormButton);
            Controls.Add(MainMenuStrip);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFormButton;
        private Button OpenDialogFormButton;
        private new MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem FirstChildFormToolStripMenuItem;
        private ToolStripMenuItem SecondChildFormToolStripMenuItem;
        private Button OpenMdiFormButton;
    }
}
