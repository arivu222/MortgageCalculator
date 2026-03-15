using MortgageCalculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator.WinFormsUI
{
    public partial class Main : Form
    {
        private readonly IMortgageService _mortgageService;
        public Main()
        {
            InitializeComponent();
            _mortgageService = new MortgageService();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cmbMortgageType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMortgageType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMortgageType.DropDownStyle = ComboBoxStyle.DropDown;

            dgvMortgages.AutoGenerateColumns = true;
            dgvMortgages.ReadOnly = true;
            dgvMortgages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMortgages.MultiSelect = false;
            dgvMortgages.AllowUserToAddRows = false;
            dgvMortgages.AllowUserToDeleteRows = false;
            dgvMortgages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadActiveMortgages();

        }

        private void LoadActiveMortgages()
        {
            var mortgages = _mortgageService.GetActiveMortgagesSorted();

            dgvMortgages.DataSource = null;
            dgvMortgages.DataSource = mortgages;

            var mortgageTypes = mortgages
                .Select(x => x.MortgageType.ToString())
                .Distinct()
                .ToList();

            cmbMortgageType.DataSource = null;
            cmbMortgageType.DataSource = mortgageTypes;
        }

        private void btnLoadMortgages_Click(object sender, EventArgs e)
        {
            LoadActiveMortgages();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtLoanAmount.Text, out decimal loanAmount) || loanAmount <= 0)
                {
                    MessageBox.Show("Please enter a valid loan amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLoanAmount.Focus();
                    return;
                }

                if (!decimal.TryParse(txtInterestRate.Text, out decimal interestRate) || interestRate < 0)
                {
                    MessageBox.Show("Please enter a valid interest rate.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInterestRate.Focus();
                    return;
                }

                if (!int.TryParse(txtLoanDurationYears.Text, out int loanDurationYears) || loanDurationYears <= 0)
                {
                    MessageBox.Show("Please enter a valid loan duration in years.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLoanDurationYears.Focus();
                    return;
                }

                var result = _mortgageService.CalculateMortgage(loanAmount, interestRate, loanDurationYears);

                lblMonthlyRepaymentValue.Text = result.MonthlyRepayment.ToString("N2");
                lblTotalRepaymentValue.Text = result.TotalRepayment.ToString("N2");
                lblTotalInterestValue.Text = result.TotalInterest.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoanAmount.Clear();
            txtInterestRate.Clear();
            txtLoanDurationYears.Clear();

            if (cmbMortgageType.Items.Count > 0)
            {
                cmbMortgageType.SelectedIndex = -1;
                cmbMortgageType.Text = string.Empty;
            }

            lblMonthlyRepaymentValue.Text = "0.00";
            lblTotalRepaymentValue.Text = "0.00";
            lblTotalInterestValue.Text = "0.00";

            txtLoanAmount.Focus();
        }


    }
}
