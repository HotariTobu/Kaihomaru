using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaihomaru
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Start s = new Start();

            Task.Run(() =>
            {
                Application.Run(s);
            });

            UPnP upnp = UPnP.FindUPnPWanService();

            s.exit = false;
            Application.Exit();

            if (upnp == null)
            {
                MessageBox.Show("UPnP Wan Serviceが見つかりませんでした。\r\nネットワーク環境を確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Window(upnp));
        }
    }
}
