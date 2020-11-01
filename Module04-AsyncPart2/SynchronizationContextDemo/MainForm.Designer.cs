namespace SynchronizationContextDemo
{
    partial class MainForm
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
            this.btnAsync = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsyncNested = new System.Windows.Forms.Button();
            this.btnSyncNested = new System.Windows.Forms.Button();
            this.btnSyncNestedWithConfigureAwait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(12, 12);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(520, 100);
            this.btnAsync.TabIndex = 0;
            this.btnAsync.Text = "btnAsync";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(559, 12);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(967, 577);
            this.tbLog.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 127);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(520, 100);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "btnSync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsyncNested
            // 
            this.btnAsyncNested.Location = new System.Drawing.Point(12, 245);
            this.btnAsyncNested.Name = "btnAsyncNested";
            this.btnAsyncNested.Size = new System.Drawing.Size(520, 99);
            this.btnAsyncNested.TabIndex = 3;
            this.btnAsyncNested.Text = "btnAsyncNested";
            this.btnAsyncNested.UseVisualStyleBackColor = true;
            this.btnAsyncNested.Click += new System.EventHandler(this.btnAsyncNested_Click);
            // 
            // btnSyncNested
            // 
            this.btnSyncNested.Location = new System.Drawing.Point(12, 367);
            this.btnSyncNested.Name = "btnSyncNested";
            this.btnSyncNested.Size = new System.Drawing.Size(520, 96);
            this.btnSyncNested.TabIndex = 4;
            this.btnSyncNested.Text = "btnSyncNested";
            this.btnSyncNested.UseVisualStyleBackColor = true;
            this.btnSyncNested.Click += new System.EventHandler(this.btnSyncNested_Click);
            // 
            // btnSyncNestedWithConfigureAwait
            // 
            this.btnSyncNestedWithConfigureAwait.Location = new System.Drawing.Point(12, 493);
            this.btnSyncNestedWithConfigureAwait.Name = "btnSyncNestedWithConfigureAwait";
            this.btnSyncNestedWithConfigureAwait.Size = new System.Drawing.Size(520, 96);
            this.btnSyncNestedWithConfigureAwait.TabIndex = 5;
            this.btnSyncNestedWithConfigureAwait.Tag = "";
            this.btnSyncNestedWithConfigureAwait.Text = "btnSyncNestedWithConfigureAwait";
            this.btnSyncNestedWithConfigureAwait.UseVisualStyleBackColor = true;
            this.btnSyncNestedWithConfigureAwait.Click += new System.EventHandler(this.btnSyncNestedWithConfigureAwait_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 601);
            this.Controls.Add(this.btnSyncNestedWithConfigureAwait);
            this.Controls.Add(this.btnSyncNested);
            this.Controls.Add(this.btnAsyncNested);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnAsync);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsyncNested;
        private System.Windows.Forms.Button btnSyncNested;
        private System.Windows.Forms.Button btnSyncNestedWithConfigureAwait;
    }
}

