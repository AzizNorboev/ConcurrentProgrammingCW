using ClientSide.ServiceReference1;
using SwipesCollectionManagementService;
using SwipesCollectionManagementService.DAL.DBO;
using SwipesCollectionManagementService.DAL.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class UserInterface : Form
    {
        private static readonly Semaphore Semaphore = new Semaphore(3,3)    ;
        readonly Random random = new Random();
        public UserInterface()
        {
            InitializeComponent();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swipesRecordDataSet.Swipes' table. You can move, or remove it, as needed.
            this.swipesTableAdapter.Fill(this.swipesRecordDataSet.Swipes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 10; i++)
            {
                Thread thread = new Thread(GetTerminalStatus);
                int randomPart = random.Next(i, 255);
                string randomIp = "255.255.255." + randomPart;
                Terminal terminal = new Terminal(randomIp, "Waiting");
                TerminalRepo.Instance.AddTerminal(terminal);
                thread.Start(terminal);
            }
            timer1.Enabled = true;
        }

        private void GetTerminalStatus(object terminalObj)
        {
            var terminal = (Terminal)terminalObj;
            Invoke(new MethodInvoker(delegate { dataGridViewTerminal.DataSource = TerminalRepo.Instance.GetAllTerminals(); dataGridViewTerminal.Refresh(); }));
            Semaphore.WaitOne();
            terminal.Status = "InProcess";
            Invoke(new MethodInvoker(delegate { dataGridViewTerminal.DataSource = TerminalRepo.Instance.GetAllTerminals(); dataGridViewTerminal.Refresh(); }));
            ServiceReference1.IService1 service = new Service1Client();
            service.CollectSwipes(terminal.Ip);
            Semaphore.Release();
            terminal.Status = "Finished";
            Invoke(new MethodInvoker(delegate { dataGridViewTerminal.DataSource = TerminalRepo.Instance.GetAllTerminals(); dataGridViewTerminal.Refresh(); }));
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    this.swipesTableAdapter.Fill(this.swipesRecordDataSet.Swipes);
        //}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.swipesTableAdapter.Fill(this.swipesRecordDataSet.Swipes);
        }
    }
}
