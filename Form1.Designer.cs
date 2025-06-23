namespace QRCodeReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowseImage = new Button();
            pbQRCodeImage = new PictureBox();
            label1 = new Label();
            txtResult = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbQRCodeImage).BeginInit();
            SuspendLayout();
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(30, 22);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(115, 31);
            btnBrowseImage.TabIndex = 0;
            btnBrowseImage.Text = "QR 이미지 선택";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // pbQRCodeImage
            // 
            pbQRCodeImage.Location = new Point(30, 83);
            pbQRCodeImage.Name = "pbQRCodeImage";
            pbQRCodeImage.Size = new Size(216, 190);
            pbQRCodeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRCodeImage.TabIndex = 1;
            pbQRCodeImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 304);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "QR 코드 결과";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("맑은 고딕", 11F);
            txtResult.Location = new Point(30, 353);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(445, 183);
            txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 560);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(pbQRCodeImage);
            Controls.Add(btnBrowseImage);
            Name = "Form1";
            Text = "QR Code Reader";
            ((System.ComponentModel.ISupportInitialize)pbQRCodeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseImage;
        private PictureBox pbQRCodeImage;
        private Label label1;
        private TextBox txtResult;
    }
}
