using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        private const int MaxMessageLength = 50;

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
            lblLength.Text = $"입력 길이: {txtmsg.TextLength}/{MaxMessageLength}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Echo Messenger";
            EchoMessenger.Text = "Echo Messenger";
            button1.Text = "전송";
            btnDelete.Text = "삭제";
            btnClear.Text = "대화 기록 삭제";
            txtmsg.MaxLength = MaxMessageLength;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 메시지를 먼저 선택하세요.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            UpdateMessageCount();
            txtmsg.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("삭제할 대화 기록이 없습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmsg.Focus();
                return;
            }

            listBox1.Items.Clear();
            UpdateMessageCount();
            txtmsg.Focus();
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

            if (typed_msg.Length > MaxMessageLength)
            {
                MessageBox.Show($"메시지는 {MaxMessageLength}자 이하로 입력하세요.", "입력 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmsg.Focus();
                txtmsg.SelectionStart = txtmsg.TextLength;
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
