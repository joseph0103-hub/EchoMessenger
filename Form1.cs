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
            UpdateMessageCount();
            txtmsg.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
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
            string typed_msg = txtmsg.Text.Trim();

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtmsg.Clear();
                txtmsg.Focus();
                return;
            }

            string messageWithTime = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";
            listBox1.Items.Add(messageWithTime);
            txtmsg.Clear();
            txtmsg.Focus();
            UpdateMessageCount();
        }

        private void UpdateMessageCount()
        {
            lblCount.Text = $"현재 대화: {listBox1.Items.Count}개";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = txtmsg;
            txtmsg.Focus();
        }
    }
}
