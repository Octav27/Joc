
namespace Joc
{
    partial class FormDateAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonȘterge = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewDate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clasamentul jucătorilor";
            // 
            // buttonȘterge
            // 
            this.buttonȘterge.Location = new System.Drawing.Point(12, 390);
            this.buttonȘterge.Name = "buttonȘterge";
            this.buttonȘterge.Size = new System.Drawing.Size(120, 39);
            this.buttonȘterge.TabIndex = 3;
            this.buttonȘterge.Text = "Șterge datele";
            this.buttonȘterge.UseVisualStyleBackColor = true;
            this.buttonȘterge.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Export în excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewDate
            // 
            this.listViewDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDate.HideSelection = false;
            this.listViewDate.Location = new System.Drawing.Point(12, 102);
            this.listViewDate.Name = "listViewDate";
            this.listViewDate.Size = new System.Drawing.Size(718, 261);
            this.listViewDate.TabIndex = 5;
            this.listViewDate.UseCompatibleStateImageBehavior = false;
            this.listViewDate.View = System.Windows.Forms.View.Details;
         //   this.listViewDate.SelectedIndexChanged += new System.EventHandler(this.listViewDate_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr/o";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 325;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Scor";
            this.columnHeader3.Width = 82;
            // 
            // FormDateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonȘterge);
            this.Controls.Add(this.label1);
            this.Name = "FormDateAdmin";
            this.Text = "Date";
            this.Load += new System.EventHandler(this.FormDateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonȘterge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}