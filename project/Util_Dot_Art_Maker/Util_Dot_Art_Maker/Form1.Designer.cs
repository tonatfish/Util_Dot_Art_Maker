
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
            this.components = new System.ComponentModel.Container();
            this.pictureAddBtn = new System.Windows.Forms.Button();
            this.pictureLoaded = new System.Windows.Forms.PictureBox();
            this.transformedTextBox = new System.Windows.Forms.TextBox();
            this.dotForm = new System.Windows.Forms.GroupBox();
            this.renderLabel = new System.Windows.Forms.Label();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.processMethodRadio_fs = new System.Windows.Forms.RadioButton();
            this.processMethodRadio_thresh = new System.Windows.Forms.RadioButton();
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.resizeHeightInput = new System.Windows.Forms.TextBox();
            this.resizeWidthInput = new System.Windows.Forms.TextBox();
            this.resizeHightLabel = new System.Windows.Forms.Label();
            this.resizeWidthLabel = new System.Windows.Forms.Label();
            this.imageSaveBtn = new System.Windows.Forms.Button();
            this.txtSaveBtn = new System.Windows.Forms.Button();
            this.gifTimer = new System.Windows.Forms.Timer(this.components);
            this.videoForm = new System.Windows.Forms.GroupBox();
            this.fpsText = new System.Windows.Forms.TextBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.endSecText = new System.Windows.Forms.TextBox();
            this.middleLabel2 = new System.Windows.Forms.Label();
            this.endMinText = new System.Windows.Forms.TextBox();
            this.videoEndLabel = new System.Windows.Forms.Label();
            this.startSecText = new System.Windows.Forms.TextBox();
            this.middleLabel = new System.Windows.Forms.Label();
            this.startMinText = new System.Windows.Forms.TextBox();
            this.VideoStartLabel = new System.Windows.Forms.Label();
            this.videoLoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoaded)).BeginInit();
            this.dotForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            this.videoForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureAddBtn
            // 
            this.pictureAddBtn.Location = new System.Drawing.Point(848, 12);
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
            this.transformedTextBox.Font = new System.Drawing.Font("新細明體", 6F);
            this.transformedTextBox.Location = new System.Drawing.Point(372, 12);
            this.transformedTextBox.Multiline = true;
            this.transformedTextBox.Name = "transformedTextBox";
            this.transformedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transformedTextBox.Size = new System.Drawing.Size(470, 470);
            this.transformedTextBox.TabIndex = 2;
            // 
            // dotForm
            // 
            this.dotForm.Controls.Add(this.renderLabel);
            this.dotForm.Controls.Add(this.ThresholdLabel);
            this.dotForm.Controls.Add(this.processMethodRadio_fs);
            this.dotForm.Controls.Add(this.processMethodRadio_thresh);
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
            // renderLabel
            // 
            this.renderLabel.AutoSize = true;
            this.renderLabel.Location = new System.Drawing.Point(6, 145);
            this.renderLabel.Name = "renderLabel";
            this.renderLabel.Size = new System.Drawing.Size(42, 12);
            this.renderLabel.TabIndex = 8;
            this.renderLabel.Text = "Render:";
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(6, 94);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(79, 12);
            this.ThresholdLabel.TabIndex = 7;
            this.ThresholdLabel.Text = "Threshold: 50%";
            // 
            // processMethodRadio_fs
            // 
            this.processMethodRadio_fs.AutoSize = true;
            this.processMethodRadio_fs.Location = new System.Drawing.Point(232, 143);
            this.processMethodRadio_fs.Name = "processMethodRadio_fs";
            this.processMethodRadio_fs.Size = new System.Drawing.Size(67, 16);
            this.processMethodRadio_fs.TabIndex = 6;
            this.processMethodRadio_fs.Text = "Dither FS";
            this.processMethodRadio_fs.UseVisualStyleBackColor = true;
            // 
            // processMethodRadio_thresh
            // 
            this.processMethodRadio_thresh.AutoSize = true;
            this.processMethodRadio_thresh.Checked = true;
            this.processMethodRadio_thresh.Location = new System.Drawing.Point(97, 143);
            this.processMethodRadio_thresh.Name = "processMethodRadio_thresh";
            this.processMethodRadio_thresh.Size = new System.Drawing.Size(87, 16);
            this.processMethodRadio_thresh.TabIndex = 5;
            this.processMethodRadio_thresh.TabStop = true;
            this.processMethodRadio_thresh.Text = "Dither Thresh";
            this.processMethodRadio_thresh.UseVisualStyleBackColor = true;
            // 
            // thresholdBar
            // 
            this.thresholdBar.LargeChange = 20;
            this.thresholdBar.Location = new System.Drawing.Point(97, 81);
            this.thresholdBar.Maximum = 255;
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(202, 45);
            this.thresholdBar.TabIndex = 4;
            this.thresholdBar.Value = 128;
            this.thresholdBar.Scroll += new System.EventHandler(this.thresholdBar_Scroll);
            this.thresholdBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thresholdBar_MouseUp);
            // 
            // resizeHeightInput
            // 
            this.resizeHeightInput.Location = new System.Drawing.Point(84, 43);
            this.resizeHeightInput.Name = "resizeHeightInput";
            this.resizeHeightInput.Size = new System.Drawing.Size(100, 22);
            this.resizeHeightInput.TabIndex = 3;
            this.resizeHeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // resizeWidthInput
            // 
            this.resizeWidthInput.Location = new System.Drawing.Point(85, 15);
            this.resizeWidthInput.Name = "resizeWidthInput";
            this.resizeWidthInput.Size = new System.Drawing.Size(100, 22);
            this.resizeWidthInput.TabIndex = 2;
            this.resizeWidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
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
            // resizeWidthLabel
            // 
            this.resizeWidthLabel.AutoSize = true;
            this.resizeWidthLabel.Location = new System.Drawing.Point(6, 18);
            this.resizeWidthLabel.Name = "resizeWidthLabel";
            this.resizeWidthLabel.Size = new System.Drawing.Size(73, 12);
            this.resizeWidthLabel.TabIndex = 0;
            this.resizeWidthLabel.Text = "Resize Width: ";
            // 
            // imageSaveBtn
            // 
            this.imageSaveBtn.Location = new System.Drawing.Point(848, 58);
            this.imageSaveBtn.Name = "imageSaveBtn";
            this.imageSaveBtn.Size = new System.Drawing.Size(88, 40);
            this.imageSaveBtn.TabIndex = 4;
            this.imageSaveBtn.Text = "Save Image";
            this.imageSaveBtn.UseVisualStyleBackColor = true;
            this.imageSaveBtn.Click += new System.EventHandler(this.imageSaveBtn_Click);
            // 
            // txtSaveBtn
            // 
            this.txtSaveBtn.Location = new System.Drawing.Point(848, 104);
            this.txtSaveBtn.Name = "txtSaveBtn";
            this.txtSaveBtn.Size = new System.Drawing.Size(88, 40);
            this.txtSaveBtn.TabIndex = 5;
            this.txtSaveBtn.Text = "Save Dots Text";
            this.txtSaveBtn.UseVisualStyleBackColor = true;
            this.txtSaveBtn.Click += new System.EventHandler(this.txtSaveBtn_Click);
            // 
            // gifTimer
            // 
            this.gifTimer.Tick += new System.EventHandler(this.gifTimer_Tick);
            // 
            // videoForm
            // 
            this.videoForm.Controls.Add(this.fpsText);
            this.videoForm.Controls.Add(this.fpsLabel);
            this.videoForm.Controls.Add(this.endSecText);
            this.videoForm.Controls.Add(this.middleLabel2);
            this.videoForm.Controls.Add(this.endMinText);
            this.videoForm.Controls.Add(this.videoEndLabel);
            this.videoForm.Controls.Add(this.startSecText);
            this.videoForm.Controls.Add(this.middleLabel);
            this.videoForm.Controls.Add(this.startMinText);
            this.videoForm.Controls.Add(this.VideoStartLabel);
            this.videoForm.Location = new System.Drawing.Point(372, 488);
            this.videoForm.Name = "videoForm";
            this.videoForm.Size = new System.Drawing.Size(470, 59);
            this.videoForm.TabIndex = 6;
            this.videoForm.TabStop = false;
            this.videoForm.Text = "Video Control";
            // 
            // fpsText
            // 
            this.fpsText.Location = new System.Drawing.Point(419, 22);
            this.fpsText.Name = "fpsText";
            this.fpsText.Size = new System.Drawing.Size(31, 22);
            this.fpsText.TabIndex = 9;
            this.fpsText.Text = "0";
            this.fpsText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(387, 25);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(26, 12);
            this.fpsLabel.TabIndex = 8;
            this.fpsLabel.Text = "FPS:";
            // 
            // endSecText
            // 
            this.endSecText.Location = new System.Drawing.Point(308, 22);
            this.endSecText.Name = "endSecText";
            this.endSecText.Size = new System.Drawing.Size(31, 22);
            this.endSecText.TabIndex = 7;
            this.endSecText.Text = "0";
            this.endSecText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // middleLabel2
            // 
            this.middleLabel2.AutoSize = true;
            this.middleLabel2.Location = new System.Drawing.Point(294, 25);
            this.middleLabel2.Name = "middleLabel2";
            this.middleLabel2.Size = new System.Drawing.Size(8, 12);
            this.middleLabel2.TabIndex = 6;
            this.middleLabel2.Text = ":";
            // 
            // endMinText
            // 
            this.endMinText.Location = new System.Drawing.Point(263, 22);
            this.endMinText.Name = "endMinText";
            this.endMinText.Size = new System.Drawing.Size(25, 22);
            this.endMinText.TabIndex = 5;
            this.endMinText.Text = "0";
            this.endMinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // videoEndLabel
            // 
            this.videoEndLabel.AutoSize = true;
            this.videoEndLabel.Location = new System.Drawing.Point(201, 25);
            this.videoEndLabel.Name = "videoEndLabel";
            this.videoEndLabel.Size = new System.Drawing.Size(54, 12);
            this.videoEndLabel.TabIndex = 4;
            this.videoEndLabel.Text = "End Time:";
            // 
            // startSecText
            // 
            this.startSecText.Location = new System.Drawing.Point(129, 22);
            this.startSecText.Name = "startSecText";
            this.startSecText.Size = new System.Drawing.Size(31, 22);
            this.startSecText.TabIndex = 3;
            this.startSecText.Text = "0";
            this.startSecText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.Location = new System.Drawing.Point(115, 25);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(8, 12);
            this.middleLabel.TabIndex = 2;
            this.middleLabel.Text = ":";
            // 
            // startMinText
            // 
            this.startMinText.Location = new System.Drawing.Point(84, 22);
            this.startMinText.Name = "startMinText";
            this.startMinText.Size = new System.Drawing.Size(25, 22);
            this.startMinText.TabIndex = 1;
            this.startMinText.Text = "0";
            this.startMinText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumberTextbox_KeyPress);
            // 
            // VideoStartLabel
            // 
            this.VideoStartLabel.AutoSize = true;
            this.VideoStartLabel.Location = new System.Drawing.Point(22, 25);
            this.VideoStartLabel.Name = "VideoStartLabel";
            this.VideoStartLabel.Size = new System.Drawing.Size(56, 12);
            this.VideoStartLabel.TabIndex = 0;
            this.VideoStartLabel.Text = "Start Time:";
            // 
            // videoLoadBtn
            // 
            this.videoLoadBtn.Location = new System.Drawing.Point(848, 150);
            this.videoLoadBtn.Name = "videoLoadBtn";
            this.videoLoadBtn.Size = new System.Drawing.Size(88, 40);
            this.videoLoadBtn.TabIndex = 7;
            this.videoLoadBtn.Text = "Load Video";
            this.videoLoadBtn.UseVisualStyleBackColor = true;
            this.videoLoadBtn.Click += new System.EventHandler(this.videoLoadBtn_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.videoLoadBtn);
            this.Controls.Add(this.videoForm);
            this.Controls.Add(this.txtSaveBtn);
            this.Controls.Add(this.imageSaveBtn);
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
            this.videoForm.ResumeLayout(false);
            this.videoForm.PerformLayout();
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
        private System.Windows.Forms.RadioButton processMethodRadio_fs;
        private System.Windows.Forms.RadioButton processMethodRadio_thresh;
        private System.Windows.Forms.Label renderLabel;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.Button imageSaveBtn;
        private System.Windows.Forms.Button txtSaveBtn;
        private System.Windows.Forms.Timer gifTimer;
        private System.Windows.Forms.GroupBox videoForm;
        private System.Windows.Forms.TextBox startMinText;
        private System.Windows.Forms.Label VideoStartLabel;
        private System.Windows.Forms.Button videoLoadBtn;
        private System.Windows.Forms.TextBox fpsText;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TextBox endSecText;
        private System.Windows.Forms.Label middleLabel2;
        private System.Windows.Forms.TextBox endMinText;
        private System.Windows.Forms.Label videoEndLabel;
        private System.Windows.Forms.TextBox startSecText;
        private System.Windows.Forms.Label middleLabel;
    }
}

