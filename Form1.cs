using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Echo Messenger";
            EchoMessege.Text = "Echo Messenger";
            button1.Text = "전송";
            txtmsg.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtmsg.Text;
            listBox1.Items.Add(typed_msg);
            txtmsg.Clear();
            txtmsg.Focus();
        }

        private void txtmsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string typed_msg = txtmsg.Text;

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtmsg.Clear();
                txtmsg.Focus();
                return;
            }

            listBox1.Items.Add(typed_msg);
            txtmsg.Clear();
            txtmsg.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = txtmsg;
            txtmsg.Focus();
        }
    }
}
