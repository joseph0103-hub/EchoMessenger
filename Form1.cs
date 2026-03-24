using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        private object typed_msg;
        private object stringtyped_msg; // 입력 테스트
        private object mylistBox; // 리스트 박스

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
    }
}
