
namespace Joc
{
    partial class FormInregistrare
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
            this.labelJucatorNume = new System.Windows.Forms.Label();
            this.numeJucator = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAdminNume = new System.Windows.Forms.Label();
            this.textBoxAdminNume = new System.Windows.Forms.TextBox();
            this.labelAdminParol = new System.Windows.Forms.Label();
            this.textBoxAdminParola = new System.Windows.Forms.TextBox();
            this.labelErrorAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJucatorNume
            // 
            this.labelJucatorNume.AutoSize = true;
            this.labelJucatorNume.Location = new System.Drawing.Point(22, 42);
            this.labelJucatorNume.Name = "labelJucatorNume";
            this.labelJucatorNume.Size = new System.Drawing.Size(106, 17);
            this.labelJucatorNume.TabIndex = 0;
            this.labelJucatorNume.Text = "Introdu numele:";
            // 
            // numeJucator
            // 
            this.numeJucator.Location = new System.Drawing.Point(134, 42);
            this.numeJucator.Name = "numeJucator";
            this.numeJucator.Size = new System.Drawing.Size(185, 22);
            this.numeJucator.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Înregistrează";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError
            // 
            this.labelError.Location = new System.Drawing.Point(12, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(427, 17);
            this.labelError.TabIndex = 3;
            this.labelError.Click += new System.EventHandler(this.labelError_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Jucător"});
            this.comboBox1.Location = new System.Drawing.Point(325, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAdminNume
            // 
            this.labelAdminNume.AutoSize = true;
            this.labelAdminNume.Location = new System.Drawing.Point(22, 9);
            this.labelAdminNume.Name = "labelAdminNume";
            this.labelAdminNume.Size = new System.Drawing.Size(106, 17);
            this.labelAdminNume.TabIndex = 5;
            this.labelAdminNume.Text = "Introdu numele:";
            this.labelAdminNume.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAdminNume
            // 
            this.textBoxAdminNume.Location = new System.Drawing.Point(134, 9);
            this.textBoxAdminNume.Name = "textBoxAdminNume";
            this.textBoxAdminNume.Size = new System.Drawing.Size(185, 22);
            this.textBoxAdminNume.TabIndex = 6;
            this.textBoxAdminNume.TextChanged += new System.EventHandler(this.textBoxAdminNume_TextChanged);
            // 
            // labelAdminParol
            // 
            this.labelAdminParol.AutoSize = true;
            this.labelAdminParol.Location = new System.Drawing.Point(22, 53);
            this.labelAdminParol.Name = "labelAdminParol";
            this.labelAdminParol.Size = new System.Drawing.Size(100, 17);
            this.labelAdminParol.TabIndex = 7;
            this.labelAdminParol.Text = "Introdu parola:";
            // 
            // textBoxAdminParola
            // 
            this.textBoxAdminParola.Location = new System.Drawing.Point(134, 53);
            this.textBoxAdminParola.Name = "textBoxAdminParola";
            this.textBoxAdminParola.Size = new System.Drawing.Size(185, 22);
            this.textBoxAdminParola.TabIndex = 8;
            this.textBoxAdminParola.UseSystemPasswordChar = true;
            // 
            // labelErrorAdmin
            // 
            this.labelErrorAdmin.AutoSize = true;
            this.labelErrorAdmin.Location = new System.Drawing.Point(254, 95);
            this.labelErrorAdmin.Name = "labelErrorAdmin";
            this.labelErrorAdmin.Size = new System.Drawing.Size(31, 17);
            this.labelErrorAdmin.TabIndex = 9;
            this.labelErrorAdmin.Text = "asd";
            // 
            // FormInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 133);
            this.Controls.Add(this.labelErrorAdmin);
            this.Controls.Add(this.textBoxAdminParola);
            this.Controls.Add(this.labelAdminParol);
            this.Controls.Add(this.textBoxAdminNume);
            this.Controls.Add(this.labelAdminNume);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeJucator);
            this.Controls.Add(this.labelJucatorNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInregistrare";
            this.Text = "Inregistrare jucător";
            this.Load += new System.EventHandler(this.FormInregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJucatorNume;
        private System.Windows.Forms.TextBox numeJucator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelAdminNume;
        private System.Windows.Forms.TextBox textBoxAdminNume;
        private System.Windows.Forms.Label labelAdminParol;
        private System.Windows.Forms.TextBox textBoxAdminParola;
        private System.Windows.Forms.Label labelErrorAdmin;
    }
}