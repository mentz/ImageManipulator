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
            this.imageThresholding = new System.Windows.Forms.Button();
            this.imageRGBUpdate = new System.Windows.Forms.Button();
            this.imageSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.illuminanceTrackBar = new System.Windows.Forms.TrackBar();
            this.thresholdingLabel = new System.Windows.Forms.Label();
            this.matrixRr = new System.Windows.Forms.TextBox();
            this.matrixRg = new System.Windows.Forms.TextBox();
            this.matrixRb = new System.Windows.Forms.TextBox();
            this.matrixGr = new System.Windows.Forms.TextBox();
            this.matrixGg = new System.Windows.Forms.TextBox();
            this.matrixGb = new System.Windows.Forms.TextBox();
            this.matrixBr = new System.Windows.Forms.TextBox();
            this.matrixBg = new System.Windows.Forms.TextBox();
            this.matrixBb = new System.Windows.Forms.TextBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.imageHorizFlip = new System.Windows.Forms.Button();
            this.imageVertFlip = new System.Windows.Forms.Button();
            this.imageRotate90 = new System.Windows.Forms.Button();
            this.transitionApply = new System.Windows.Forms.Button();
            this.transitionSlider = new System.Windows.Forms.TrackBar();
            this.transitionLabel = new System.Windows.Forms.Label();
            this.transitionLoadSecond = new System.Windows.Forms.Button();
            this.imageZoomToogle = new System.Windows.Forms.Button();
            this.imageShowMatrix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illuminanceTrackBar)).BeginInit();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLoad
            // 
            this.imageLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageLoad.Location = new System.Drawing.Point(4, 5);
            this.imageLoad.Name = "imageLoad";
            this.imageLoad.Size = new System.Drawing.Size(110, 32);
            this.imageLoad.TabIndex = 0;
            this.imageLoad.Text = "Carregar imagem";
            this.imageLoad.UseVisualStyleBackColor = true;
            this.imageLoad.Click += new System.EventHandler(this.imageLoad_Click);
            // 
            // imageReset
            // 
            this.imageReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageReset.Location = new System.Drawing.Point(2, 2);
            this.imageReset.Name = "imageReset";
            this.imageReset.Size = new System.Drawing.Size(110, 32);
            this.imageReset.TabIndex = 1;
            this.imageReset.Text = "Reverter para original";
            this.imageReset.UseVisualStyleBackColor = true;
            this.imageReset.Click += new System.EventHandler(this.imageReset_Click);
            // 
            // imageRotate
            // 
            this.imageRotate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageRotate.Location = new System.Drawing.Point(58, 151);
            this.imageRotate.Name = "imageRotate";
            this.imageRotate.Size = new System.Drawing.Size(54, 32);
            this.imageRotate.TabIndex = 3;
            this.imageRotate.Text = "Inserido";
            this.imageRotate.UseVisualStyleBackColor = true;
            this.imageRotate.Click += new System.EventHandler(this.imageRotate_Click);
            // 
            // imageGrayscale
            // 
            this.imageGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageGrayscale.Location = new System.Drawing.Point(2, 221);
            this.imageGrayscale.Name = "imageGrayscale";
            this.imageGrayscale.Size = new System.Drawing.Size(110, 32);
            this.imageGrayscale.TabIndex = 4;
            this.imageGrayscale.Text = "Transformar para escala de cinza";
            this.imageGrayscale.UseVisualStyleBackColor = true;
            this.imageGrayscale.Click += new System.EventHandler(this.imageGrayscale_Click);
            // 
            // imageInvertColors
            // 
            this.imageInvertColors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageInvertColors.Location = new System.Drawing.Point(2, 256);
            this.imageInvertColors.Name = "imageInvertColors";
            this.imageInvertColors.Size = new System.Drawing.Size(110, 32);
            this.imageInvertColors.TabIndex = 5;
            this.imageInvertColors.Text = "Inverter cores";
            this.imageInvertColors.UseVisualStyleBackColor = true;
            this.imageInvertColors.Click += new System.EventHandler(this.imageInvertColors_Click);
            // 
            // imageThresholding
            // 
            this.imageThresholding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageThresholding.Location = new System.Drawing.Point(2, 368);
            this.imageThresholding.Name = "imageThresholding";
            this.imageThresholding.Size = new System.Drawing.Size(110, 32);
            this.imageThresholding.TabIndex = 6;
            this.imageThresholding.Text = "Transformar em preto-e-branco";
            this.imageThresholding.UseVisualStyleBackColor = true;
            this.imageThresholding.Click += new System.EventHandler(this.imageThresholding_Click);
            // 
            // imageRGBUpdate
            // 
            this.imageRGBUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageRGBUpdate.Location = new System.Drawing.Point(2, 490);
            this.imageRGBUpdate.Name = "imageRGBUpdate";
            this.imageRGBUpdate.Size = new System.Drawing.Size(110, 32);
            this.imageRGBUpdate.TabIndex = 7;
            this.imageRGBUpdate.Text = "Atualizar valores RGB";
            this.imageRGBUpdate.UseVisualStyleBackColor = true;
            this.imageRGBUpdate.Click += new System.EventHandler(this.imageRGBUpdate_Click);
            // 
            // imageSave
            // 
            this.imageSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageSave.Location = new System.Drawing.Point(2, 37);
            this.imageSave.Name = "imageSave";
            this.imageSave.Size = new System.Drawing.Size(110, 32);
            this.imageSave.TabIndex = 2;
            this.imageSave.Text = "Salvar nova imagem";
            this.imageSave.UseVisualStyleBackColor = true;
            this.imageSave.Click += new System.EventHandler(this.imageSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(118, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1141, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Location = new System.Drawing.Point(3, 127);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(108, 20);
            this.rotationTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o ângulo em\r\ngraus para rotacionar\r\na imagem (horário)";
            // 
            // illuminanceTrackBar
            // 
            this.illuminanceTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.illuminanceTrackBar.Location = new System.Drawing.Point(2, 335);
            this.illuminanceTrackBar.Maximum = 255;
            this.illuminanceTrackBar.Name = "illuminanceTrackBar";
            this.illuminanceTrackBar.Size = new System.Drawing.Size(110, 45);
            this.illuminanceTrackBar.TabIndex = 11;
            this.illuminanceTrackBar.TickFrequency = 8;
            this.illuminanceTrackBar.Value = 127;
            // 
            // thresholdingLabel
            // 
            this.thresholdingLabel.AutoSize = true;
            this.thresholdingLabel.Location = new System.Drawing.Point(3, 293);
            this.thresholdingLabel.Name = "thresholdingLabel";
            this.thresholdingLabel.Size = new System.Drawing.Size(94, 39);
            this.thresholdingLabel.TabIndex = 12;
            this.thresholdingLabel.Text = "Mova o slider para\r\nselecionar o limiar\r\nde iluminância.";
            // 
            // matrixRr
            // 
            this.matrixRr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.matrixRr.Location = new System.Drawing.Point(6, 422);
            this.matrixRr.Name = "matrixRr";
            this.matrixRr.Size = new System.Drawing.Size(30, 20);
            this.matrixRr.TabIndex = 13;
            this.matrixRr.Text = "1";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixRg
            // 
            this.matrixRg.Location = new System.Drawing.Point(42, 422);
            this.matrixRg.Name = "matrixRg";
            this.matrixRg.Size = new System.Drawing.Size(30, 20);
            this.matrixRg.TabIndex = 14;
            this.matrixRg.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixRb
            // 
            this.matrixRb.Location = new System.Drawing.Point(78, 422);
            this.matrixRb.Name = "matrixRb";
            this.matrixRb.Size = new System.Drawing.Size(30, 20);
            this.matrixRb.TabIndex = 15;
            this.matrixRb.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixGr
            // 
            this.matrixGr.Location = new System.Drawing.Point(6, 445);
            this.matrixGr.Name = "matrixGr";
            this.matrixGr.Size = new System.Drawing.Size(30, 20);
            this.matrixGr.TabIndex = 16;
            this.matrixGr.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixGg
            // 
            this.matrixGg.Location = new System.Drawing.Point(42, 445);
            this.matrixGg.Name = "matrixGg";
            this.matrixGg.Size = new System.Drawing.Size(30, 20);
            this.matrixGg.TabIndex = 17;
            this.matrixGg.Text = "1";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixGb
            // 
            this.matrixGb.Location = new System.Drawing.Point(78, 445);
            this.matrixGb.Name = "matrixGb";
            this.matrixGb.Size = new System.Drawing.Size(30, 20);
            this.matrixGb.TabIndex = 18;
            this.matrixGb.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixBr
            // 
            this.matrixBr.Location = new System.Drawing.Point(6, 468);
            this.matrixBr.Name = "matrixBr";
            this.matrixBr.Size = new System.Drawing.Size(30, 20);
            this.matrixBr.TabIndex = 19;
            this.matrixBr.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixBg
            // 
            this.matrixBg.Location = new System.Drawing.Point(42, 468);
            this.matrixBg.Name = "matrixBg";
            this.matrixBg.Size = new System.Drawing.Size(30, 20);
            this.matrixBg.TabIndex = 20;
            this.matrixBg.Text = "0";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // matrixBb
            // 
            this.matrixBb.Location = new System.Drawing.Point(78, 468);
            this.matrixBb.Name = "matrixBb";
            this.matrixBb.Size = new System.Drawing.Size(30, 20);
            this.matrixBb.TabIndex = 21;
            this.matrixBb.Text = "1";
            this.matrixRr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matrixInput_KeyPress);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.imageHorizFlip);
            this.optionsPanel.Controls.Add(this.imageVertFlip);
            this.optionsPanel.Controls.Add(this.imageRotate90);
            this.optionsPanel.Controls.Add(this.transitionApply);
            this.optionsPanel.Controls.Add(this.transitionSlider);
            this.optionsPanel.Controls.Add(this.transitionLabel);
            this.optionsPanel.Controls.Add(this.transitionLoadSecond);
            this.optionsPanel.Controls.Add(this.imageZoomToogle);
            this.optionsPanel.Controls.Add(this.imageShowMatrix);
            this.optionsPanel.Controls.Add(this.label2);
            this.optionsPanel.Controls.Add(this.matrixRr);
            this.optionsPanel.Controls.Add(this.imageThresholding);
            this.optionsPanel.Controls.Add(this.matrixBb);
            this.optionsPanel.Controls.Add(this.illuminanceTrackBar);
            this.optionsPanel.Controls.Add(this.thresholdingLabel);
            this.optionsPanel.Controls.Add(this.matrixRg);
            this.optionsPanel.Controls.Add(this.matrixBg);
            this.optionsPanel.Controls.Add(this.rotationTextBox);
            this.optionsPanel.Controls.Add(this.imageInvertColors);
            this.optionsPanel.Controls.Add(this.label1);
            this.optionsPanel.Controls.Add(this.imageGrayscale);
            this.optionsPanel.Controls.Add(this.matrixRb);
            this.optionsPanel.Controls.Add(this.imageRotate);
            this.optionsPanel.Controls.Add(this.matrixBr);
            this.optionsPanel.Controls.Add(this.matrixGr);
            this.optionsPanel.Controls.Add(this.imageSave);
            this.optionsPanel.Controls.Add(this.imageRGBUpdate);
            this.optionsPanel.Controls.Add(this.matrixGb);
            this.optionsPanel.Controls.Add(this.matrixGg);
            this.optionsPanel.Controls.Add(this.imageReset);
            this.optionsPanel.Enabled = false;
            this.optionsPanel.Location = new System.Drawing.Point(2, 38);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(114, 690);
            this.optionsPanel.TabIndex = 22;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionsPanel_Paint);
            // 
            // imageHorizFlip
            // 
            this.imageHorizFlip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageHorizFlip.Location = new System.Drawing.Point(58, 186);
            this.imageHorizFlip.Name = "imageHorizFlip";
            this.imageHorizFlip.Size = new System.Drawing.Size(54, 32);
            this.imageHorizFlip.TabIndex = 31;
            this.imageHorizFlip.Text = "Flip Horizontal";
            this.imageHorizFlip.UseVisualStyleBackColor = true;
            this.imageHorizFlip.Click += new System.EventHandler(this.imageHorizFlip_Click);
            // 
            // imageVertFlip
            // 
            this.imageVertFlip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageVertFlip.Location = new System.Drawing.Point(2, 186);
            this.imageVertFlip.Name = "imageVertFlip";
            this.imageVertFlip.Size = new System.Drawing.Size(54, 32);
            this.imageVertFlip.TabIndex = 30;
            this.imageVertFlip.Text = "Flip Vertical";
            this.imageVertFlip.UseVisualStyleBackColor = true;
            this.imageVertFlip.Click += new System.EventHandler(this.imageVertFlip_Click);
            // 
            // imageRotate90
            // 
            this.imageRotate90.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageRotate90.Location = new System.Drawing.Point(2, 151);
            this.imageRotate90.Name = "imageRotate90";
            this.imageRotate90.Size = new System.Drawing.Size(54, 32);
            this.imageRotate90.TabIndex = 29;
            this.imageRotate90.Text = "+90°";
            this.imageRotate90.UseVisualStyleBackColor = true;
            this.imageRotate90.Click += new System.EventHandler(this.imageRotate90_Click);
            // 
            // transitionApply
            // 
            this.transitionApply.Enabled = false;
            this.transitionApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.transitionApply.Location = new System.Drawing.Point(2, 601);
            this.transitionApply.Name = "transitionApply";
            this.transitionApply.Size = new System.Drawing.Size(110, 32);
            this.transitionApply.TabIndex = 25;
            this.transitionApply.Text = "Aplicar transição";
            this.transitionApply.UseVisualStyleBackColor = true;
            this.transitionApply.Click += new System.EventHandler(this.transitionApply_Click);
            // 
            // transitionSlider
            // 
            this.transitionSlider.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.transitionSlider.Enabled = false;
            this.transitionSlider.Location = new System.Drawing.Point(2, 572);
            this.transitionSlider.Maximum = 100;
            this.transitionSlider.Name = "transitionSlider";
            this.transitionSlider.Size = new System.Drawing.Size(110, 45);
            this.transitionSlider.TabIndex = 28;
            this.transitionSlider.TickFrequency = 8;
            this.transitionSlider.Value = 50;
            // 
            // transitionLabel
            // 
            this.transitionLabel.AutoSize = true;
            this.transitionLabel.Location = new System.Drawing.Point(3, 524);
            this.transitionLabel.Name = "transitionLabel";
            this.transitionLabel.Size = new System.Drawing.Size(108, 13);
            this.transitionLabel.TabIndex = 27;
            this.transitionLabel.Text = "Transição de imagem";
            // 
            // transitionLoadSecond
            // 
            this.transitionLoadSecond.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.transitionLoadSecond.Location = new System.Drawing.Point(2, 539);
            this.transitionLoadSecond.Name = "transitionLoadSecond";
            this.transitionLoadSecond.Size = new System.Drawing.Size(110, 32);
            this.transitionLoadSecond.TabIndex = 26;
            this.transitionLoadSecond.Text = "Carregar imagem secundária";
            this.transitionLoadSecond.UseVisualStyleBackColor = true;
            this.transitionLoadSecond.Click += new System.EventHandler(this.transitionLoadSecond_Click);
            // 
            // imageZoomToogle
            // 
            this.imageZoomToogle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageZoomToogle.Location = new System.Drawing.Point(2, 656);
            this.imageZoomToogle.Name = "imageZoomToogle";
            this.imageZoomToogle.Size = new System.Drawing.Size(54, 32);
            this.imageZoomToogle.TabIndex = 24;
            this.imageZoomToogle.Text = "Amplificar";
            this.imageZoomToogle.UseVisualStyleBackColor = true;
            this.imageZoomToogle.Click += new System.EventHandler(this.imageZoomToogle_Click);
            // 
            // imageShowMatrix
            // 
            this.imageShowMatrix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageShowMatrix.Location = new System.Drawing.Point(58, 656);
            this.imageShowMatrix.Name = "imageShowMatrix";
            this.imageShowMatrix.Size = new System.Drawing.Size(54, 32);
            this.imageShowMatrix.TabIndex = 23;
            this.imageShowMatrix.Text = "Exibir matriz";
            this.imageShowMatrix.UseVisualStyleBackColor = true;
            this.imageShowMatrix.Click += new System.EventHandler(this.imageShowMatrix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Alterar matriz RGB";
            // 
            // matrixViewer
            // 
            this.matrixViewer.AllowUserToAddRows = false;
            this.matrixViewer.AllowUserToDeleteRows = false;
            this.matrixViewer.AllowUserToResizeColumns = false;
            this.matrixViewer.AllowUserToResizeRows = false;
            this.matrixViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrixViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixViewer.Enabled = false;
            this.matrixViewer.Location = new System.Drawing.Point(118, 5);
            this.matrixViewer.Name = "matrixViewer";
            this.matrixViewer.Size = new System.Drawing.Size(1141, 720);
            this.matrixViewer.TabIndex = 23;
            this.matrixViewer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.imageLoad);
            this.Controls.Add(this.matrixViewer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageManipulator - By Lucas Litter Mentz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illuminanceTrackBar)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imageLoad;
        private System.Windows.Forms.Button imageReset;
        private System.Windows.Forms.Button imageRotate;
        private System.Windows.Forms.Button imageGrayscale;
        private System.Windows.Forms.Button imageInvertColors;
        private System.Windows.Forms.Button imageThresholding;
        private System.Windows.Forms.Button imageRGBUpdate;
        private System.Windows.Forms.Button imageSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar illuminanceTrackBar;
        private System.Windows.Forms.Label thresholdingLabel;
        private System.Windows.Forms.TextBox matrixRr;
        private System.Windows.Forms.TextBox matrixRg;
        private System.Windows.Forms.TextBox matrixRb;
        private System.Windows.Forms.TextBox matrixGr;
        private System.Windows.Forms.TextBox matrixGg;
        private System.Windows.Forms.TextBox matrixGb;
        private System.Windows.Forms.TextBox matrixBr;
        private System.Windows.Forms.TextBox matrixBg;
        private System.Windows.Forms.TextBox matrixBb;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button imageShowMatrix;
        private System.Windows.Forms.DataGridView matrixViewer;
        private System.Windows.Forms.Button imageZoomToogle;
        private System.Windows.Forms.Button transitionApply;
        private System.Windows.Forms.TrackBar transitionSlider;
        private System.Windows.Forms.Label transitionLabel;
        private System.Windows.Forms.Button transitionLoadSecond;
        private System.Windows.Forms.Button imageRotate90;
        private System.Windows.Forms.Button imageHorizFlip;
        private System.Windows.Forms.Button imageVertFlip;
    }
}

