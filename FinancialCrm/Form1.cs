using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance=db.Bankss.Where(x=>x.BankTitle== "Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Bankss.Where(x => x.BankTitle == "Vakıf Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Bankss.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();


            lblZiraatBankBalance.Text = ziraatBankBalance.ToString()+ " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblİsBankBalance.Text = isBankBalance.ToString() + " ₺";

            //banka hareketleri

            var bankProcess1=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + "-" + bankProcess1.Amount + " - " + bankProcess1.ProccesDate + " ";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + "-" + bankProcess2.Amount + " - " + bankProcess2.ProccesDate + " ";
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + "-" + bankProcess3.Amount + " - " + bankProcess3.ProccesDate + " ";
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + "-" + bankProcess4.Amount + " - " + bankProcess4.ProccesDate + " ";
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + "-" + bankProcess5.Amount + " - " + bankProcess5.ProccesDate + " ";


            //var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            //if (bankProcess1 != null)
            //    lblBankProcess1.Text = bankProcess1.Description + "-" + bankProcess1.Amount + " - " + bankProcess1.ProccesDate;
            //else
            //    lblBankProcess1.Text = "Kayıt bulunamadı";


            //var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(1).Take(1).FirstOrDefault();
            //if (bankProcess2 != null)
            //    lblBankProcess2.Text = bankProcess2.Description + "-" + bankProcess2.Amount + " - " + bankProcess2.ProccesDate;
            //else
            //    lblBankProcess2.Text = "Kayıt bulunamadı";

            //var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(2).Take(1).FirstOrDefault();
            //if (bankProcess3 != null)
            //    lblBankProcess3.Text = bankProcess3.Description + "-" + bankProcess3.Amount + " - " + bankProcess3.ProccesDate;
            //else
            //    lblBankProcess3.Text = "Kayıt bulunamadı";

            //var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            //if (bankProcess4 != null)
            //    lblBankProcess4.Text = bankProcess4.Description + "-" + bankProcess4.Amount + " - " + bankProcess4.ProccesDate;
            //else
            //    lblBankProcess4.Text = "Kayıt bulunamadı";

            //var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Skip(3).Take(1).FirstOrDefault();
            //if (bankProcess5 != null)
            //    lblBankProcess5.Text = bankProcess5.Description + "-" + bankProcess5.Amount + " - " + bankProcess5.ProccesDate;
            //else
            //    lblBankProcess5.Text = "Kayıt bulunamadı";





        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm=new FrmBilling();
            frm.Show();
            this.Hide();

        }
    }
}
