namespace Sample.WinForm.Views
{
    partial class LatestView
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
            this.エリアID = new System.Windows.Forms.Label();
            this.AreaIdTextBox = new System.Windows.Forms.TextBox();
            this.MeasureDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MeasureValueText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // エリアID
            // 
            this.エリアID.AutoSize = true;
            this.エリアID.Location = new System.Drawing.Point(25, 13);
            this.エリアID.Name = "エリアID";
            this.エリアID.Size = new System.Drawing.Size(52, 15);
            this.エリアID.TabIndex = 0;
            this.エリアID.Text = "エリアID";
            // 
            // AreaIdTextBox
            // 
            this.AreaIdTextBox.Location = new System.Drawing.Point(97, 10);
            this.AreaIdTextBox.Name = "AreaIdTextBox";
            this.AreaIdTextBox.ReadOnly = true;
            this.AreaIdTextBox.Size = new System.Drawing.Size(140, 22);
            this.AreaIdTextBox.TabIndex = 1;
            // 
            // MeasureDateTextBox
            // 
            this.MeasureDateTextBox.Location = new System.Drawing.Point(97, 45);
            this.MeasureDateTextBox.Name = "MeasureDateTextBox";
            this.MeasureDateTextBox.ReadOnly = true;
            this.MeasureDateTextBox.Size = new System.Drawing.Size(140, 22);
            this.MeasureDateTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "計測日時";
            // 
            // MeasureValueText
            // 
            this.MeasureValueText.Location = new System.Drawing.Point(97, 81);
            this.MeasureValueText.Name = "MeasureValueText";
            this.MeasureValueText.ReadOnly = true;
            this.MeasureValueText.Size = new System.Drawing.Size(140, 22);
            this.MeasureValueText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "計測値";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(28, 127);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(233, 32);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 163);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(273, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "デバッグモード";
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 189);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MeasureValueText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MeasureDateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaIdTextBox);
            this.Controls.Add(this.エリアID);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label エリアID;
        private System.Windows.Forms.TextBox AreaIdTextBox;
        private System.Windows.Forms.TextBox MeasureDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MeasureValueText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}