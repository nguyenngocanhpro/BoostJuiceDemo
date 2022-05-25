using BoostJuiceDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace BoostJuiceDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtWebhookId.Text = Guid.NewGuid().ToString();
            lblUpdatedAt.Text = DateTime.Now.ToString();
        }

        private async void btnExcute_Click(object sender, EventArgs e)
        {
            gvLogs.Rows.Clear();
            
            var LOG_URL = "https://boostjuice.vnsogroup.com/webhook/orders/logs";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add(txtWebhookIdKey.Text, txtWebhookId.Text);
            client.DefaultRequestHeaders.Add(txtWebhookKeyKey.Text, txtWebhookKey.Text);
            var content = new StringContent(txtRequestBody.Text, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(txtEndPoint.Text, content);
            lblResult.Text = response.IsSuccessStatusCode ? "Success" : "Failed";
            txtWebhookId.Text = Guid.NewGuid().ToString();

            client.DefaultRequestHeaders.Clear();
            var responseLog = await client.GetAsync(LOG_URL);
            if (responseLog.IsSuccessStatusCode)
            {
                var logResult = await responseLog.Content.ReadAsStringAsync();
                var logModel = JsonConvert.DeserializeObject<List<LogModel>>(logResult);

                if (logModel != null && logModel.Any())
                {
                    foreach (var item in logModel)
                    {
                        gvLogs.Rows.Add(item.id, item.webHookId, item.webOrderId, item.status, item.user, item.remoteIpaddress, item.createdOn, item.orderExist);
                    }
                }
                lblUpdatedAt.Text = DateTime.Now.ToString();
            }
        }
    }
}
