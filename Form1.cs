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
            // 3-1 글자 수 제한: 50자 초과 시 전송 차단
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("50자 이하로 입력하세요.");
                return;
            }
            string time = DateTime.Now.ToString("HH:mm:ss"); // 2-2 타임스탬프 생성
            string finalMsg = $"[{time}] {typed_msg}"; // 2-3 문자열 결합: [시간] + 메시지
            lstEchoWindow.Items.Add(finalMsg); // 메시지를 ListBox에 추가

            txtInput.Clear();  // 1-1 입력창 초기화

            lblCount.Text = $"현재 대화: {lstEchoWindow.Items.Count}개"; // 2-4 메시지 카운팅

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 3-1 전체 초기화: ListBox 모든 항목 삭제
            lstEchoWindow.Items.Clear();

            // 3-2 개수 초기화
            lblCount.Text = "현재 대화: 0개";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
