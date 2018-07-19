namespace Aula5.TunaGreen.WindowsApp
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMassiveCreate = new System.Windows.Forms.Button();
            this.txtSearchKm = new System.Windows.Forms.TextBox();
            this.btnChangeCar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSearchRegistrationDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 53);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMassiveCreate
            // 
            this.btnMassiveCreate.Location = new System.Drawing.Point(133, 12);
            this.btnMassiveCreate.Name = "btnMassiveCreate";
            this.btnMassiveCreate.Size = new System.Drawing.Size(152, 53);
            this.btnMassiveCreate.TabIndex = 1;
            this.btnMassiveCreate.Text = "Creazione Massiva";
            this.btnMassiveCreate.UseVisualStyleBackColor = true;
            this.btnMassiveCreate.Click += new System.EventHandler(this.btnMassiveCreate_Click);
            // 
            // txtSearchKm
            // 
            this.txtSearchKm.Location = new System.Drawing.Point(688, 12);
            this.txtSearchKm.Name = "txtSearchKm";
            this.txtSearchKm.Size = new System.Drawing.Size(100, 22);
            this.txtSearchKm.TabIndex = 2;
            this.txtSearchKm.Text = "5000";
            this.txtSearchKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchKm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKm_KeyDown);
            // 
            // btnChangeCar
            // 
            this.btnChangeCar.Location = new System.Drawing.Point(12, 71);
            this.btnChangeCar.Name = "btnChangeCar";
            this.btnChangeCar.Size = new System.Drawing.Size(115, 85);
            this.btnChangeCar.TabIndex = 3;
            this.btnChangeCar.Text = "Incrementa KM";
            this.btnChangeCar.UseVisualStyleBackColor = true;
            this.btnChangeCar.Click += new System.EventHandler(this.btnChangeCar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(133, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 85);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Cancella";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 162);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 22);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "325";
            // 
            // btnSearchRegistrationDate
            // 
            this.btnSearchRegistrationDate.Location = new System.Drawing.Point(291, 11);
            this.btnSearchRegistrationDate.Name = "btnSearchRegistrationDate";
            this.btnSearchRegistrationDate.Size = new System.Drawing.Size(260, 54);
            this.btnSearchRegistrationDate.TabIndex = 6;
            this.btnSearchRegistrationDate.Text = "Ricerca Immatricolazione";
            this.btnSearchRegistrationDate.UseVisualStyleBackColor = true;
            this.btnSearchRegistrationDate.Click += new System.EventHandler(this.btnSearchRegistrationDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchRegistrationDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChangeCar);
            this.Controls.Add(this.txtSearchKm);
            this.Controls.Add(this.btnMassiveCreate);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMassiveCreate;
        private System.Windows.Forms.TextBox txtSearchKm;
        private System.Windows.Forms.Button btnChangeCar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSearchRegistrationDate;
    }
}

