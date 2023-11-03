namespace Kaihomaru
{
    partial class Window
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.open = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.tcp = new System.Windows.Forms.RadioButton();
            this.udp = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.StatusStrip();
            this.log = new System.Windows.Forms.ToolStripStatusLabel();
            this.label = new System.Windows.Forms.Label();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.open.Location = new System.Drawing.Point(116, 5);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(256, 23);
            this.open.TabIndex = 3;
            this.open.Text = "ポートを開く";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(73, 7);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(37, 19);
            this.port.TabIndex = 0;
            this.port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_KeyPress);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(116, 34);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(256, 23);
            this.close.TabIndex = 4;
            this.close.Text = "ポートを閉じる";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tcp
            // 
            this.tcp.AutoSize = true;
            this.tcp.Checked = true;
            this.tcp.Location = new System.Drawing.Point(12, 30);
            this.tcp.Name = "tcp";
            this.tcp.Size = new System.Drawing.Size(45, 16);
            this.tcp.TabIndex = 1;
            this.tcp.TabStop = true;
            this.tcp.Text = "TCP";
            this.tcp.UseVisualStyleBackColor = true;
            // 
            // udp
            // 
            this.udp.AutoSize = true;
            this.udp.Location = new System.Drawing.Point(63, 30);
            this.udp.Name = "udp";
            this.udp.Size = new System.Drawing.Size(46, 16);
            this.udp.TabIndex = 2;
            this.udp.TabStop = true;
            this.udp.Text = "UDP";
            this.udp.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 12;
            this.list.Location = new System.Drawing.Point(12, 62);
            this.list.Name = "list";
            this.list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list.Size = new System.Drawing.Size(360, 64);
            this.list.TabIndex = 5;
            this.list.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.log});
            this.status.Location = new System.Drawing.Point(0, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(384, 22);
            this.status.TabIndex = 6;
            // 
            // log
            // 
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 17);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 12);
            this.label.TabIndex = 7;
            this.label.Text = "ポート番号";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label);
            this.Controls.Add(this.status);
            this.Controls.Add(this.list);
            this.Controls.Add(this.udp);
            this.Controls.Add(this.tcp);
            this.Controls.Add(this.close);
            this.Controls.Add(this.port);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Window";
            this.Text = "ポート開放丸";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.RadioButton tcp;
        private System.Windows.Forms.RadioButton udp;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel log;
        private System.Windows.Forms.Label label;
    }
}

