using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Prova_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SmtpClient smtp = new SmtpClient();
        NetworkCredential credenciais = new NetworkCredential();
        MailMessage mail = new MailMessage();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("erickino231@gmail.com", "registro1");
            mail.From = new MailAddress("erickino231@gmail.com");
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {

            }
            else
            {
                MessageBox.Show("Mensagem: não foi preenchido!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {

            }
            else
            {
                MessageBox.Show("Assunto: não foi preenchido!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {

            }
            else
            {
                MessageBox.Show("Para: não foi preenchido");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                mail.To.Add(new MailAddress(textBox2.Text));
            }
            else
            {
                MessageBox.Show("De: não foi preenchido!");
                return;
            }
            mail.Subject = textBox3.Text;
            mail.Body = textBox4.Text;

            mail.IsBodyHtml = true;
            mail.To.Add("erickino231@gmail.com");
            smtp.Send(mail);

            MessageBox.Show("E-mail enviado com sucesso.");

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
