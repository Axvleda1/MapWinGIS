using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BingHybridBtn = new System.Windows.Forms.Button();
            this.GoogleHybridBtn = new System.Windows.Forms.Button();
            this.GoogleSatBtn = new System.Windows.Forms.Button();
            this.BingSatBtn = new System.Windows.Forms.Button();
            this.GoogleMapsBtn = new System.Windows.Forms.Button();
            this.BingMapBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.axMap2 = new AxMapWinGIS.AxMap();
            this.axMap2 = new AxMapWinGIS.AxMap();
            this.axMap2 = new AxMapWinGIS.AxMap();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BingHybridBtn);
            this.panel2.Controls.Add(this.GoogleHybridBtn);
            this.panel2.Controls.Add(this.GoogleSatBtn);
            this.panel2.Controls.Add(this.BingSatBtn);
            this.panel2.Controls.Add(this.GoogleMapsBtn);
            this.panel2.Controls.Add(this.BingMapBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 586);
            this.panel2.TabIndex = 1;
            // 
            // BingHybridBtn
            // 
            this.BingHybridBtn.BackColor = System.Drawing.Color.DimGray;
            this.BingHybridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BingHybridBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BingHybridBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BingHybridBtn.Location = new System.Drawing.Point(31, 450);
            this.BingHybridBtn.Name = "BingHybridBtn";
            this.BingHybridBtn.Size = new System.Drawing.Size(126, 51);
            this.BingHybridBtn.TabIndex = 5;
            this.BingHybridBtn.Text = "Bing Hybrid";
            this.BingHybridBtn.UseVisualStyleBackColor = false;
            // 
            // GoogleHybridBtn
            // 
            this.GoogleHybridBtn.BackColor = System.Drawing.Color.DimGray;
            this.GoogleHybridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoogleHybridBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoogleHybridBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoogleHybridBtn.Location = new System.Drawing.Point(31, 195);
            this.GoogleHybridBtn.Name = "GoogleHybridBtn";
            this.GoogleHybridBtn.Size = new System.Drawing.Size(126, 51);
            this.GoogleHybridBtn.TabIndex = 2;
            this.GoogleHybridBtn.Text = "Google Hybrid";
            this.GoogleHybridBtn.UseVisualStyleBackColor = false;
            // 
            // GoogleSatBtn
            // 
            this.GoogleSatBtn.BackColor = System.Drawing.Color.DimGray;
            this.GoogleSatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoogleSatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoogleSatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoogleSatBtn.Location = new System.Drawing.Point(31, 137);
            this.GoogleSatBtn.Name = "GoogleSatBtn";
            this.GoogleSatBtn.Size = new System.Drawing.Size(126, 51);
            this.GoogleSatBtn.TabIndex = 1;
            this.GoogleSatBtn.Text = "Google Satelite";
            this.GoogleSatBtn.UseVisualStyleBackColor = false;
            // 
            // BingSatBtn
            // 
            this.BingSatBtn.BackColor = System.Drawing.Color.DimGray;
            this.BingSatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BingSatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BingSatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BingSatBtn.Location = new System.Drawing.Point(31, 392);
            this.BingSatBtn.Name = "BingSatBtn";
            this.BingSatBtn.Size = new System.Drawing.Size(126, 51);
            this.BingSatBtn.TabIndex = 4;
            this.BingSatBtn.Text = "Bing Satelite";
            this.BingSatBtn.UseVisualStyleBackColor = false;
            // 
            // GoogleMapsBtn
            // 
            this.GoogleMapsBtn.BackColor = System.Drawing.Color.DimGray;
            this.GoogleMapsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoogleMapsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoogleMapsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoogleMapsBtn.Location = new System.Drawing.Point(31, 79);
            this.GoogleMapsBtn.Name = "GoogleMapsBtn";
            this.GoogleMapsBtn.Size = new System.Drawing.Size(126, 51);
            this.GoogleMapsBtn.TabIndex = 0;
            this.GoogleMapsBtn.Text = "Google Maps";
            this.GoogleMapsBtn.UseVisualStyleBackColor = false;
            // 
            // BingMapBtn
            // 
            this.BingMapBtn.BackColor = System.Drawing.Color.DimGray;
            this.BingMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BingMapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BingMapBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BingMapBtn.Location = new System.Drawing.Point(31, 334);
            this.BingMapBtn.Name = "BingMapBtn";
            this.BingMapBtn.Size = new System.Drawing.Size(126, 51);
            this.BingMapBtn.TabIndex = 3;
            this.BingMapBtn.Text = "Bing Map";
            this.BingMapBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(191, 594);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 33);
            this.panel3.TabIndex = 2;
            // 
            // axMap2
            // 
            this.axMap2.Enabled = true;
            this.axMap2.Location = new System.Drawing.Point(0, 0);
            this.axMap2.Name = "axMap2";
            this.axMap2.TabIndex = 0;
            // 
            // axMap2
            // 
            this.axMap2.Enabled = true;
            this.axMap2.Location = new System.Drawing.Point(0, 0);
            this.axMap2.Name = "axMap2";
            this.axMap2.TabIndex = 0;
            // 
            // axMap2
            // 
            this.axMap2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap2.Enabled = true;
            this.axMap2.Location = new System.Drawing.Point(191, 41);
            this.axMap2.Name = "axMap2";
            this.axMap2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap2.OcxState")));
            this.axMap2.Size = new System.Drawing.Size(933, 553);
            this.axMap2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 627);
            this.Controls.Add(this.axMap2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.Button BingHybridBtn;
        private System.Windows.Forms.Button GoogleHybridBtn;
        private System.Windows.Forms.Button GoogleSatBtn;
        private System.Windows.Forms.Button BingSatBtn;
        private System.Windows.Forms.Button GoogleMapsBtn;
        private System.Windows.Forms.Button BingMapBtn;
        private AxMapWinGIS.AxMap axMap2;
    }
}

