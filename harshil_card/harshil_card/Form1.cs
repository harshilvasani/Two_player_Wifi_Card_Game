using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace harshil_card
{
    public partial class Form1 : Form
    {
        

        int Server = 0,rst=0,wins = 0, losts = 0,crd_recv=0,p1=0,PL,i_server = 0,I=-1,trum_crd_no=4,win = 1;
        int[] card = new int[30], p1_card = new int[15], p2_card = new int[15];
        byte[] buffer =new byte[15],card2=new byte[15];
        byte[] send_card=new byte[1],get_card=new byte[1];
        byte[] data_sent = new byte[1],data_recieve = new byte[1];
        string Location, addr,send_IP="";
        
        bool flag;
        Thread th;
     
        SoundPlayer My_JukeBox; 
        SoundPlayer My_JukeBox2; 
        SoundPlayer My_JukeBox3;

        public Form1()
        {
            InitializeComponent();
            // getting root path
            Location = typeof(Program).Assembly.Location;

            addr = Location.Replace("harshil_card.exe", "cards\\");
            My_JukeBox3 = new SoundPlayer(@"" + addr + "ChillingMusic.wav");
            My_JukeBox3.PlayLooping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // getting root path
            Location = typeof(Program).Assembly.Location;

            addr = Location.Replace("harshil_card.exe", "cards\\");

            My_JukeBox = new SoundPlayer(@""+ addr + "shuffling-cards-1.wav");
            My_JukeBox2 = new SoundPlayer(@"" + addr + "contact1.wav");
             

            data_sent[0] = 0;
            data_recieve[0] = 0;

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox33.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();

            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox40.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox51.Hide();
            pictureBox52.Hide();

            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            pictureBox60.Hide();
            pictureBox61.Hide();
            pictureBox62.Hide();
            pictureBox63.Hide();
            pictureBox64.Hide();
            pictureBox65.Hide();
            pictureBox66.Hide();
            pictureBox67.Hide();
            pictureBox68.Hide();
            pictureBox69.Hide();
            pictureBox70.Hide();
            pictureBox71.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);
                My_JukeBox2.Play();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
             pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y +20);
             My_JukeBox2.Stop();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
             pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 20);
             My_JukeBox2.Stop();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
             pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 20);
             My_JukeBox2.Stop();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 20);
            My_JukeBox2.Stop();
        }
        
        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 20);
            My_JukeBox2.Stop();
        }        

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Location = new Point(pictureBox11.Location.X, pictureBox11.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Location = new Point(pictureBox13.Location.X, pictureBox13.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Location = new Point(pictureBox14.Location.X, pictureBox14.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Location = new Point(pictureBox15.Location.X, pictureBox15.Location.Y - 20);
            My_JukeBox2.Play();
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Location = new Point(pictureBox15.Location.X, pictureBox15.Location.Y + 20);
            My_JukeBox2.Stop();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            I = 0;
            flag = false;
            flag=played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @""+ addr + p1_card[0] + ".png";
                pictureBox1.Hide();
                p2_card[0] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            I = 1; flag = false; 
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[1] + ".png";
                pictureBox2.Hide();
                p2_card[1] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            I = 2; flag = false;
           flag = played_card();
           if (flag)
           {
               My_JukeBox2.Play();
               pictureBox31.ImageLocation = @"" + addr + p1_card[2] + ".png";
               pictureBox3.Hide();
               p2_card[2] = 0;
               th = new Thread(client);
               th.Start();
               th.IsBackground = true;
           }         
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            I = 3; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[3] + ".png";
                pictureBox4.Hide();
                p2_card[3] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            I = 4; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[4] + ".png";
                pictureBox5.Hide();
                p2_card[4] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            I = 5; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[5] + ".png";
                pictureBox6.Hide();
                p2_card[5] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            I = 6; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[6] + ".png";
                pictureBox7.Hide();
                p2_card[6] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            I = 7; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[7] + ".png";
                pictureBox8.Hide();
                p2_card[7] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            I = 8; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[8] + ".png";
                pictureBox9.Hide();
                p2_card[8] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            I = 9; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[9] + ".png";
                pictureBox10.Hide();
                p2_card[9] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            I = 10; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[10] + ".png";
                pictureBox11.Hide();
                p2_card[10] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            I = 11; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[11] + ".png";
                pictureBox12.Hide();
                p2_card[11] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            I = 12; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[12] + ".png";
                pictureBox13.Hide();
                p2_card[12] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            I = 13; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[13] + ".png";
                pictureBox14.Hide();
                p2_card[13] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            I = 14; flag = false;
            flag = played_card();
            if (flag)
            {
                My_JukeBox2.Play();
                pictureBox31.ImageLocation = @"" + addr + p1_card[14] + ".png";
                pictureBox15.Hide();
                p2_card[14] = 0;
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)//SPADES Trum card
        {
            if (p1 == 1)
            {
                My_JukeBox.Play();
                show_card();
                trum_crd_no = 1;
                pictureBox35.Hide();
                pictureBox36.Hide();
                pictureBox37.Hide();
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)//HEARTS trum card
        {
            if (p1 == 1)
            {
                My_JukeBox.Play();
                show_card();
                trum_crd_no = 2;
                pictureBox34.Hide();
                pictureBox35.Hide();
                pictureBox37.Hide();
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)//CLUBs Trum card
        {
            My_JukeBox.Play();
            if (p1 == 1)
            {
                show_card();
                trum_crd_no = 3;
                pictureBox34.Hide();
                pictureBox36.Hide();
                pictureBox37.Hide();
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)//DiamondS Trum card
        {
            My_JukeBox.Play();
            if (p1 == 1)
            {
                show_card();
                trum_crd_no = 0;
                pictureBox34.Hide();
                pictureBox35.Hide();
                pictureBox36.Hide();
                th = new Thread(client);
                th.Start();
                th.IsBackground = true;
            }
        }     

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            rst = 1;
            th = new Thread(client);
            th.Start();
            th.IsBackground = true;
        }
        
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            card_generate();///////////////////
            server_start();
            initialize_game();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            client_start();
            initialize_game();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {                    
            button2.Show();
            button3.Show();
            button4.Hide();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Width += 10;
            button4.Height += 10;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Width -= 10;
            button4.Height -= 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_JukeBox.Play();
           
          //  Thread.Sleep(100);
            p1 = 1;
            PL = 1;
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
           
            pictureBox34.Show();
            pictureBox35.Show();
            pictureBox36.Show();
            pictureBox37.Show();

            button5.Hide();
            button6.Hide();
        }

        private void button6_Click(object sender, EventArgs e)//Play 2nd button
        {
            //call server//done
            My_JukeBox.Play();
            show_card();
            
            p1 = 2;
            PL = 2;
            button6.Hide();
            button5.Hide();
          
            th = new Thread(recieve_trum_card);
            
            th.Start();
            th.IsBackground = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you for playing");
            Application.Exit();
        }

        void restart()
        {
            Application.Exit();
            Thread.Sleep(1000);
            Application.Restart();
            
        }

        void card_generate()
        {
            int crd, max, ind = 0, i;
            Random rnd = new Random();

            for (int j = 0; j < 30; )
            {
                crd = rnd.Next(31, 5000000);

                for (i = 0; i < j; i++)
                {
                    if (card[i] == crd)
                        goto dont;
                }

                card[j] = crd;
                j++;
            dont: continue;
            }

            for (i = 0; i < 30; i++)
            {
                max = 0;
                for (int j = 0; j < 30; j++)
                {
                    if (card[j] > max)
                    {
                        max = card[j];
                        ind = j;
                    }
                }
                card[ind] = 30 - i;
            }

            for (int k = 0; k < 30; k++)
            {
                if (k % 2 == 0)
                {
                    p1_card[k / 2] = card[k];
                }
                else
                {
                    p2_card[k / 2] = card[k];
                    card2[k / 2] = (byte)card[k];
                }
            }
        }

        void initialize_game()
        {
            pictureBox31.ImageLocation = @"" + addr + "b1fv.png";
            pictureBox33.ImageLocation = @"" + addr + "b2fv.png";


            int i;
            if (Server == 0)
            {
                //   start = 0;
                for (i = 0; i < 15; i++)
                {
                    p1_card[i] = (int)buffer[i];
                }
                //    MessageBox.Show("enjoy the game");
            }

            for (i = 0; i < 14; i++)
            {
                p2_card[i] = p1_card[i];
            }


            i = 0;
            pictureBox1.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox2.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox3.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox4.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox5.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox6.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox7.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox8.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox9.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox10.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox11.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox12.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox13.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox14.ImageLocation = @"" + addr + p1_card[i] + ".png"; i++;
            pictureBox15.ImageLocation = @"" + addr + p1_card[i] + ".png";
        }

        void server_start()
        {
            String strHostName = string.Empty;
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();

            // Console.WriteLine("Local Machine's Host Name: " + strHostName);
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            var ResponseData = Encoding.ASCII.GetBytes("");

            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    //Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
                    ResponseData = Encoding.ASCII.GetBytes(addr[i].ToString());
                }

            }

            var Server = new UdpClient(8888);


            while (send_IP == "")
            {
                var ClientEp = new IPEndPoint(IPAddress.Any, 0);
                var ClientRequestData = Server.Receive(ref ClientEp);

                var ClientRequest = Encoding.ASCII.GetString(ClientRequestData);
                send_IP = ClientRequest;
                MessageBox.Show(send_IP + " client's IP");

                Console.WriteLine("Recived {0} from {1}, sending response", ClientRequest, ClientEp.Address.ToString());
                Server.Send(ResponseData, ResponseData.Length, ClientEp);
            }

           server_fun();
         
        }

        void server_fun()
        {
            Server = 1;
            TcpListener listener = new TcpListener(IPAddress.Any, 8888);

        listen: try
            {
                listener.Start();
            }
            catch
            {
                goto listen;
            }
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream client_stream = client.GetStream();

            client_stream.Write(card2, 0, card2.Length);

            button5.Show();
            button6.Show();
            button7.Show();
            button2.Hide();
            button3.Hide();

            listener.Stop();
        }

        string a;
        void client_start()//for sharing IP address
        {

            String strHostName = string.Empty;
            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            // Then using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            var RequestData = Encoding.ASCII.GetBytes("");

            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
                    RequestData = Encoding.ASCII.GetBytes(addr[i].ToString());
                }

            }

            var Client = new UdpClient();
            // var RequestData = Encoding.ASCII.GetBytes("SomeRequestData");
            var ServerEp = new IPEndPoint(IPAddress.Any, 0);

            Client.EnableBroadcast = true;
            Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 8888));

            var ServerResponseData = Client.Receive(ref ServerEp);


            var ServerResponse = Encoding.ASCII.GetString(ServerResponseData);
            send_IP = ServerResponse;
            MessageBox.Show(send_IP + " server's IP");
            Console.WriteLine("Recived {0} from {1}", ServerResponse, ServerEp.Address.ToString());

            Client.Close();

            
              client_fun();
               
        }
        void client_fun()
        {
            TcpClient client = new TcpClient();

        again:
            try
            {
                client.Connect(send_IP, 8888);
            }

            catch (System.Exception)
            {
                goto again;
            }

            NetworkStream client_stream = client.GetStream();
            client_stream.Read(buffer, 0, buffer.Length);

            button5.Show();
            button6.Show();
            button7.Show();
            button2.Hide();
            button3.Hide();
        }

        void recieve_trum_card()
        {
            
            TcpListener listener = new TcpListener(IPAddress.Any, 8888);

        again_listen:
            try
            {
                listener.Start();
            }
            catch (Exception)
            {
                goto again_listen;
            }


            TcpClient client = listener.AcceptTcpClient();
            NetworkStream client_stream = client.GetStream();

            client_stream.Read(data_recieve, 0, data_recieve.Length);
            listener.Stop();
            
                trum_crd_no = (int)data_recieve[0];
                if (trum_crd_no == 0)
                    pictureBox37.Invoke(new System.Action(() => pictureBox37.Show()));
                else if (trum_crd_no == 1)
                    pictureBox34.Invoke(new System.Action(() => pictureBox34.Show()));
                else if (trum_crd_no == 2)
                    pictureBox36.Invoke(new System.Action(() => pictureBox36.Show()));
                else if (trum_crd_no == 3)
                    pictureBox35.Invoke(new System.Action(() => pictureBox35.Show()));
                else
                    MessageBox.Show("no trum card");


                p1 = 0;

                listener.Stop();
                data_recieve[0] = 0;
                th = new Thread(server);
                th.Start();
                th.IsBackground = true;
            
        }

        void server()
        {
            button1.Invoke(new System.Action(() => button1.Hide()));
            i_server = 1;
          
            TcpListener listener = new TcpListener(IPAddress.Any, 8888);

        again_listen:
            try
            {
                listener.Start();
            }
            catch (Exception)
            {
                goto again_listen;
            }


            TcpClient client = listener.AcceptTcpClient();
            NetworkStream client_stream = client.GetStream();

            client_stream.Read(data_recieve, 0, data_recieve.Length);
            
            

            if (data_recieve[0] == 50)
            {
                restart();
            }

            
                My_JukeBox2.Play();
                pictureBox33.ImageLocation = @"" + addr + (int)data_recieve[0] + ".png";//change again original when new card played

                crd_recv++;
                show_win_cards();///called to hide p2 cards


                i_server = 0;
                listener.Stop();
                if (data_recieve[0] != 0 && data_sent[0] != 0)
                {
                    decide_fate();
                }
                

                 
            button1.Invoke(new System.Action(() => button1.Show()));
        }

        void client()//always sends the data
        {
           
            TcpClient client = new TcpClient();
            NetworkStream client_stream;


        again_connect:
            try
            {
                client.Connect(send_IP, 8888);
            }
            catch (Exception)
            {
                goto again_connect;
            }
            client_stream = client.GetStream();

            if (rst == 1)
            {
                data_sent[0] = 50;
                client_stream.Write(data_sent, 0, data_sent.Length);
                Thread.Sleep(1000);
                restart();
            }


            if (p1 == 1)
            {
                data_sent[0] = (byte)trum_crd_no;
            }

            if (p1 == 0)
            {
                data_sent[0] = (byte)p1_card[I];
                MessageBox.Show(I.ToString());
            }
            client_stream.Write(data_sent, 0, data_sent.Length);
            
    
            if (data_sent[0] != 0 && p1 == 0)
            {
                decide_fate();
            }

            if (p1 == 1)
            {
                p1 = 0;
                data_sent[0] = 0;
            }
        }

        void show_card()
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox15.Show();
            pictureBox16.Show();
            pictureBox17.Show();
            pictureBox18.Show();
            pictureBox19.Show();
            pictureBox20.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox23.Show();
            pictureBox24.Show();
            pictureBox25.Show();
            pictureBox26.Show();
            pictureBox27.Show();
            pictureBox28.Show();
            pictureBox29.Show();
            pictureBox30.Show();

            pictureBox31.Show();
            pictureBox33.Show();


            button1.Show();
        }

        void decide_fate()
         {
             if (data_recieve[0] != 0 && data_sent[0] != 0)
             {
                 win = find_winner();
             
                 data_sent[0] = 0;
                 data_recieve[0] = 0;              

                 if (win == 1)
                 {
                     wins++;
                     show_win_cards();
                     pictureBox31.ImageLocation = @"" + addr + "b1fv.png";
                     pictureBox33.ImageLocation = @"" + addr + "b2fv.png";
                     th.Abort();
                    /* th = new Thread(client);
                     th.Start();
                     th.IsBackground = true;*/
               
                 }
                 else
                 {
                     losts++;
                     show_win_cards();
                     pictureBox31.ImageLocation = @"" + addr + "b1fv.png";
                     pictureBox33.ImageLocation = @"" + addr + "b2fv.png";
                  //   th.Abort();
                     th = new Thread(server);
                     th.Start();
                     th.IsBackground = true;
                 }
             }

             else if ((data_recieve[0] != 0 && data_sent[0] == 0))// (win == 1 && data_sent[0] == 0))
             {
                 ///i have to play my turn so send data so will be client
                 th.Abort();
                 /*th = new Thread(client);
                 th.Start();
                 th.IsBackground = true;*/
             }

             else if (data_recieve[0] == 0 && data_sent[0]!=0)
             {
               ///i have played my turn so recieve data so will be server
                // th.Abort();
                 th = new Thread(server);
                 th.Start();
                 th.IsBackground = true;
             }

         }

        bool played_card()
         {
             if (trum_crd_no != 4)
             {
                 if (i_server == 0)
                 {
                     if (data_recieve[0] != 0)
                     {
                         flag = check_allow();
                     }
                     else
                     {
                         flag = true;
                     }

                     if (flag)
                     {
                         decide_fate();
                         return true;
                     }
                     else
                     {
                         MessageBox.Show("cant play this card...choose appropriate color");
                         return false;
                     }

                 }
                 else
                 {
                     MessageBox.Show("its not your turn to play...");
                     return false;
                 }
             }
             else
             {
                 MessageBox.Show("trum card colour not selected");
                 return false;
             }
         }
        
        bool check_allow()
        {
            int k;
            int mycrd, hiscrd;
            mycrd = (int)p1_card[I];
            hiscrd = (int)data_recieve[0];
            
            if(mycrd==29)
            {   
                mycrd+=2;
            }

            if(hiscrd==29)
            {   
                hiscrd+=2;
            }
            if(hiscrd%4==mycrd%4)
            {
                return true;
            }

            else
            {
                for (k = 0; k < 14; k++)
                {
                    if (k != I && p2_card[k] != 0)
                    {
                        mycrd=p1_card[k];
                        if (p1_card[k] == 29)
                        {
                            mycrd += 2;
                        }
                        if (mycrd % 4 == hiscrd % 4)
                        {
                         return false;
                        }
                    }
                }
                return true;
            }                            
        }

        int find_winner()
        {
            int mycrd,hiscrd;
            mycrd=(int)data_sent[0];
            hiscrd=(int)data_recieve[0];

            if (mycrd == 29)
            {
                mycrd += 2;
            }

            if (hiscrd == 29)
            {
                hiscrd += 2;
            }

            if (mycrd % 4 == hiscrd % 4)
            {
                if (mycrd < hiscrd)//i win as same colour
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            else if (mycrd % 4 == trum_crd_no)
            {
                return 1;
            }

            else if (hiscrd % 4 == trum_crd_no)
            {
                return 0;
            }

            else if (win == 1)//if i was prev winner then i am winner as both different colour
            {
                return 1;
            }

            else if (win == 0)
            {
                return 0;
            }
            else
            {
                MessageBox.Show("never enter here");
                return -1;
            }
        }

        void show_win_cards()
        {
            if (losts == 1)
            {
                pictureBox57.Invoke(new System.Action(() => pictureBox57.Show()));
            }

            else if (losts == 2)
            {
                pictureBox58.Invoke(new System.Action(() => pictureBox58.Show()));
            }

            else if (losts == 3)
            {
                pictureBox59.Invoke(new System.Action(() => pictureBox59.Show()));
            }

            else if (losts == 4)
            {
                pictureBox60.Invoke(new System.Action(() => pictureBox60.Show()));
            }

            else if (losts == 5)
            {
                pictureBox61.Invoke(new System.Action(() => pictureBox61.Show()));
            }

            else if (losts == 6)
            {
                pictureBox62.Invoke(new System.Action(() => pictureBox62.Show()));
            }

            else if (losts == 7)
            {
                pictureBox63.Invoke(new System.Action(() => pictureBox63.Show()));
            }

            else if (losts == 8)
            {
                pictureBox64.Invoke(new System.Action(() => pictureBox64.Show()));
            }

            else if (losts == 9)
            {
                pictureBox65.Invoke(new System.Action(() => pictureBox65.Show()));
            }

            else if (losts == 10)
            {
                pictureBox66.Invoke(new System.Action(() => pictureBox66.Show()));
            }

            else if (losts == 11)
            {
                pictureBox67.Invoke(new System.Action(() => pictureBox67.Show()));
            }

            else if (losts == 12)
            {
                pictureBox68.Invoke(new System.Action(() => pictureBox68.Show()));
            }

            else if (losts == 13)
            {
                pictureBox69.Invoke(new System.Action(() => pictureBox69.Show()));
            }

            else if (losts == 14)
            {
                pictureBox70.Invoke(new System.Action(() => pictureBox70.Show()));
            }

            else if (losts == 15)
            {
                pictureBox71.Invoke(new System.Action(() => pictureBox71.Show()));
            }

            if (wins == 1)
            {
                pictureBox38.Invoke(new System.Action(() => pictureBox38.Show()));
            }

            else if (wins == 2)
            {
                pictureBox39.Invoke(new System.Action(() => pictureBox39.Show()));
            }

            else if (wins == 3)
            {
                pictureBox40.Invoke(new System.Action(() => pictureBox40.Show()));
            }

            else if (wins == 4)
            {
                pictureBox41.Invoke(new System.Action(() => pictureBox41.Show()));
            }

            else if (wins == 5)
            {
                pictureBox42.Invoke(new System.Action(() => pictureBox42.Show()));
            }

            else if (wins == 6)
            {
                pictureBox43.Invoke(new System.Action(() => pictureBox43.Show()));
            }

            else if (wins == 7)
            {
                pictureBox44.Invoke(new System.Action(() => pictureBox44.Show()));
            }

            else if (wins == 8)
            {
                pictureBox45.Invoke(new System.Action(() => pictureBox45.Show()));
            }

            else if (wins == 9)
            {
                pictureBox46.Invoke(new System.Action(() => pictureBox46.Show()));
            }

            else if (wins == 10)
            {
                pictureBox47.Invoke(new System.Action(() => pictureBox47.Show()));
            }

            else if (wins == 11)
            {
                pictureBox48.Invoke(new System.Action(() => pictureBox48.Show()));
            }

            else if (wins == 12)
            {
                pictureBox49.Invoke(new System.Action(() => pictureBox49.Show()));
            }

            else if (wins == 13)
            {
                pictureBox50.Invoke(new System.Action(() => pictureBox50.Show()));
            }

            else if (wins == 14)
            {
                pictureBox51.Invoke(new System.Action(() => pictureBox51.Show()));
            }

            else if (wins == 15)
            {
                pictureBox52.Invoke(new System.Action(() => pictureBox52.Show()));
            }
            /////////////////////////////////hide player 2 cards
            if (crd_recv == 1)
            {
                pictureBox16.Invoke(new System.Action(() => pictureBox16.Hide()));
            }

            else if (crd_recv == 2)
            {
                pictureBox30.Invoke(new System.Action(() => pictureBox30.Hide()));
            }

            else if (crd_recv == 3)
            {
                pictureBox17.Invoke(new System.Action(() => pictureBox17.Hide()));
            }

            else if (crd_recv == 4)
            {
                pictureBox29.Invoke(new System.Action(() => pictureBox29.Hide()));
            }

            else if (crd_recv == 5)
            {
                pictureBox18.Invoke(new System.Action(() => pictureBox18.Hide()));
            }

            else if (crd_recv == 6)
            {
                pictureBox28.Invoke(new System.Action(() => pictureBox28.Hide()));
            }

            else if (crd_recv == 7)
            {
                pictureBox19.Invoke(new System.Action(() => pictureBox19.Hide()));
            }

            else if (crd_recv == 8)
            {
                pictureBox27.Invoke(new System.Action(() => pictureBox27.Hide()));
            }

            else if (crd_recv == 9)
            {
                pictureBox20.Invoke(new System.Action(() => pictureBox20.Hide()));
            }

            else if (crd_recv == 10)
            {
                pictureBox26.Invoke(new System.Action(() => pictureBox26.Hide()));
            }

            else if (crd_recv == 11)
            {
                pictureBox21.Invoke(new System.Action(() => pictureBox21.Hide()));
            }

            else if (crd_recv == 12)
            {
                pictureBox25.Invoke(new System.Action(() => pictureBox25.Hide()));
            }

            else if (crd_recv == 13)
            {
                pictureBox22.Invoke(new System.Action(() => pictureBox22.Hide()));
            }

            else if (crd_recv == 14)
            {
                pictureBox24.Invoke(new System.Action(() => pictureBox24.Hide()));
            }

            else if (crd_recv == 15)
            {
                pictureBox23.Invoke(new System.Action(() => pictureBox23.Hide()));
            }
            //////////////////////////////////////
            if (wins + losts == 15)
            {
                if (PL == 1 && wins >= 8)
                {
                    MessageBox.Show("Player 1 you win...!!!");
                }
                else if (PL == 1 && wins < 8)
                {
                    MessageBox.Show("Player 1 you lose...!!!");
                }

                if (PL == 2 && wins >= 7)
                {
                    MessageBox.Show("Player 2 you win...!!!");
                }
                else if (PL == 2 && wins < 7)
                {
                    MessageBox.Show("Player 2 you lose...!!!");
                }

                MessageBox.Show("Game over");
                Application.Restart();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Width += 10;
            button2.Height += 10;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Width -= 10;
            button2.Height -= 10;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Width += 10;
            button3.Height += 10;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Width -= 10;
            button3.Height -= 10;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Width += 10;
            button5.Height += 10;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Width -= 10;
            button5.Height -= 10;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Width += 10;
            button6.Height += 10;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Width -= 10;
            button6.Height -= 10;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Width += 10;
            button1.Height += 10;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Width -= 10;
            button1.Height -= 10;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Width += 10;
            button7.Height += 10;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Width -= 10;
            button7.Height -= 10;
        }
      
    }
}

