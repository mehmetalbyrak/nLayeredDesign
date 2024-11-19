namespace DBFirst.EFProject
{
    partial class FrmLocation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLocationCountry = new System.Windows.Forms.TextBox();
            this.lblLocationCountry = new System.Windows.Forms.Label();
            this.txtLocationCity = new System.Windows.Forms.TextBox();
            this.lblLocationCity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtLocationId = new System.Windows.Forms.TextBox();
            this.lblLocationId = new System.Windows.Forms.Label();
            this.txtDayNight = new System.Windows.Forms.TextBox();
            this.lblDayNight = new System.Windows.Forms.Label();
            this.txtLocationPrice = new System.Windows.Forms.TextBox();
            this.lblLocationPrice = new System.Windows.Forms.Label();
            this.lblLocationCapacity = new System.Windows.Forms.Label();
            this.lblGuideId = new System.Windows.Forms.Label();
            this.cmbGuideId = new System.Windows.Forms.ComboBox();
            this.numUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(126, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetById.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetById.Location = new System.Drawing.Point(19, 305);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(91, 23);
            this.btnGetById.TabIndex = 24;
            this.btnGetById.Text = "Get By Id";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(126, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(19, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(126, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLocationCountry
            // 
            this.txtLocationCountry.Location = new System.Drawing.Point(117, 64);
            this.txtLocationCountry.Name = "txtLocationCountry";
            this.txtLocationCountry.Size = new System.Drawing.Size(100, 20);
            this.txtLocationCountry.TabIndex = 20;
            // 
            // lblLocationCountry
            // 
            this.lblLocationCountry.AutoSize = true;
            this.lblLocationCountry.Location = new System.Drawing.Point(12, 67);
            this.lblLocationCountry.Name = "lblLocationCountry";
            this.lblLocationCountry.Size = new System.Drawing.Size(90, 13);
            this.lblLocationCountry.TabIndex = 19;
            this.lblLocationCountry.Text = "Location Country:";
            // 
            // txtLocationCity
            // 
            this.txtLocationCity.Location = new System.Drawing.Point(117, 38);
            this.txtLocationCity.Name = "txtLocationCity";
            this.txtLocationCity.Size = new System.Drawing.Size(100, 20);
            this.txtLocationCity.TabIndex = 18;
            // 
            // lblLocationCity
            // 
            this.lblLocationCity.AutoSize = true;
            this.lblLocationCity.Location = new System.Drawing.Point(31, 38);
            this.lblLocationCity.Name = "lblLocationCity";
            this.lblLocationCity.Size = new System.Drawing.Size(71, 13);
            this.lblLocationCity.TabIndex = 17;
            this.lblLocationCity.Text = "Location City:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 316);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnList.Location = new System.Drawing.Point(19, 212);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(91, 23);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtLocationId
            // 
            this.txtLocationId.Location = new System.Drawing.Point(117, 12);
            this.txtLocationId.Name = "txtLocationId";
            this.txtLocationId.Size = new System.Drawing.Size(100, 20);
            this.txtLocationId.TabIndex = 14;
            // 
            // lblLocationId
            // 
            this.lblLocationId.AutoSize = true;
            this.lblLocationId.Location = new System.Drawing.Point(39, 12);
            this.lblLocationId.Name = "lblLocationId";
            this.lblLocationId.Size = new System.Drawing.Size(63, 13);
            this.lblLocationId.TabIndex = 13;
            this.lblLocationId.Text = "Location Id:";
            // 
            // txtDayNight
            // 
            this.txtDayNight.Location = new System.Drawing.Point(117, 147);
            this.txtDayNight.Name = "txtDayNight";
            this.txtDayNight.Size = new System.Drawing.Size(100, 20);
            this.txtDayNight.TabIndex = 31;
            // 
            // lblDayNight
            // 
            this.lblDayNight.AutoSize = true;
            this.lblDayNight.Location = new System.Drawing.Point(45, 150);
            this.lblDayNight.Name = "lblDayNight";
            this.lblDayNight.Size = new System.Drawing.Size(57, 13);
            this.lblDayNight.TabIndex = 30;
            this.lblDayNight.Text = "Day Night:";
            // 
            // txtLocationPrice
            // 
            this.txtLocationPrice.Location = new System.Drawing.Point(117, 121);
            this.txtLocationPrice.Name = "txtLocationPrice";
            this.txtLocationPrice.Size = new System.Drawing.Size(100, 20);
            this.txtLocationPrice.TabIndex = 29;
            // 
            // lblLocationPrice
            // 
            this.lblLocationPrice.AutoSize = true;
            this.lblLocationPrice.Location = new System.Drawing.Point(24, 121);
            this.lblLocationPrice.Name = "lblLocationPrice";
            this.lblLocationPrice.Size = new System.Drawing.Size(78, 13);
            this.lblLocationPrice.TabIndex = 28;
            this.lblLocationPrice.Text = "Location Price:";
            // 
            // lblLocationCapacity
            // 
            this.lblLocationCapacity.AutoSize = true;
            this.lblLocationCapacity.Location = new System.Drawing.Point(7, 95);
            this.lblLocationCapacity.Name = "lblLocationCapacity";
            this.lblLocationCapacity.Size = new System.Drawing.Size(95, 13);
            this.lblLocationCapacity.TabIndex = 26;
            this.lblLocationCapacity.Text = "Location Capacity:";
            // 
            // lblGuideId
            // 
            this.lblGuideId.AutoSize = true;
            this.lblGuideId.Location = new System.Drawing.Point(52, 176);
            this.lblGuideId.Name = "lblGuideId";
            this.lblGuideId.Size = new System.Drawing.Size(50, 13);
            this.lblGuideId.TabIndex = 32;
            this.lblGuideId.Text = "Guide Id:";
            // 
            // cmbGuideId
            // 
            this.cmbGuideId.FormattingEnabled = true;
            this.cmbGuideId.Location = new System.Drawing.Point(117, 173);
            this.cmbGuideId.Name = "cmbGuideId";
            this.cmbGuideId.Size = new System.Drawing.Size(100, 21);
            this.cmbGuideId.TabIndex = 33;
            // 
            // numUpDownCapacity
            // 
            this.numUpDownCapacity.Location = new System.Drawing.Point(117, 95);
            this.numUpDownCapacity.Name = "numUpDownCapacity";
            this.numUpDownCapacity.Size = new System.Drawing.Size(100, 20);
            this.numUpDownCapacity.TabIndex = 34;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 357);
            this.Controls.Add(this.numUpDownCapacity);
            this.Controls.Add(this.cmbGuideId);
            this.Controls.Add(this.lblGuideId);
            this.Controls.Add(this.txtDayNight);
            this.Controls.Add(this.lblDayNight);
            this.Controls.Add(this.txtLocationPrice);
            this.Controls.Add(this.lblLocationPrice);
            this.Controls.Add(this.lblLocationCapacity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLocationCountry);
            this.Controls.Add(this.lblLocationCountry);
            this.Controls.Add(this.txtLocationCity);
            this.Controls.Add(this.lblLocationCity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtLocationId);
            this.Controls.Add(this.lblLocationId);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLocationCountry;
        private System.Windows.Forms.Label lblLocationCountry;
        private System.Windows.Forms.TextBox txtLocationCity;
        private System.Windows.Forms.Label lblLocationCity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtLocationId;
        private System.Windows.Forms.Label lblLocationId;
        private System.Windows.Forms.TextBox txtDayNight;
        private System.Windows.Forms.Label lblDayNight;
        private System.Windows.Forms.TextBox txtLocationPrice;
        private System.Windows.Forms.Label lblLocationPrice;
        private System.Windows.Forms.Label lblLocationCapacity;
        private System.Windows.Forms.Label lblGuideId;
        private System.Windows.Forms.ComboBox cmbGuideId;
        private System.Windows.Forms.NumericUpDown numUpDownCapacity;
    }
}