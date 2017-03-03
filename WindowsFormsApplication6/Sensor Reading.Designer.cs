namespace WindowsFormsApplication6
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblUnitsOfForce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmpacts = new System.Windows.Forms.Label();
            this.lblAverageForceMeasuredLabel = new System.Windows.Forms.Label();
            this.txtAmountMeasured = new System.Windows.Forms.TextBox();
            this.txtAdjustedForce = new System.Windows.Forms.TextBox();
            this.txtForceAverage = new System.Windows.Forms.TextBox();
            this.lblAdjustedForceLabel = new System.Windows.Forms.Label();
            this.txtImpactsNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(74, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblUnitsOfForce
            // 
            this.lblUnitsOfForce.AutoSize = true;
            this.lblUnitsOfForce.Location = new System.Drawing.Point(38, 35);
            this.lblUnitsOfForce.Name = "lblUnitsOfForce";
            this.lblUnitsOfForce.Size = new System.Drawing.Size(73, 13);
            this.lblUnitsOfForce.TabIndex = 2;
            this.lblUnitsOfForce.Text = "Units of Force";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // lblmpacts
            // 
            this.lblmpacts.AutoSize = true;
            this.lblmpacts.Location = new System.Drawing.Point(38, 140);
            this.lblmpacts.Name = "lblmpacts";
            this.lblmpacts.Size = new System.Drawing.Size(96, 13);
            this.lblmpacts.TabIndex = 5;
            this.lblmpacts.Text = "Number of Impacts";
            // 
            // lblAverageForceMeasuredLabel
            // 
            this.lblAverageForceMeasuredLabel.AutoSize = true;
            this.lblAverageForceMeasuredLabel.Location = new System.Drawing.Point(38, 108);
            this.lblAverageForceMeasuredLabel.Name = "lblAverageForceMeasuredLabel";
            this.lblAverageForceMeasuredLabel.Size = new System.Drawing.Size(127, 13);
            this.lblAverageForceMeasuredLabel.TabIndex = 4;
            this.lblAverageForceMeasuredLabel.Text = "Average Force Measured";
            // 
            // txtAmountMeasured
            // 
            this.txtAmountMeasured.Location = new System.Drawing.Point(172, 32);
            this.txtAmountMeasured.Name = "txtAmountMeasured";
            this.txtAmountMeasured.Size = new System.Drawing.Size(100, 20);
            this.txtAmountMeasured.TabIndex = 1;
            // 
            // txtAdjustedForce
            // 
            this.txtAdjustedForce.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtAdjustedForce.Location = new System.Drawing.Point(172, 67);
            this.txtAdjustedForce.Name = "txtAdjustedForce";
            this.txtAdjustedForce.ReadOnly = true;
            this.txtAdjustedForce.Size = new System.Drawing.Size(100, 20);
            this.txtAdjustedForce.TabIndex = 0;
            this.txtAdjustedForce.TabStop = false;
            // 
            // txtForceAverage
            // 
            this.txtForceAverage.Location = new System.Drawing.Point(172, 105);
            this.txtForceAverage.Name = "txtForceAverage";
            this.txtForceAverage.ReadOnly = true;
            this.txtForceAverage.Size = new System.Drawing.Size(100, 20);
            this.txtForceAverage.TabIndex = 0;
            this.txtForceAverage.TabStop = false;
            // 
            // lblAdjustedForceLabel
            // 
            this.lblAdjustedForceLabel.AutoSize = true;
            this.lblAdjustedForceLabel.Location = new System.Drawing.Point(38, 70);
            this.lblAdjustedForceLabel.Name = "lblAdjustedForceLabel";
            this.lblAdjustedForceLabel.Size = new System.Drawing.Size(78, 13);
            this.lblAdjustedForceLabel.TabIndex = 10;
            this.lblAdjustedForceLabel.Text = "Adjusted Force";
            // 
            // txtImpactsNumber
            // 
            this.txtImpactsNumber.Location = new System.Drawing.Point(172, 140);
            this.txtImpactsNumber.Name = "txtImpactsNumber";
            this.txtImpactsNumber.ReadOnly = true;
            this.txtImpactsNumber.Size = new System.Drawing.Size(100, 20);
            this.txtImpactsNumber.TabIndex = 0;
            this.txtImpactsNumber.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 273);
            this.Controls.Add(this.txtImpactsNumber);
            this.Controls.Add(this.lblAdjustedForceLabel);
            this.Controls.Add(this.txtForceAverage);
            this.Controls.Add(this.txtAdjustedForce);
            this.Controls.Add(this.txtAmountMeasured);
            this.Controls.Add(this.lblmpacts);
            this.Controls.Add(this.lblAverageForceMeasuredLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUnitsOfForce);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblUnitsOfForce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmpacts;
        private System.Windows.Forms.Label lblAverageForceMeasuredLabel;
        private System.Windows.Forms.TextBox txtAmountMeasured;
        private System.Windows.Forms.TextBox txtAdjustedForce;
        private System.Windows.Forms.TextBox txtForceAverage;
        private System.Windows.Forms.Label lblAdjustedForceLabel;
        private System.Windows.Forms.TextBox txtImpactsNumber;
    }
}

