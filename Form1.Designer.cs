namespace Cost_of_electricity_consumption
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateEnergyConsumption_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buildingType = new System.Windows.Forms.ComboBox();
            this.buildingType2 = new System.Windows.Forms.ComboBox();
            this.HeatDemand = new System.Windows.Forms.Button();
            this.areaHome = new System.Windows.Forms.NumericUpDown();
            this.heatDeamndLabelResult = new System.Windows.Forms.Label();
            this.tarrifComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.finallyResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areaHome)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateEnergyConsumption_Button
            // 
            this.calculateEnergyConsumption_Button.Location = new System.Drawing.Point(478, 139);
            this.calculateEnergyConsumption_Button.Name = "calculateEnergyConsumption_Button";
            this.calculateEnergyConsumption_Button.Size = new System.Drawing.Size(121, 41);
            this.calculateEnergyConsumption_Button.TabIndex = 0;
            this.calculateEnergyConsumption_Button.Text = "Oblicz Zuzycie";
            this.calculateEnergyConsumption_Button.UseVisualStyleBackColor = true;
            this.calculateEnergyConsumption_Button.Click += new System.EventHandler(this.CalculateEnergyConsumption_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metraz potrzebny do ogrzania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz rodzaj budynku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz Taryfe";
            // 
            // buildingType
            // 
            this.buildingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingType.FormattingEnabled = true;
            this.buildingType.Location = new System.Drawing.Point(165, 69);
            this.buildingType.Name = "buildingType";
            this.buildingType.Size = new System.Drawing.Size(161, 21);
            this.buildingType.TabIndex = 7;
            this.buildingType.SelectedIndexChanged += new System.EventHandler(this.BuildingType_SelectedIndexChanged);
            // 
            // buildingType2
            // 
            this.buildingType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingType2.FormattingEnabled = true;
            this.buildingType2.Location = new System.Drawing.Point(165, 96);
            this.buildingType2.Name = "buildingType2";
            this.buildingType2.Size = new System.Drawing.Size(161, 21);
            this.buildingType2.TabIndex = 8;
            this.buildingType2.Visible = false;
            this.buildingType2.SelectedIndexChanged += new System.EventHandler(this.BuildingType2_SelectedIndexChanged);
            // 
            // HeatDemand
            // 
            this.HeatDemand.Location = new System.Drawing.Point(40, 139);
            this.HeatDemand.Name = "HeatDemand";
            this.HeatDemand.Size = new System.Drawing.Size(286, 41);
            this.HeatDemand.TabIndex = 9;
            this.HeatDemand.Text = "Oblicz zapotrzebowanie na energie";
            this.HeatDemand.UseVisualStyleBackColor = true;
            this.HeatDemand.Click += new System.EventHandler(this.HeatDemand_Click);
            // 
            // areaHome
            // 
            this.areaHome.Location = new System.Drawing.Point(165, 26);
            this.areaHome.Name = "areaHome";
            this.areaHome.Size = new System.Drawing.Size(161, 20);
            this.areaHome.TabIndex = 10;
            // 
            // heatDeamndLabelResult
            // 
            this.heatDeamndLabelResult.AutoSize = true;
            this.heatDeamndLabelResult.Location = new System.Drawing.Point(37, 206);
            this.heatDeamndLabelResult.Name = "heatDeamndLabelResult";
            this.heatDeamndLabelResult.Size = new System.Drawing.Size(224, 13);
            this.heatDeamndLabelResult.TabIndex = 11;
            this.heatDeamndLabelResult.Text = "Komikat o zapotrzebowaniu zgodnie z wzorem";
            this.heatDeamndLabelResult.Visible = false;
            // 
            // tarrifComboBox
            // 
            this.tarrifComboBox.FormattingEnabled = true;
            this.tarrifComboBox.Location = new System.Drawing.Point(478, 23);
            this.tarrifComboBox.Name = "tarrifComboBox";
            this.tarrifComboBox.Size = new System.Drawing.Size(121, 21);
            this.tarrifComboBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(478, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rodzaj ogrzewania";
            // 
            // finallyResultLabel
            // 
            this.finallyResultLabel.AutoSize = true;
            this.finallyResultLabel.Location = new System.Drawing.Point(345, 206);
            this.finallyResultLabel.Name = "finallyResultLabel";
            this.finallyResultLabel.Size = new System.Drawing.Size(151, 13);
            this.finallyResultLabel.TabIndex = 15;
            this.finallyResultLabel.Text = "Wyliczenia zuzycia miesieczne";
            this.finallyResultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 316);
            this.Controls.Add(this.finallyResultLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tarrifComboBox);
            this.Controls.Add(this.heatDeamndLabelResult);
            this.Controls.Add(this.areaHome);
            this.Controls.Add(this.HeatDemand);
            this.Controls.Add(this.buildingType2);
            this.Controls.Add(this.buildingType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateEnergyConsumption_Button);
            this.Name = "Form1";
            this.Text = "Koszty zuzycia energii na potrzeby ogrzewania elektrycznego";
            ((System.ComponentModel.ISupportInitialize)(this.areaHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateEnergyConsumption_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox buildingType;
        private System.Windows.Forms.ComboBox buildingType2;
        private System.Windows.Forms.Button HeatDemand;
        private System.Windows.Forms.NumericUpDown areaHome;
        private System.Windows.Forms.Label heatDeamndLabelResult;
        private System.Windows.Forms.ComboBox tarrifComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label finallyResultLabel;
    }
}

