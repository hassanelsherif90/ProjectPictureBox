namespace ProjectPictureBox
{
    partial class Form1
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
            this.rdBook = new System.Windows.Forms.RadioButton();
            this.rdGirl = new System.Windows.Forms.RadioButton();
            this.rdBoy = new System.Windows.Forms.RadioButton();
            this.rdPen = new System.Windows.Forms.RadioButton();
            this.pcbType = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbType)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBook
            // 
            this.rdBook.AutoSize = true;
            this.rdBook.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBook.Location = new System.Drawing.Point(204, 356);
            this.rdBook.Name = "rdBook";
            this.rdBook.Size = new System.Drawing.Size(75, 28);
            this.rdBook.TabIndex = 0;
            this.rdBook.TabStop = true;
            this.rdBook.Tag = "Book";
            this.rdBook.Text = "Book";
            this.rdBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBook.UseVisualStyleBackColor = true;
            this.rdBook.CheckedChanged += new System.EventHandler(this.rdBook_CheckedChanged);
            // 
            // rdGirl
            // 
            this.rdGirl.AutoSize = true;
            this.rdGirl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGirl.Location = new System.Drawing.Point(318, 356);
            this.rdGirl.Name = "rdGirl";
            this.rdGirl.Size = new System.Drawing.Size(61, 28);
            this.rdGirl.TabIndex = 1;
            this.rdGirl.TabStop = true;
            this.rdGirl.Tag = "Girl";
            this.rdGirl.Text = "Girl";
            this.rdGirl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdGirl.UseVisualStyleBackColor = true;
            this.rdGirl.CheckedChanged += new System.EventHandler(this.rdGirl_CheckedChanged);
            // 
            // rdBoy
            // 
            this.rdBoy.AutoSize = true;
            this.rdBoy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBoy.Location = new System.Drawing.Point(429, 356);
            this.rdBoy.Name = "rdBoy";
            this.rdBoy.Size = new System.Drawing.Size(64, 28);
            this.rdBoy.TabIndex = 2;
            this.rdBoy.TabStop = true;
            this.rdBoy.Tag = "Boy";
            this.rdBoy.Text = "Boy";
            this.rdBoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBoy.UseVisualStyleBackColor = true;
            this.rdBoy.CheckedChanged += new System.EventHandler(this.rdBoy_CheckedChanged);
            // 
            // rdPen
            // 
            this.rdPen.AutoSize = true;
            this.rdPen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPen.Location = new System.Drawing.Point(527, 356);
            this.rdPen.Name = "rdPen";
            this.rdPen.Size = new System.Drawing.Size(64, 28);
            this.rdPen.TabIndex = 3;
            this.rdPen.TabStop = true;
            this.rdPen.Tag = "Pen";
            this.rdPen.Text = "Pen";
            this.rdPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdPen.UseVisualStyleBackColor = true;
            this.rdPen.CheckedChanged += new System.EventHandler(this.rdPen_CheckedChanged);
            // 
            // pcbType
            // 
            this.pcbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbType.Image = global::ProjectPictureBox.Properties.Resources.Book;
            this.pcbType.Location = new System.Drawing.Point(222, 87);
            this.pcbType.Name = "pcbType";
            this.pcbType.Size = new System.Drawing.Size(350, 247);
            this.pcbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbType.TabIndex = 4;
            this.pcbType.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(268, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 39);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbType);
            this.Controls.Add(this.rdPen);
            this.Controls.Add(this.rdBoy);
            this.Controls.Add(this.rdGirl);
            this.Controls.Add(this.rdBook);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBook;
        private System.Windows.Forms.RadioButton rdGirl;
        private System.Windows.Forms.RadioButton rdBoy;
        private System.Windows.Forms.RadioButton rdPen;
        private System.Windows.Forms.PictureBox pcbType;
        private System.Windows.Forms.Label lblTitle;
    }
}

