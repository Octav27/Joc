
namespace Joc
{
    partial class FormClasament
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
            this.listJucatori = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScorMaxim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listJucatori
            // 
            this.listJucatori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listJucatori.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listJucatori.FormattingEnabled = true;
            this.listJucatori.ItemHeight = 25;
            this.listJucatori.Items.AddRange(new object[] {
            "Octavian 25",
            "Andrei 9",
            "Vasile 388"});
            this.listJucatori.Location = new System.Drawing.Point(12, 114);
            this.listJucatori.Name = "listJucatori";
            this.listJucatori.Size = new System.Drawing.Size(776, 279);
            this.listJucatori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clasamentul jucătorilor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scorul tău maxim:";
            // 
            // ScorMaxim
            // 
            this.ScorMaxim.AutoSize = true;
            this.ScorMaxim.BackColor = System.Drawing.Color.Transparent;
            this.ScorMaxim.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScorMaxim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScorMaxim.Location = new System.Drawing.Point(332, 407);
            this.ScorMaxim.Name = "ScorMaxim";
            this.ScorMaxim.Size = new System.Drawing.Size(35, 34);
            this.ScorMaxim.TabIndex = 3;
            this.ScorMaxim.Text = "0";
            // 
            // FormClasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScorMaxim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJucatori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormClasament";
            this.Text = "Clasament";
            this.Load += new System.EventHandler(this.FormClasament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJucatori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScorMaxim;
    }
}