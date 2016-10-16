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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.imageSave = new System.Windows.Forms.Button();
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
            // 
            // imageReset
            // 
            this.imageReset.Location = new System.Drawing.Point(12, 65);
            this.imageReset.Name = "imageReset";
            this.imageReset.Size = new System.Drawing.Size(110, 46);
            this.imageReset.TabIndex = 1;
            this.imageReset.Text = "Reverter tudo";
            this.imageReset.UseVisualStyleBackColor = true;
            // 
            // imageRotate
            // 
            this.imageRotate.Location = new System.Drawing.Point(12, 169);
            this.imageRotate.Name = "imageRotate";
            this.imageRotate.Size = new System.Drawing.Size(110, 46);
            this.imageRotate.TabIndex = 2;
            this.imageRotate.Text = "Rotacionar";
            this.imageRotate.UseVisualStyleBackColor = true;
            this.imageRotate.Click += new System.EventHandler(this.imageRotate_Click);
            // 
            // imageGrayscale
            // 
            this.imageGrayscale.Location = new System.Drawing.Point(12, 221);
            this.imageGrayscale.Name = "imageGrayscale";
            this.imageGrayscale.Size = new System.Drawing.Size(110, 46);
            this.imageGrayscale.TabIndex = 3;
            this.imageGrayscale.Text = "Transformar para escala de cinza";
            this.imageGrayscale.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 377);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imageSave);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imageGrayscale);
            this.Controls.Add(this.imageRotate);
            this.Controls.Add(this.imageReset);
            this.Controls.Add(this.imageLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imageLoad;
        private System.Windows.Forms.Button imageReset;
        private System.Windows.Forms.Button imageRotate;
        private System.Windows.Forms.Button imageGrayscale;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button imageSave;
    }
}

