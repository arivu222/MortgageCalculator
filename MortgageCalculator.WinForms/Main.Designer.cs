namespace MortgageCalculator.WinFormsUI
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.GroupBox grpCalculator;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblLoanDurationYears;
        private System.Windows.Forms.TextBox txtLoanDurationYears;
        private System.Windows.Forms.Label lblMortgageType;
        private System.Windows.Forms.ComboBox cmbMortgageType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLoadMortgages;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblMonthlyRepayment;
        private System.Windows.Forms.Label lblMonthlyRepaymentValue;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblTotalRepaymentValue;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblTotalInterestValue;

        private System.Windows.Forms.GroupBox grpMortgages;
        private System.Windows.Forms.DataGridView dgvMortgages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();

            this.grpCalculator = new System.Windows.Forms.GroupBox();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblLoanDurationYears = new System.Windows.Forms.Label();
            this.txtLoanDurationYears = new System.Windows.Forms.TextBox();
            this.lblMortgageType = new System.Windows.Forms.Label();
            this.cmbMortgageType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLoadMortgages = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();


            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblMonthlyRepayment = new System.Windows.Forms.Label();
            this.lblMonthlyRepaymentValue = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblTotalRepaymentValue = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalInterestValue = new System.Windows.Forms.Label();

            this.grpMortgages = new System.Windows.Forms.GroupBox();
            this.dgvMortgages = new System.Windows.Forms.DataGridView();

            this.grpCalculator.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpMortgages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgages)).BeginInit();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Mortgage Calculator";
            this.Load += new System.EventHandler(this.Main_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mortgage Calculator";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(28, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(536, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Choose the right loan and view the interest and repayment details.";

            // 
            // grpCalculator
            // 
            this.grpCalculator.Controls.Add(this.lblLoanAmount);
            this.grpCalculator.Controls.Add(this.txtLoanAmount);
            this.grpCalculator.Controls.Add(this.lblInterestRate);
            this.grpCalculator.Controls.Add(this.txtInterestRate);
            this.grpCalculator.Controls.Add(this.lblLoanDurationYears);
            this.grpCalculator.Controls.Add(this.txtLoanDurationYears);
            this.grpCalculator.Controls.Add(this.lblMortgageType);
            this.grpCalculator.Controls.Add(this.cmbMortgageType);
            this.grpCalculator.Controls.Add(this.btnCalculate);
            this.grpCalculator.Controls.Add(this.btnLoadMortgages);
            this.grpCalculator.Controls.Add(this.btnClear);
            this.grpCalculator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCalculator.Location = new System.Drawing.Point(32, 105);
            this.grpCalculator.Name = "grpCalculator";
            this.grpCalculator.Size = new System.Drawing.Size(560, 265);
            this.grpCalculator.TabIndex = 2;
            this.grpCalculator.TabStop = false;
            this.grpCalculator.Text = "Calculator";

            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanAmount.Location = new System.Drawing.Point(25, 42);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(136, 23);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Borrowed Amount";

            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoanAmount.Location = new System.Drawing.Point(235, 39);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(280, 30);
            this.txtLoanAmount.TabIndex = 1;

            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInterestRate.Location = new System.Drawing.Point(25, 87);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(100, 23);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate";

            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInterestRate.Location = new System.Drawing.Point(235, 84);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(280, 30);
            this.txtInterestRate.TabIndex = 3;

            // 
            // lblLoanDurationYears
            // 
            this.lblLoanDurationYears.AutoSize = true;
            this.lblLoanDurationYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanDurationYears.Location = new System.Drawing.Point(25, 132);
            this.lblLoanDurationYears.Name = "lblLoanDurationYears";
            this.lblLoanDurationYears.Size = new System.Drawing.Size(164, 23);
            this.lblLoanDurationYears.TabIndex = 4;
            this.lblLoanDurationYears.Text = "Loan Duration (Years)";

            // 
            // txtLoanDurationYears
            // 
            this.txtLoanDurationYears.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoanDurationYears.Location = new System.Drawing.Point(235, 129);
            this.txtLoanDurationYears.Name = "txtLoanDurationYears";
            this.txtLoanDurationYears.Size = new System.Drawing.Size(280, 30);
            this.txtLoanDurationYears.TabIndex = 5;

            // 
            // lblMortgageType
            // 
            this.lblMortgageType.AutoSize = true;
            this.lblMortgageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMortgageType.Location = new System.Drawing.Point(25, 177);
            this.lblMortgageType.Name = "lblMortgageType";
            this.lblMortgageType.Size = new System.Drawing.Size(122, 23);
            this.lblMortgageType.TabIndex = 6;
            this.lblMortgageType.Text = "Mortgage Type";

            // 
            // cmbMortgageType
            // 
            this.cmbMortgageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMortgageType.FormattingEnabled = true;
            this.cmbMortgageType.Location = new System.Drawing.Point(235, 174);
            this.cmbMortgageType.Name = "cmbMortgageType";
            this.cmbMortgageType.Size = new System.Drawing.Size(280, 31);
            this.cmbMortgageType.TabIndex = 7;

            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(235, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 35);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnLoadMortgages
            // 
            this.btnLoadMortgages.BackColor = System.Drawing.Color.DimGray;
            this.btnLoadMortgages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMortgages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadMortgages.ForeColor = System.Drawing.Color.White;
            this.btnLoadMortgages.Location = new System.Drawing.Point(385, 216);
            this.btnLoadMortgages.Name = "btnLoadMortgages";
            this.btnLoadMortgages.Size = new System.Drawing.Size(130, 35);
            this.btnLoadMortgages.TabIndex = 9;
            this.btnLoadMortgages.Text = "Load Mortgages";
            this.btnLoadMortgages.UseVisualStyleBackColor = false;
            this.btnLoadMortgages.Click += new System.EventHandler(this.btnLoadMortgages_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(85, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblMonthlyRepayment);
            this.grpResults.Controls.Add(this.lblMonthlyRepaymentValue);
            this.grpResults.Controls.Add(this.lblTotalRepayment);
            this.grpResults.Controls.Add(this.lblTotalRepaymentValue);
            this.grpResults.Controls.Add(this.lblTotalInterest);
            this.grpResults.Controls.Add(this.lblTotalInterestValue);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResults.Location = new System.Drawing.Point(615, 105);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(530, 265);
            this.grpResults.TabIndex = 3;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Calculation Result";

            // 
            // lblMonthlyRepayment
            // 
            this.lblMonthlyRepayment.AutoSize = true;
            this.lblMonthlyRepayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMonthlyRepayment.Location = new System.Drawing.Point(30, 55);
            this.lblMonthlyRepayment.Name = "lblMonthlyRepayment";
            this.lblMonthlyRepayment.Size = new System.Drawing.Size(150, 23);
            this.lblMonthlyRepayment.TabIndex = 0;
            this.lblMonthlyRepayment.Text = "Monthly Repayment";

            // 
            // lblMonthlyRepaymentValue
            // 
            this.lblMonthlyRepaymentValue.AutoSize = true;
            this.lblMonthlyRepaymentValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyRepaymentValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMonthlyRepaymentValue.Location = new System.Drawing.Point(275, 53);
            this.lblMonthlyRepaymentValue.Name = "lblMonthlyRepaymentValue";
            this.lblMonthlyRepaymentValue.Size = new System.Drawing.Size(53, 25);
            this.lblMonthlyRepaymentValue.TabIndex = 1;
            this.lblMonthlyRepaymentValue.Text = "0.00";

            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.AutoSize = true;
            this.lblTotalRepayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalRepayment.Location = new System.Drawing.Point(30, 108);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(126, 23);
            this.lblTotalRepayment.TabIndex = 2;
            this.lblTotalRepayment.Text = "Total Repayment";

            // 
            // lblTotalRepaymentValue
            // 
            this.lblTotalRepaymentValue.AutoSize = true;
            this.lblTotalRepaymentValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalRepaymentValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalRepaymentValue.Location = new System.Drawing.Point(275, 106);
            this.lblTotalRepaymentValue.Name = "lblTotalRepaymentValue";
            this.lblTotalRepaymentValue.Size = new System.Drawing.Size(53, 25);
            this.lblTotalRepaymentValue.TabIndex = 3;
            this.lblTotalRepaymentValue.Text = "0.00";

            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalInterest.Location = new System.Drawing.Point(30, 161);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(97, 23);
            this.lblTotalInterest.TabIndex = 4;
            this.lblTotalInterest.Text = "Total Interest";

            // 
            // lblTotalInterestValue
            // 
            this.lblTotalInterestValue.AutoSize = true;
            this.lblTotalInterestValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalInterestValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalInterestValue.Location = new System.Drawing.Point(275, 159);
            this.lblTotalInterestValue.Name = "lblTotalInterestValue";
            this.lblTotalInterestValue.Size = new System.Drawing.Size(53, 25);
            this.lblTotalInterestValue.TabIndex = 5;
            this.lblTotalInterestValue.Text = "0.00";

            // 
            // grpMortgages
            // 
            this.grpMortgages.Controls.Add(this.dgvMortgages);
            this.grpMortgages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMortgages.Location = new System.Drawing.Point(32, 390);
            this.grpMortgages.Name = "grpMortgages";
            this.grpMortgages.Size = new System.Drawing.Size(1113, 300);
            this.grpMortgages.TabIndex = 4;
            this.grpMortgages.TabStop = false;
            this.grpMortgages.Text = "Active Mortgages";

            // 
            // dgvMortgages
            // 
            this.dgvMortgages.BackgroundColor = System.Drawing.Color.White;
            this.dgvMortgages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMortgages.Location = new System.Drawing.Point(18, 32);
            this.dgvMortgages.Name = "dgvMortgages";
            this.dgvMortgages.RowHeadersWidth = 51;
            this.dgvMortgages.RowTemplate.Height = 24;
            this.dgvMortgages.Size = new System.Drawing.Size(1078, 250);
            this.dgvMortgages.TabIndex = 0;

            // 
            // Add Controls to Form
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.grpCalculator);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpMortgages);

            this.grpCalculator.ResumeLayout(false);
            this.grpCalculator.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpMortgages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMortgages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
