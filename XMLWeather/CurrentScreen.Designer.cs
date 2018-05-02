namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.cloudBox = new System.Windows.Forms.PictureBox();
            this.thermBox = new System.Windows.Forms.PictureBox();
            this.celsisusBox = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cloudBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celsisusBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(123, 363);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(250, 48);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(141, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(127, 56);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(241, 152);
            this.tempLabel.TabIndex = 43;
            this.tempLabel.Text = "Temp";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cloudBox
            // 
            this.cloudBox.BackColor = System.Drawing.Color.Transparent;
            this.cloudBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cloudBox.Location = new System.Drawing.Point(170, 194);
            this.cloudBox.Name = "cloudBox";
            this.cloudBox.Size = new System.Drawing.Size(150, 150);
            this.cloudBox.TabIndex = 44;
            this.cloudBox.TabStop = false;
            // 
            // thermBox
            // 
            this.thermBox.BackColor = System.Drawing.Color.Transparent;
            this.thermBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.thermBox.Location = new System.Drawing.Point(51, 103);
            this.thermBox.Name = "thermBox";
            this.thermBox.Size = new System.Drawing.Size(70, 70);
            this.thermBox.TabIndex = 45;
            this.thermBox.TabStop = false;
            // 
            // celsisusBox
            // 
            this.celsisusBox.BackColor = System.Drawing.Color.Transparent;
            this.celsisusBox.BackgroundImage = global::XMLWeather.Properties.Resources.celcius;
            this.celsisusBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.celsisusBox.Location = new System.Drawing.Point(369, 103);
            this.celsisusBox.Name = "celsisusBox";
            this.celsisusBox.Size = new System.Drawing.Size(70, 70);
            this.celsisusBox.TabIndex = 46;
            this.celsisusBox.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(123, 411);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(250, 48);
            this.timeLabel.TabIndex = 47;
            this.timeLabel.Text = "Time/Date";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.blurred_background_design_1107_224;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.celsisusBox);
            this.Controls.Add(this.thermBox);
            this.Controls.Add(this.cloudBox);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.cloudBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celsisusBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.PictureBox cloudBox;
        private System.Windows.Forms.PictureBox thermBox;
        private System.Windows.Forms.PictureBox celsisusBox;
        private System.Windows.Forms.Label timeLabel;
    }
}
