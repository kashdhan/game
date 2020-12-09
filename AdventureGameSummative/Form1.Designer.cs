namespace AdventureGameSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.sceneImageBox = new System.Windows.Forms.PictureBox();
            this.yellowImage = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outputLabel.Location = new System.Drawing.Point(9, 12);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(3);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(555, 232);
            this.outputLabel.TabIndex = 0;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.redLabel.Location = new System.Drawing.Point(107, 458);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(342, 60);
            this.redLabel.TabIndex = 1;
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueLabel.Location = new System.Drawing.Point(107, 518);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(342, 55);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yellowLabel.Location = new System.Drawing.Point(107, 573);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(342, 60);
            this.yellowLabel.TabIndex = 3;
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sceneImageBox
            // 
            this.sceneImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImageBox.Location = new System.Drawing.Point(1, 229);
            this.sceneImageBox.Name = "sceneImageBox";
            this.sceneImageBox.Size = new System.Drawing.Size(573, 223);
            this.sceneImageBox.TabIndex = 7;
            this.sceneImageBox.TabStop = false;
            // 
            // yellowImage
            // 
            this.yellowImage.Image = global::AdventureGameSummative.Properties.Resources.yellow_50x50;
            this.yellowImage.Location = new System.Drawing.Point(15, 583);
            this.yellowImage.Name = "yellowImage";
            this.yellowImage.Size = new System.Drawing.Size(51, 50);
            this.yellowImage.TabIndex = 6;
            this.yellowImage.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.Image = global::AdventureGameSummative.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(15, 522);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(51, 51);
            this.blueImage.TabIndex = 5;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::AdventureGameSummative.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(15, 458);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(51, 50);
            this.redImage.TabIndex = 4;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(576, 644);
            this.Controls.Add(this.sceneImageBox);
            this.Controls.Add(this.yellowImage);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gryffindor Quest Request ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.PictureBox yellowImage;
        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox sceneImageBox;
    }
}

