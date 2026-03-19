namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typed_msg = txtInput.Text.Trim(); // 2-1 문자열 정제: 입력값의 앞뒤 공백 제거

            if (typed_msg == "") // 1-4 입력 방어: 공백 또는 기본 안내문 입력 시 전송 차단
                return;
            lstEchoWindow.Items.Add(typed_msg);
            txtInput.Clear();  // 1-1 입력창 초기화
            txtInput.Focus();  // 1-2 입력창 포커스 이동
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 1-3 엔터키 입력 감지
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
