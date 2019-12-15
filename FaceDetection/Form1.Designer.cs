namespace FaceDetection
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.Camera_On = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.Capture = new System.Windows.Forms.Button();
            this.New_Face = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(80, 77);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(278, 266);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Camera_On
            // 
            this.Camera_On.Location = new System.Drawing.Point(381, 77);
            this.Camera_On.Name = "Camera_On";
            this.Camera_On.Size = new System.Drawing.Size(187, 56);
            this.Camera_On.TabIndex = 3;
            this.Camera_On.Text = "Start Detection";
            this.Camera_On.UseVisualStyleBackColor = true;
            this.Camera_On.Click += new System.EventHandler(this.Camera_On_Click);
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(381, 178);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(187, 58);
            this.Train.TabIndex = 4;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Capture
            // 
            this.Capture.Location = new System.Drawing.Point(381, 285);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(187, 58);
            this.Capture.TabIndex = 5;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // New_Face
            // 
            this.New_Face.Location = new System.Drawing.Point(585, 285);
            this.New_Face.Name = "New_Face";
            this.New_Face.Size = new System.Drawing.Size(187, 58);
            this.New_Face.TabIndex = 8;
            this.New_Face.Text = "New Faces";
            this.New_Face.UseVisualStyleBackColor = true;
            this.New_Face.Click += new System.EventHandler(this.New_Face_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(585, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 58);
            this.button5.TabIndex = 7;
            this.button5.Text = "Send Report";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(585, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "Start Detection";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.New_Face);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Capture);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Camera_On);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button Camera_On;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button Capture;
        private System.Windows.Forms.Button New_Face;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

