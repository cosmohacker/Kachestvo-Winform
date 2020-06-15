namespace Kachestvo.Forms.Database
{
    partial class DatabaseTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseTest));
            this.dataComments = new System.Windows.Forms.DataGridView();
            this.dataPrevious = new System.Windows.Forms.DataGridView();
            this.dataNext = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendComment = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNext)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataComments
            // 
            this.dataComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataComments.Location = new System.Drawing.Point(12, 16);
            this.dataComments.Name = "dataComments";
            this.dataComments.Size = new System.Drawing.Size(492, 227);
            this.dataComments.TabIndex = 73;
            // 
            // dataPrevious
            // 
            this.dataPrevious.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrevious.Location = new System.Drawing.Point(261, 249);
            this.dataPrevious.Name = "dataPrevious";
            this.dataPrevious.Size = new System.Drawing.Size(243, 150);
            this.dataPrevious.TabIndex = 74;
            // 
            // dataNext
            // 
            this.dataNext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNext.Location = new System.Drawing.Point(12, 249);
            this.dataNext.Name = "dataNext";
            this.dataNext.Size = new System.Drawing.Size(243, 150);
            this.dataNext.TabIndex = 75;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 405);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(492, 23);
            this.btnRefresh.TabIndex = 76;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSendComment);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 237);
            this.panel1.TabIndex = 77;
            // 
            // btnSendComment
            // 
            this.btnSendComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendComment.Location = new System.Drawing.Point(209, 198);
            this.btnSendComment.Name = "btnSendComment";
            this.btnSendComment.Size = new System.Drawing.Size(75, 23);
            this.btnSendComment.TabIndex = 3;
            this.btnSendComment.Text = "ADD";
            this.btnSendComment.UseVisualStyleBackColor = true;
            this.btnSendComment.Click += new System.EventHandler(this.btnSendComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(4, 83);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(481, 109);
            this.txtComment.TabIndex = 2;
            this.txtComment.Text = "Comment";
            this.txtComment.Enter += new System.EventHandler(this.txtComment_Enter);
            this.txtComment.Leave += new System.EventHandler(this.txtComment_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(481, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name & Surname";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERT COMMENT";
            // 
            // DatabaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(516, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataNext);
            this.Controls.Add(this.dataPrevious);
            this.Controls.Add(this.dataComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseTest";
            this.Text = "Database Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNext)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataComments;
        private System.Windows.Forms.DataGridView dataPrevious;
        private System.Windows.Forms.DataGridView dataNext;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendComment;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}