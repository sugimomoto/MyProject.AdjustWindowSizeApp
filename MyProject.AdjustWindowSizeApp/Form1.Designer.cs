namespace MyProject.AdjustWindowSizeApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainWindowHandleTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.WindowLeft_TextBox = new System.Windows.Forms.TextBox();
            this.WindowRight_TextBox = new System.Windows.Forms.TextBox();
            this.WindowTop_TextBox = new System.Windows.Forms.TextBox();
            this.WindowBottom_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(415, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.datagrid_Select);
            // 
            // MainWindowHandleTextBox
            // 
            this.MainWindowHandleTextBox.Location = new System.Drawing.Point(472, 51);
            this.MainWindowHandleTextBox.Name = "MainWindowHandleTextBox";
            this.MainWindowHandleTextBox.Size = new System.Drawing.Size(100, 19);
            this.MainWindowHandleTextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "GetWindowSize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WindowLeft_TextBox
            // 
            this.WindowLeft_TextBox.Location = new System.Drawing.Point(472, 216);
            this.WindowLeft_TextBox.Name = "WindowLeft_TextBox";
            this.WindowLeft_TextBox.Size = new System.Drawing.Size(100, 19);
            this.WindowLeft_TextBox.TabIndex = 4;
            // 
            // WindowRight_TextBox
            // 
            this.WindowRight_TextBox.Location = new System.Drawing.Point(472, 241);
            this.WindowRight_TextBox.Name = "WindowRight_TextBox";
            this.WindowRight_TextBox.Size = new System.Drawing.Size(100, 19);
            this.WindowRight_TextBox.TabIndex = 5;
            // 
            // WindowTop_TextBox
            // 
            this.WindowTop_TextBox.Location = new System.Drawing.Point(472, 267);
            this.WindowTop_TextBox.Name = "WindowTop_TextBox";
            this.WindowTop_TextBox.Size = new System.Drawing.Size(100, 19);
            this.WindowTop_TextBox.TabIndex = 6;
            // 
            // WindowBottom_TextBox
            // 
            this.WindowBottom_TextBox.Location = new System.Drawing.Point(472, 293);
            this.WindowBottom_TextBox.Name = "WindowBottom_TextBox";
            this.WindowBottom_TextBox.Size = new System.Drawing.Size(100, 19);
            this.WindowBottom_TextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WindowBottom_TextBox);
            this.Controls.Add(this.WindowTop_TextBox);
            this.Controls.Add(this.WindowRight_TextBox);
            this.Controls.Add(this.WindowLeft_TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainWindowHandleTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MainWindowHandleTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox WindowLeft_TextBox;
        private System.Windows.Forms.TextBox WindowRight_TextBox;
        private System.Windows.Forms.TextBox WindowTop_TextBox;
        private System.Windows.Forms.TextBox WindowBottom_TextBox;
    }
}

