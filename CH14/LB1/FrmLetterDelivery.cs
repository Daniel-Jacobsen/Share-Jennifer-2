using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH14LB1
{
    public partial class FrmLetterDelivery : Form
    {
        List<Letter> santasLetters = new List<Letter>(20);

        public FrmLetterDelivery()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string trackingNumber = TxtTrackingNumber.Text;

            if (String.IsNullOrEmpty(trackingNumber))
            {
                //Letter
                santasLetters.Add(new Letter(TxtRecipient.Text, DateTime.Parse(TxtSentDate.Text)));
            }
            else
            {
                //Certified Letter
                santasLetters.Add(new CertifiedLetter(TxtRecipient.Text, DateTime.Parse(TxtSentDate.Text), TxtTrackingNumber.Text));
            }
            string currentOutput = LblOutput.Text;

            LblOutput.Text =santasLetters[santasLetters.Count - 1].ToString() + "\n" + currentOutput;
        }
    }
}
