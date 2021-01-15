using System;
using System.IO;
using System.Net;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace Railway_Admin
{
    public  partial  class BackGroundProcess : Form
    {
       
        public static  System.Timers.Timer aTimer;
        public static int j = 0;
      

        public static Label label;
        public BackGroundProcess()
        {
            InitializeComponent();
            ipJson.Text = "JSON IP address : Loading ....";
            ipServer.Text = "Server IP address: Loading ....";

        }

        private void BackGroundProcess_Load(object sender, EventArgs e)
        {

        }

        private void btnJsonStart_Click(object sender, EventArgs e)
        {
            EnableTimer();
            /**
            aTimer = new System.Timers.Timer(20* 1000); //one hour in milliseconds
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();
            **/
           
            btnJsonStart.Enabled = false;

        }
        private void EnableTimer()
        {
            System.Timers.Timer raiseTimer = new System.Timers.Timer(20 * 1000);
           
            raiseTimer.Elapsed += RaiseTimerEvent;
            raiseTimer.AutoReset = true;
            raiseTimer.Enabled = true;
        }
        private void RaiseTimerEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            String SysIP;
            String JsonIP;
            String ab = "a", bc = "a";
            try
            {

                //______________________ CHECKING IP FROM SYSTEM __________________________
                String address = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    address = stream.ReadToEnd();
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);
                SysIP = address.Trim();
                //ipServer.Text = SysIP;
                //MessageBox.Show("System IP " + address);

                //______________________ CHECKING IP FROM JSON __________________________

                String url = "https://hits-rail.herokuapp.com/static/data.json";
                System.Net.WebClient client = new System.Net.WebClient();
                String json = client.DownloadString(url);

                String ipPas = null;

                for (int i = 8; i < json.Length - 2; i++)
                {
                    ipPas = ipPas + json[i];
                }
                JsonIP = ipPas.Trim();
              
                /**
                 * If any space related error
               
                MessageBox.Show("Json IP " + ipPas.Equals(address));
                MessageBox.Show(ipPas+"\n"+address);

            **/
                //______________________ CHECKING SIMILARITY __________________________

                if (SysIP.Equals(JsonIP)==false)
                {
                    j++;
                    if (j == 1 || j == 10)
                    {
                       
                        MessageBox.Show("SERVER IP ADDRESS HAS CHANGED \n \n \n Please change the IP address in Website \n \n \n New IP : " + SysIP + "\n\nCopy the ip from above TextBox and \n\nPaste it in the below site and click Submit.", "WARNING !.. SERVER IP CHANGED....", MessageBoxButtons.OK);
                        //MessageBox.Show("They are not equal pls change !"+j   );
                    }
                    MessageBox.Show("dfd "+JsonIP+"\n"+SysIP);
                    SoundPlayer sndplayr = new
                                SoundPlayer(Railway_Admin.Properties.Resource1.Alien_AlarmDrum_KevanGC_893953959);
                    sndplayr.Play();

                }
                else
                {
                    j = 0;
                    //MessageBox.Show("They are  equal  !");
                }
            }
            catch (Exception ax)
            {
                Console.WriteLine(ax);
            }
            
        }
        public static void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
/**
 * 
 * System.IO.Stream str = Properties.Resources.mySoundFile;
System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
snd.Play();
WebRequest request = WebRequest.Create("http://csharpindepth.com/asd");
        try
        {
            using (WebResponse response = request.GetResponse())
            {
                Console.WriteLine("Won't get here");
            }
        }
        catch (WebException e)
        {
            using (WebResponse response = e.Response)
            {
                HttpWebResponse httpResponse = (HttpWebResponse) response;
                Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                using (Stream data = response.GetResponseStream())
                using (var reader = new StreamReader(data))
                {
                    string text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
        }
    **/
