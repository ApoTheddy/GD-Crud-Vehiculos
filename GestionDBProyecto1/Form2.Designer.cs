namespace GestionDBProyecto1
{
    partial class EditVehicleForm
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(144, 165);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(142, 23);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "GUARDAR CAMBIOS";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "ESTADO";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "active",
            "deactive"});
            this.cbxStatus.Location = new System.Drawing.Point(301, 47);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "MODELO";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(144, 47);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(100, 20);
            this.txbModel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "MARCA";
            // 
            // txbMark
            // 
            this.txbMark.Location = new System.Drawing.Point(9, 115);
            this.txbMark.Name = "txbMark";
            this.txbMark.Size = new System.Drawing.Size(100, 20);
            this.txbMark.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "PLACA";
            // 
            // txbPlate
            // 
            this.txbPlate.Location = new System.Drawing.Point(9, 47);
            this.txbPlate.Name = "txbPlate";
            this.txbPlate.Size = new System.Drawing.Size(100, 20);
            this.txbPlate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "COLOR";
            // 
            // cbxColors
            // 
            this.cbxColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColors.FormattingEnabled = true;
            this.cbxColors.Items.AddRange(new object[] {
            "Verde",
            "Rojo",
            "Azul",
            "Negro",
            "Morado",
            "Dorado",
            "Naranja"});
            this.cbxColors.Location = new System.Drawing.Point(144, 115);
            this.cbxColors.Name = "cbxColors";
            this.cbxColors.Size = new System.Drawing.Size(121, 21);
            this.cbxColors.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColors);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPlate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxColors;
    }
}