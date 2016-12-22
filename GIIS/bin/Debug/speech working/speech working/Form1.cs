using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic.PowerPacks;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        SpeechRecognizer sRecog = new SpeechRecognizer();
        Process pr = new Process();
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To GIIS Voice Command's");

            sRecog.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sRecog_SpeechRecognized);
            Choices sList = new Choices();
            sList.Add(new string[] { "hello", "test", "setup touch mode", "exit", "touch mode" , "hands free mode" , "stop script" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                sRecognize.Recognize();
            }
            catch
            {
                return;
            }
        }

       void sRecog_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
         //  textBox2.AppendText(e.Result.Text.ToString() + " ");
        }

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "exit")
            {
                foreach (Process p in Process.GetProcesses())
                {
                    string n = p.ProcessName.ToLower();
                    if (n == "piefree") p.Kill();
                }
                Application.Exit();
            }

            else if (e.Result.Text == "touch mode")
            {
                foreach (Process p in Process.GetProcesses())
                {
                    string n = p.ProcessName.ToLower();
                    if (n == "piefree") p.Kill();
                }

                //Process.Start(@"C:\Users\Sanjay\Desktop\GIIS FORMS\GIIS\GIIS\bin\Debug\WiimoteWhiteboard\WiimoteWhiteboard v0.3.exe");
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString() + "; ";
                MessageBox.Show("There seems to be some problem with the OS installation. Please Re-install the os or try again on some other PC");
                //Process.Start("osk.exe");
            }

            else if (e.Result.Text == "hands free mode")
            {
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString() +"; ";
                foreach (Process p in Process.GetProcesses())
                {
                    string n = p.ProcessName.ToLower();
                    if (n == "piefree") p.Kill();
                }
                MessageBox.Show("Control mouse with your right hand." +Environment.NewLine +"Move left hand forward for left click & backwards for right click." +Environment.NewLine +"Move left hand above your head for double click and move sideways for click and hold");
                Process.Start(@"C:\Users\Sanjay\Desktop\GIIS FORMS\GIIS\GIIS\bin\Debug\glovepie\runhands.bat");
                
                timer1.Enabled = true;
            }

            else if (e.Result.Text =="stop script")
            {
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString() + "; ";
                    foreach (Process p in Process.GetProcesses())
                    {
                        string n = p.ProcessName.ToLower();
                        if (n == "piefree") p.Kill();
                    }
                          
            }

            else if (e.Result.Text == "setup touch mode")
            {

                foreach (Process p in Process.GetProcesses())
                {
                    string n = p.ProcessName.ToLower();
                    if (n == "piefree") p.Kill();
                }
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString() + "; ";

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
            }

            else
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString() + "; ";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SendKeys.Send("%{F4}");
        }
       
    }
}
