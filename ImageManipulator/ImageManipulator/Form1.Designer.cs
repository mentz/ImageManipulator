namespace ImageManipulator
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
            this.imageLoad = new System.Windows.Forms.Button();
            this.imageReset = new System.Windows.Forms.Button();
            this.imageRotate = new System.Windows.Forms.Button();
            this.imageGrayscale = new System.Windows.Forms.Button();
            this.imageInvertColors = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.imageSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLoad
            // 
            this.imageLoad.Location = new System.Drawing.Point(13, 13);
            this.imageLoad.Name = "imageLoad";
            this.imageLoad.Size = new System.Drawing.Size(110, 46);
            this.imageLoad.TabIndex = 0;
            this.imageLoad.Text = "Carregar imagem";
            this.imageLoad.UseVisualStyleBackColor = true;
            this.imageLoad.Click += new System.EventHandler(this.imageLoad_Click);
            // 
            // imageReset
            // 
            this.imageReset.Location = new System.Drawing.Point(12, 65);
            this.imageReset.Name = "imageReset";
            this.imageReset.Size = new System.Drawing.Size(110, 46);
            this.imageReset.TabIndex = 1;
            this.imageReset.Text = "Reverter para original";
            this.imageReset.UseVisualStyleBackColor = true;
            this.imageReset.Click += new System.EventHandler(this.imageReset_Click);
            // 
            // imageRotate
            // 
            this.imageRotate.Location = new System.Drawing.Point(12, 251);
            this.imageRotate.Name = "imageRotate";
            this.imageRotate.Size = new System.Drawing.Size(110, 46);
            this.imageRotate.TabIndex = 2;
            this.imageRotate.Text = "Rotacionar";
            this.imageRotate.UseVisualStyleBackColor = true;
            this.imageRotate.Click += new System.EventHandler(this.imageRotate_Click);
            // 
            // imageGrayscale
            // 
            this.imageGrayscale.Location = new System.Drawing.Point(12, 303);
            this.imageGrayscale.Name = "imageGrayscale";
            this.imageGrayscale.Size = new System.Drawing.Size(110, 46);
            this.imageGrayscale.TabIndex = 3;
            this.imageGrayscale.Text = "Transformar para escala de cinza";
            this.imageGrayscale.UseVisualStyleBackColor = true;
            this.imageGrayscale.Click += new System.EventHandler(this.imageGrayscale_Click);
            // 
            // imageInvertColors
            // 
            this.imageInvertColors.Location = new System.Drawing.Point(12, 355);
            this.imageInvertColors.Name = "imageInvertColors";
            this.imageInvertColors.Size = new System.Drawing.Size(110, 46);
            this.imageInvertColors.TabIndex = 4;
            this.imageInvertColors.Text = "Inverter cores";
            this.imageInvertColors.UseVisualStyleBackColor = true;
            this.imageInvertColors.Click += new System.EventHandler(this.imageInvertColors_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 407);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 46);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // imageSave
            // 
            this.imageSave.Location = new System.Drawing.Point(12, 117);
            this.imageSave.Name = "imageSave";
            this.imageSave.Size = new System.Drawing.Size(110, 46);
            this.imageSave.TabIndex = 7;
            this.imageSave.Text = "Salvar nova imagem";
            this.imageSave.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(130, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1122, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Location = new System.Drawing.Point(13, 225);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(109, 20);
            this.rotationTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o ângulo em\r\ngraus para rotacionar\r\na imagem (horário)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotationTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageSave);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.imageInvertColors);
            this.Controls.Add(this.imageGrayscale);
            this.Controls.Add(this.imageRotate);
            this.Controls.Add(this.imageReset);
            this.Controls.Add(this.imageLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imageLoad;
        private System.Windows.Forms.Button imageReset;
        private System.Windows.Forms.Button imageRotate;
        private System.Windows.Forms.Button imageGrayscale;
        private System.Windows.Forms.Button imageInvertColors;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button imageSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.Label label1;
    }
}

