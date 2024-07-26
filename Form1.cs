namespace ServerSwitcher
{
    public partial class ServerSwitcher : Form
    {
        //DX is 99 - 1 lines in by default
        //EX is 95 - 1 lines in by default
        private const int DX_LINE = 99;
        private const int EX_LINE = 95;
        private string coopDXpath = Environment.ExpandEnvironmentVariables(@"%APPDATA%\sm64coopdx\sm64config.txt");
        private string coopEXpath = Environment.ExpandEnvironmentVariables(@"%APPDATA%\sm64ex-coop\sm64config.txt");
        private string s_ogServer = "coopnet_ip net.coop64.us";
        private string s_btServer = "coopnet_ip coop.burritobot.net";
        private bool ogCoopDX;
        private bool ogCoopEX;

        public ServerSwitcher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetServerState(coopDXpath, DX_LINE, label1, ref ogCoopDX, button1);
            GetServerState(coopEXpath, EX_LINE, label4, ref ogCoopEX, button2);
        }

        private void GetServerState(string path, int line, Label label, ref bool serverFlag, Button button)
        {
            if (File.Exists(path))
            {
                string currentServer = ReadLine(path, line);
                serverFlag = (currentServer == s_ogServer);
                label.Text = serverFlag ? "Connected to CoopNet" : "Connected to BurritoNet";
                button.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleServer(coopDXpath, DX_LINE, label1, ref ogCoopDX);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ToggleServer(coopEXpath, EX_LINE, label4, ref ogCoopEX);
        }

        private void ToggleServer(string path, int line, Label label, ref bool serverFlag)
        {
            serverFlag = !serverFlag;
            string newServer = serverFlag ? s_ogServer : s_btServer;
            label.Text = serverFlag ? "Connected to CoopNet" : "Connected to BurritoNet";
            LineSwap(newServer, path, line);
        }

        static void LineSwap(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        static string ReadLine(string file, int line_to_read)
        {
            string[] arrLine = File.ReadAllLines(file);
            return arrLine[line_to_read - 1];
        }
    }
}
