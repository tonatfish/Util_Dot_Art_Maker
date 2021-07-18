
namespace Util_Dot_Art_Maker
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureAddBtn = new System.Windows.Forms.Button();
            this.pictureLoaded = new System.Windows.Forms.PictureBox();
            this.transformedTextBox = new System.Windows.Forms.TextBox();
            this.dotForm = new System.Windows.Forms.GroupBox();
            this.resizeWidthLabel = new System.Windows.Forms.Label();
            this.resizeHightLabel = new System.Windows.Forms.Label();
            this.resizeWidthInput = new System.Windows.Forms.TextBox();
            this.resizeHeightInput = new System.Windows.Forms.TextBox();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoaded)).BeginInit();
            this.dotForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAddBtn
            // 
            this.pictureAddBtn.Location = new System.Drawing.Point(700, 12);
            this.pictureAddBtn.Name = "pictureAddBtn";
            this.pictureAddBtn.Size = new System.Drawing.Size(88, 40);
            this.pictureAddBtn.TabIndex = 0;
            this.pictureAddBtn.Text = "Add picture";
            this.pictureAddBtn.UseVisualStyleBackColor = true;
            this.pictureAddBtn.Click += new System.EventHandler(this.pictureAddBtn_Click);
            // 
            // pictureLoaded
            // 
            this.pictureLoaded.Location = new System.Drawing.Point(12, 12);
            this.pictureLoaded.Name = "pictureLoaded";
            this.pictureLoaded.Size = new System.Drawing.Size(320, 320);
            this.pictureLoaded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoaded.TabIndex = 1;
            this.pictureLoaded.TabStop = false;
            // 
            // transformedTextBox
            // 
            this.transformedTextBox.Location = new System.Drawing.Point(374, 12);
            this.transformedTextBox.Multiline = true;
            this.transformedTextBox.Name = "transformedTextBox";
            this.transformedTextBox.Size = new System.Drawing.Size(320, 320);
            this.transformedTextBox.TabIndex = 2;
            // 
            // dotForm
            // 
            this.dotForm.Controls.Add(this.thresholdBar);
            this.dotForm.Controls.Add(this.resizeHeightInput);
            this.dotForm.Controls.Add(this.resizeWidthInput);
            this.dotForm.Controls.Add(this.resizeHightLabel);
            this.dotForm.Controls.Add(this.resizeWidthLabel);
            this.dotForm.Location = new System.Drawing.Point(12, 338);
            this.dotForm.Name = "dotForm";
            this.dotForm.Size = new System.Drawing.Size(320, 209);
            this.dotForm.TabIndex = 3;
            this.dotForm.TabStop = false;
            this.dotForm.Text = "Dot Tranform Control";
            // 
            // resizeWidthLabel
            // 
            this.resizeWidthLabel.AutoSize = true;
            this.resizeWidthLabel.Location = new System.Drawing.Point(6, 18);
            this.resizeWidthLabel.Name = "resizeWidthLabel";
            this.resizeWidthLabel.Size = new System.Drawing.Size(73, 12);
            this.resizeWidthLabel.TabIndex = 0;
            this.resizeWidthLabel.Text = "Resize Width: ";
            // 
            // resizeHightLabel
            // 
            this.resizeHightLabel.AutoSize = true;
            this.resizeHightLabel.Location = new System.Drawing.Point(6, 46);
            this.resizeHightLabel.Name = "resizeHightLabel";
            this.resizeHightLabel.Size = new System.Drawing.Size(72, 12);
            this.resizeHightLabel.TabIndex = 1;
            this.resizeHightLabel.Text = "Resize Height:";
            // 
            // resizeWidthInput
            // 
            this.resizeWidthInput.Location = new System.Drawing.Point(85, 15);
            this.resizeWidthInput.Name = "resizeWidthInput";
            this.resizeWidthInput.Size = new System.Drawing.Size(100, 22);
            this.resizeWidthInput.TabIndex = 2;
            // 
            // resizeHeightInput
            // 
            this.resizeHeightInput.Location = new System.Drawing.Point(84, 43);
            this.resizeHeightInput.Name = "resizeHeightInput";
            this.resizeHeightInput.Size = new System.Drawing.Size(100, 22);
            this.resizeHeightInput.TabIndex = 3;
            // 
            // thresholdBar
            // 
            this.thresholdBar.LargeChange = 20;
            this.thresholdBar.Location = new System.Drawing.Point(80, 93);
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(104, 45);
            this.thresholdBar.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.dotForm);
            this.Controls.Add(this.transformedTextBox);
            this.Controls.Add(this.pictureLoaded);
            this.Controls.Add(this.pictureAddBtn);
            this.Name = "MainWindow";
            this.Text = "Util_Dot_Art_Maker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoaded)).EndInit();
            this.dotForm.ResumeLayout(false);
            this.dotForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pictureAddBtn;
        private System.Windows.Forms.PictureBox pictureLoaded;
        private System.Windows.Forms.TextBox transformedTextBox;
        private System.Windows.Forms.GroupBox dotForm;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.TextBox resizeHeightInput;
        private System.Windows.Forms.TextBox resizeWidthInput;
        private System.Windows.Forms.Label resizeHightLabel;
        private System.Windows.Forms.Label resizeWidthLabel;
    }
}

