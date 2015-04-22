using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Convertor_GUI {
    
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            string[] Currency =
                Currencies.GetNames(typeof(Currencies));

            string[] Country = { "Australia", "China", "Denmark", "Europe", "India", "New Zealand", "United Arab Emirates", "United Kingdom", "United States", "Vietnam" };

            foreach (string Code in Currency) {
                startCurrencyBox.Items.Add(Code);
                endCurrencyBox.Items.Add(Code);
            }
        }

        

        private void startCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            startCurrencyBox.Enabled = false;
            endCurrencyBox.Enabled = true;

        }

        private void endCurrencyBox_SelectedIndexChanged(object sender, EventArgs e) {
            endCurrencyBox.Enabled = false;
            startAmountBox.Enabled = true;
            startCodeLabel.Text = startCurrencyBox.SelectedItem.ToString();
            startCodeLabel.Visible = true;
        }


        private void equalsButton_Click(object sender, EventArgs e) {
            
            string startCode = startCurrencyBox.SelectedItem.ToString();
            string endCode = endCurrencyBox.SelectedItem.ToString();
           // string startAmount = Convert.ToInt32(startAmountBox.Text);

            int startAmount = 0;
            if (!int.TryParse(startAmountBox.Text, out startAmount)) {
                MessageBox.Show("You have not entered a valid amount, please try again");
                startAmountBox.Text = "";
                startAmountBox.Focus();
                endCodeLabel.Text = endCurrencyBox.SelectedItem.ToString();
                endCodeLabel.Visible = true;
            } else {
                conversionGroupBox.Visible = true;
                startAmountBox.Enabled = false;
            }

            double endAmount = Currency_Exchange.ConvertCurrency(startAmount, startCode, endCode);
            endAmountBox.Text = endAmount.ToString();

            

        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e) {
            Close();
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e) {
            startCurrencyBox.SelectedItem = "";
            startCurrencyBox.Enabled = true;
            endCurrencyBox.SelectedItem = "";
            startAmountBox.Text = "";
            endAmountBox.Text = "";
            conversionGroupBox.Visible = false;
            startCodeLabel.Visible = false;
            endCodeLabel.Visible = false;
            yesRadioButton.Checked = false;
            noRadioButton.Checked = false;
        }

       
         
    }//end class 
}
