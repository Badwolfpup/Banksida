namespace Banksida
{
    public partial class Form1 : Form
    {
        Account account;
        List<Account> accountList = new List<Account>();
        login loggain;
        TextBox textBox;
        Form addNewaccount;
        public Form1()
        {
            InitializeComponent();
            loggain = new login();
            loggain.ShowDialog();
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            addNewaccount = new Form();
            addNewaccount.Size = new Size(300, 250);
            addNewaccount.Location = new Point(250, 250);
            Label label = new Label();
            label.Location = new Point(50, 0);
            label.Text = "Account name";
            textBox = new TextBox();
            textBox.Location = new Point(50, 40);
            Button button = new Button();
            button.Location = new Point(50, 90);
            button.Text = "OK";
            addNewaccount.Controls.Add(textBox);
            addNewaccount.Controls.Add(button);
            addNewaccount.Controls.Add(label);
            button.Click += new EventHandler(addNewaccount_Click);
            addNewaccount.ShowDialog();
        }

        private void addNewaccount_Click (object sender, EventArgs e)
        {
            addNewaccount.Close();
            account = new Account(textBox.Text, 17650);
            accountList.Add(account);
            viewAccount.Items.Add(account.Name + ", " + account.Balance.ToString());
            viewAccount.SelectedIndex = viewAccount.Items.Count-1;
        }
    }
}