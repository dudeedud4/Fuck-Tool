using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Fiddler;
using System.Threading;
using ReaperTheme;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharp
{
    public partial class Form1 : ReaperForm
    {
        int port = 8877;
        List<Fiddler.Session> oAllSessions = new List<Fiddler.Session>();
        public Form1()
        {InitializeComponent();}
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {FiddlerApplication.Shutdown();}
        private void pictureBox1_Click(object sender, EventArgs e)
        {Process.Start("http://hackandmodz.net");}
        private void reaperLabel1_Click(object sender, EventArgs e)
        {Process.Start("http://hackandmodz.net");}
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        private void reaperButton1_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("");//Le nom de l'.exe du tool
            SetWindowText(p.MainWindowHandle, " - Fucked By HackAndModz.Net !");//Le nom de la fentre voulu
            Fiddler.FiddlerApplication.BeforeRequest += delegate(Fiddler.Session oS)
            {
                oAllSessions.Add(oS);
                if (oS.url.Contains("")) //Lien de la requette web pour vérifier si l'username + password est ok
                {
                    oS.fullUrl = ""; //Lien de la réponse valide
                }
            };
            FiddlerCoreStartupFlags oFCSF = FiddlerCoreStartupFlags.Default;
            Fiddler.FiddlerApplication.Startup(port, oFCSF);
            reaperLabel2.Text = "Fucked : oui";
            MessageBox.Show("Vous pouvez vous connectez avec le tool !","Information");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("1 - Lancer le FuckTool , activer le bypass en appuyant sur le bouton et Greg's Grabber se lancera et il faudras vous connectez","Instructions");
        }
        }
}
