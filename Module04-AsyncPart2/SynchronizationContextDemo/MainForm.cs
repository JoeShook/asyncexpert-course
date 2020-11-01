using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynchronizationContextDemo
{
    public partial class MainForm : Form
    {
        private static readonly string Url = "http://postman-echo.com/delay/1";
        public MainForm()
        {
            InitializeComponent();
        }

        // Runs OK
        private async void btnAsync_Click(object sender, EventArgs e)
        {
            tbLog.Clear();

            using (var client = new HttpClient())
            {
                DumpThread("btnAsync_Click before await");
                var result = await client.GetStringAsync(Url);
                tbLog.AppendText($"{result}{Environment.NewLine}");
                DumpThread("btnAsync_Click after await");
            }
        }


        // Blocks UI but runs OK
        private void btnSync_Click(object sender, EventArgs e)
        {
            tbLog.Clear();

            using (var client = new HttpClient())
            {
                DumpThread("btnSync_Click before await");
                var result = client.GetStringAsync(Url).Result;
                tbLog.AppendText($"{result}{Environment.NewLine}");
                DumpThread("btnSync_Click after await");
            }
        }

        
        // Runs OK
        private async void btnAsyncNested_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
            DumpThread("btnAsyncNested_Click before await");
            var result = await GetJsonAsync(Url);
            tbLog.AppendText($"{result}{Environment.NewLine}");
            DumpThread("btnAsyncNested_Click after await");
        }

        // Deadlocks
        private void btnSyncNested_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
            DumpThread("btnSyncNested_Click before await");
            var result = GetJsonAsync(Url).Result;
            tbLog.AppendText($"{result}{Environment.NewLine}");
            DumpThread("btnSyncNested_Click after await");
        }

        private void btnSyncNestedWithConfigureAwait_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
            DumpThread("btnSyncNested_Click before await");
            var result = GetJsonAsyncConfigureAwait(Url).Result;
            tbLog.AppendText($"{result}{Environment.NewLine}");
            DumpThread("btnSyncNested_Click after await");

        }

        private async Task<string> GetJsonAsync(string url)
        {
            using (var client = new HttpClient())
            {
                DumpThread("GetJsonAsync before await");
                var result = await client.GetStringAsync(url);
                DumpThread("GetJsonAsync after await");

                return result;
            }
        }

        private async Task<string> GetJsonAsyncConfigureAwait(string url)
        {
            using (var client = new HttpClient())
            {
                DumpThread("GetJsonAsync before await");
                var result = await client.GetStringAsync(url)
                    .ConfigureAwait(false);
                //DumpThread("GetJsonAsync after await");

                return result;
            }
        }

        private void DumpThread(string label)
        {
            var thread = Thread.CurrentThread;
            tbLog.AppendText(
                $"[{DateTime.Now:hh:mm:ss.ffff}] {label} TID:{thread.ManagedThreadId} pooled:{thread.IsThreadPoolThread} \r\n");
        }
    }
}
