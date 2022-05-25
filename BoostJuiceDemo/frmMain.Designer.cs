namespace BoostJuiceDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequestBody = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWebhookIdKey = new System.Windows.Forms.TextBox();
            this.txtWebhookId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebhookKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWebhookKeyKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gvLogs = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webHookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteIpaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderExist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endpoint";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPoint.Location = new System.Drawing.Point(122, 18);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(997, 22);
            this.txtEndPoint.TabIndex = 1;
            this.txtEndPoint.Text = "https://boostjuice.vnsogroup.com/webhook/orders/status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "RequestBody";
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestBody.Location = new System.Drawing.Point(122, 71);
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.Size = new System.Drawing.Size(997, 116);
            this.txtRequestBody.TabIndex = 3;
            this.txtRequestBody.Text = "{\n    \"webOrderID\": \"DGIXKUX5\",\n    \"status\": \"sended\",\n    \"user\": \"tool test\"\n}" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Header";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Key";
            // 
            // txtWebhookIdKey
            // 
            this.txtWebhookIdKey.Location = new System.Drawing.Point(163, 199);
            this.txtWebhookIdKey.Name = "txtWebhookIdKey";
            this.txtWebhookIdKey.Size = new System.Drawing.Size(153, 22);
            this.txtWebhookIdKey.TabIndex = 6;
            this.txtWebhookIdKey.Text = "X-VNSO-Webhook-Id";
            // 
            // txtWebhookId
            // 
            this.txtWebhookId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebhookId.Location = new System.Drawing.Point(396, 199);
            this.txtWebhookId.Name = "txtWebhookId";
            this.txtWebhookId.Size = new System.Drawing.Size(723, 22);
            this.txtWebhookId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Value";
            // 
            // txtWebhookKey
            // 
            this.txtWebhookKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebhookKey.Location = new System.Drawing.Point(396, 236);
            this.txtWebhookKey.Name = "txtWebhookKey";
            this.txtWebhookKey.Size = new System.Drawing.Size(723, 22);
            this.txtWebhookKey.TabIndex = 12;
            this.txtWebhookKey.Text = "bLWbXQDkU3I7Mg93xOnsWy1Dkc5gIQkk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value";
            // 
            // txtWebhookKeyKey
            // 
            this.txtWebhookKeyKey.Location = new System.Drawing.Point(163, 236);
            this.txtWebhookKeyKey.Name = "txtWebhookKeyKey";
            this.txtWebhookKeyKey.Size = new System.Drawing.Size(153, 22);
            this.txtWebhookKeyKey.TabIndex = 10;
            this.txtWebhookKeyKey.Text = "X-VNSO-Webhook-Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Response Status";
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(122, 284);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(194, 44);
            this.btnExcute.TabIndex = 15;
            this.btnExcute.Text = "Excute";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(151, 353);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(968, 20);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Chưa gọi API";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Logs";
            // 
            // gvLogs
            // 
            this.gvLogs.AllowUserToAddRows = false;
            this.gvLogs.AllowUserToDeleteRows = false;
            this.gvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.webHookId,
            this.webOrderId,
            this.status,
            this.user,
            this.remoteIpaddress,
            this.createdOn,
            this.orderExist});
            this.gvLogs.Location = new System.Drawing.Point(15, 430);
            this.gvLogs.Name = "gvLogs";
            this.gvLogs.RowHeadersWidth = 51;
            this.gvLogs.RowTemplate.Height = 24;
            this.gvLogs.Size = new System.Drawing.Size(1118, 278);
            this.gvLogs.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(833, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "UpdatedAt: ";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedAt.Location = new System.Drawing.Point(917, 394);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(98, 16);
            this.lblUpdatedAt.TabIndex = 20;
            this.lblUpdatedAt.Text = "lblUpdatedAt";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // webHookId
            // 
            this.webHookId.HeaderText = "webHookId";
            this.webHookId.MinimumWidth = 6;
            this.webHookId.Name = "webHookId";
            this.webHookId.Width = 125;
            // 
            // webOrderId
            // 
            this.webOrderId.HeaderText = "webOrderId";
            this.webOrderId.MinimumWidth = 6;
            this.webOrderId.Name = "webOrderId";
            this.webOrderId.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // user
            // 
            this.user.HeaderText = "user";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.Width = 125;
            // 
            // remoteIpaddress
            // 
            this.remoteIpaddress.HeaderText = "remoteIpaddress";
            this.remoteIpaddress.MinimumWidth = 6;
            this.remoteIpaddress.Name = "remoteIpaddress";
            this.remoteIpaddress.Width = 125;
            // 
            // createdOn
            // 
            this.createdOn.HeaderText = "createdOn";
            this.createdOn.MinimumWidth = 6;
            this.createdOn.Name = "createdOn";
            this.createdOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createdOn.Width = 125;
            // 
            // orderExist
            // 
            this.orderExist.HeaderText = "orderExist";
            this.orderExist.MinimumWidth = 6;
            this.orderExist.Name = "orderExist";
            this.orderExist.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 720);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gvLogs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWebhookKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWebhookKeyKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWebhookId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWebhookIdKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRequestBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Demo call webhook";
            ((System.ComponentModel.ISupportInitialize)(this.gvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtRequestBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWebhookIdKey;
        private System.Windows.Forms.TextBox txtWebhookId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebhookKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWebhookKeyKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvLogs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn webHookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn webOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteIpaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderExist;
    }
}

