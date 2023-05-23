using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauService;
using static System.Windows.Forms.LinkLabel;

namespace ChapeauUI
{
    public partial class PaymentView : Form
    {
        Payment payment = new Payment();// to avoid doublicate code
        public PaymentView()
        {
            InitializeComponent();
          
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
             if(rbtnNo.Checked)
             {
                lblQuestion.Visible = false;
                txtNumberOfPeople.Visible = false;
                lblPerPerson.Visible = false;
                txtAmountPerPerson.Visible = false;
             }
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                lblQuestion.Visible = true;
                txtNumberOfPeople.Visible = true;
                lblPerPerson.Visible = true;
                txtAmountPerPerson.Visible = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal dessertsCost = decimal.Parse(txtDessertsCost.Text);// Because if i do it in one line it will sum the string not the number.
            decimal drinkCost = decimal.Parse(txtDrinkCost.Text);
            decimal mainCourseCost = decimal.Parse(txtMainCourseCost.Text);
            payment.Price = dessertsCost + drinkCost + mainCourseCost;

            payment.numberOfPeople = int.Parse($"{txtNumberOfPeople.Text}");
            txtAmountPerPerson.Text = $"{payment.SplitAmount}";

            txtWithoutVat.Text = $"{payment.Price}";
            txtPriceWithVAT.Text = $"{payment.TotalAmount}";
            txttips.Text = $"{payment.TipAmount}";
            payment.feedBack = txtFeedback.Text;



            PaymentService paymentService = new PaymentService();
            paymentService.PaymentHistory(payment);
            
        }
        private Payment GetDataOfPayment()
        { 
        Payment payment = new Payment();
            if (rbtnVisa.Checked)
            {
                payment.PaymentMethod = PaymentMethod.Creditcard;
            }
            else if (rbtnPin.Checked)
            {
                payment.PaymentMethod = PaymentMethod.Pin;
            }
            else
            {
                payment.PaymentMethod = PaymentMethod.Cash;
            }
            payment.TotalAmount =decimal.Parse(txtPriceWithVAT.Text);
            payment.TipAmount = decimal.Parse(txttips.Text);
            payment.feedBack=txtFeedback.Text;
            payment.tableNumber = int.Parse(lblTableNumber.Text);

            return payment;
        }

        private void DisplayPaymentHistory(List<Payment> payments)
        {

            listPaymentHistory.Clear();

            listPaymentHistory.Columns.Add("PaymentMethod", 100);
            listPaymentHistory.Columns.Add("TotalAmount", 100);
            listPaymentHistory.Columns.Add("Tip", 50);
            listPaymentHistory.Columns.Add("FeedBack", 200);
            listPaymentHistory.Columns.Add("TableNumber", 50);


            PaymentService paymentService = new PaymentService();

            foreach (Payment payment in payments)
            {
                ListViewItem li = new ListViewItem(payment.PaymentMethod.ToString()) ;
                li.SubItems.Add(payment.TotalAmount.ToString() + "€");
                li.SubItems.Add(payment.TipAmount.ToString() + "€");
                li.SubItems.Add(payment.feedBack);
                li.SubItems.Add(payment.tableNumber.ToString());

                li.Tag = payment;
                listPaymentHistory.Items.Add(li);
            }

            listPaymentHistory.Columns[0].Width = 150;
            listPaymentHistory.Columns[1].Width = 150;
            listPaymentHistory.Columns[2].Width = 50;
            listPaymentHistory.Columns[3].Width = 150;
            listPaymentHistory.Columns[4].Width = 50;

            listPaymentHistory.View = View.Details;
        }

        private List<Payment> GetPayment()
        {
            PaymentService paymentService = new PaymentService();
            List<Payment> payments = paymentService.GetPayment();
            return payments;
        }

        private void UpdatePaymentHistory()// for refreshing
        {
            List<Payment> payments = GetPayment();
            DisplayPaymentHistory(payments);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Payment payment = GetDataOfPayment(); ;
                PaymentService paymentService = new PaymentService();
                paymentService.PaymentHistory(payment);

            }
            catch (Exception message)
            {
                MessageBox.Show("Something went wrong! " + message.Message, "Error");
            }
            UpdatePaymentHistory();//refresh
        }

        
    }
}
