using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;

namespace Kaihomaru
{
    public partial class Window : Form
    {
        private UPnP upnp;
        private IPAddress extIP;
        private IPAddress myIP;

        public Window(UPnP upnp)
        {
            this.upnp = upnp;
            extIP = upnp.GetExternalIPAddress();
            myIP = upnp.GetLocalIPAddress();

            InitializeComponent();

            if (File.Exists("Port number.txt"))
            {
                StreamReader sr = new StreamReader("Port number.txt", Encoding.GetEncoding("UTF-8"));

                port.Text = sr.ReadLine();

                String protocol = sr.ReadLine();

                if (String.IsNullOrEmpty(protocol)){
                    protocol = "TCP";
                }

                if (protocol.Equals("TCP"))
                {
                    tcp.Checked = true;
                }
                else
                {
                    udp.Checked = true;
                }

                sr.Close();
            }
        }

        private async void write(String text)
        {
            await Task.Run(() =>
            {
                log.Text = text;
                Thread.Sleep(5000);

                if (log.Text.Equals(text))
                {
                    log.Text = String.Empty;
                }
            });
        }

        private ushort[] getPortNumber()
        {
            try
            {
                return new ushort[] { ushort.Parse(port.Text) };
            } catch (Exception)
            {
                write("ポート番号が有効ではありません。");
                return null;
            }
        }

        private String getProtocol()
        {
            if (tcp.Checked)
            {
                return "TCP";
            }
            else
            {
                return "UDP";
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            ushort[] portNumber = getPortNumber();
            if (portNumber != null)
            {
                upnp.AddPortMapping(null, portNumber[0], getProtocol(), portNumber[0], myIP, true, "PortKaihomaru", 0);

                write("ポート(" + portNumber[0] + ")を開きました。");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            ushort[] portNumber = getPortNumber();
            if (portNumber != null)
            {
                try
                {
                    upnp.DeletePortMapping(null, portNumber[0], getProtocol());
                } catch (Exception)
                {
                    write("ポート(" + portNumber[0] + ")を閉じれませんでした。");
                    return;
                }

                write("ポート(" + portNumber[0] + ")を閉じました。");
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            list.Items.Clear();
            foreach (var v in upnp.GetGenericPortMappingEntries())
            {
                list.Items.Add(String.Format("[{0}] {1} : {2} -> {3} : {4} | {5}", v.Protocol, extIP, v.ExternalPort, v.InternalClient, v.InternalPort, v.PortMappingDescription));
            }
        }

        private void port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0' || e.KeyChar>'9' || port.Text.Length > 4)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!String.IsNullOrEmpty(port.Text))
            {
                FileStream fs = File.Create("Port number.txt");

                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("UTF-8"));

                sw.WriteLine(port.Text);

                if (tcp.Checked)
                {
                    sw.WriteLine("TCP");
                }
                else if (udp.Checked)
                {
                    sw.WriteLine("UDP");
                }

                sw.Close();
            }
            else
            {
                File.Delete("Port number.txt");
            }
        }
    }
}
