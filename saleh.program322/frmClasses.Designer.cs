﻿namespace saleh.program322
{
    partial class frmClasses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStartMyTruck = new System.Windows.Forms.Button();
            this.BtnStopHisCar = new System.Windows.Forms.Button();
            this.BtnAccHisCar = new System.Windows.Forms.Button();
            this.BtnStartHisCar = new System.Windows.Forms.Button();
            this.BtnStopMyCar = new System.Windows.Forms.Button();
            this.BtnAccMyCar = new System.Windows.Forms.Button();
            this.BtnStartMyCar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStartMyTruck);
            this.groupBox1.Controls.Add(this.BtnStopHisCar);
            this.groupBox1.Controls.Add(this.BtnAccHisCar);
            this.groupBox1.Controls.Add(this.BtnStartHisCar);
            this.groupBox1.Controls.Add(this.BtnStopMyCar);
            this.groupBox1.Controls.Add(this.BtnAccMyCar);
            this.groupBox1.Controls.Add(this.BtnStartMyCar);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnStartMyTruck
            // 
            this.BtnStartMyTruck.Location = new System.Drawing.Point(144, 175);
            this.BtnStartMyTruck.Name = "BtnStartMyTruck";
            this.BtnStartMyTruck.Size = new System.Drawing.Size(96, 44);
            this.BtnStartMyTruck.TabIndex = 0;
            this.BtnStartMyTruck.Text = "Start My Truck";
            this.BtnStartMyTruck.UseVisualStyleBackColor = true;
            this.BtnStartMyTruck.Click += new System.EventHandler(this.BtnStartMyTruck_Click);
            // 
            // BtnStopHisCar
            // 
            this.BtnStopHisCar.Location = new System.Drawing.Point(259, 112);
            this.BtnStopHisCar.Name = "BtnStopHisCar";
            this.BtnStopHisCar.Size = new System.Drawing.Size(96, 44);
            this.BtnStopHisCar.TabIndex = 0;
            this.BtnStopHisCar.Text = "Stop His Car";
            this.BtnStopHisCar.UseVisualStyleBackColor = true;
            this.BtnStopHisCar.Click += new System.EventHandler(this.BtnStopHisCar_Click);
            // 
            // BtnAccHisCar
            // 
            this.BtnAccHisCar.Location = new System.Drawing.Point(144, 112);
            this.BtnAccHisCar.Name = "BtnAccHisCar";
            this.BtnAccHisCar.Size = new System.Drawing.Size(96, 44);
            this.BtnAccHisCar.TabIndex = 0;
            this.BtnAccHisCar.Text = "Accelerate His Car";
            this.BtnAccHisCar.UseVisualStyleBackColor = true;
            this.BtnAccHisCar.Click += new System.EventHandler(this.BtnAccHisCar_Click);
            // 
            // BtnStartHisCar
            // 
            this.BtnStartHisCar.Location = new System.Drawing.Point(27, 112);
            this.BtnStartHisCar.Name = "BtnStartHisCar";
            this.BtnStartHisCar.Size = new System.Drawing.Size(96, 44);
            this.BtnStartHisCar.TabIndex = 0;
            this.BtnStartHisCar.Text = "Start His Car";
            this.BtnStartHisCar.UseVisualStyleBackColor = true;
            this.BtnStartHisCar.Click += new System.EventHandler(this.BtnStartHisCar_Click);
            // 
            // BtnStopMyCar
            // 
            this.BtnStopMyCar.Location = new System.Drawing.Point(259, 42);
            this.BtnStopMyCar.Name = "BtnStopMyCar";
            this.BtnStopMyCar.Size = new System.Drawing.Size(96, 44);
            this.BtnStopMyCar.TabIndex = 0;
            this.BtnStopMyCar.Text = "Stop My Car";
            this.BtnStopMyCar.UseVisualStyleBackColor = true;
            this.BtnStopMyCar.Click += new System.EventHandler(this.BtnStopMyCar_Click);
            // 
            // BtnAccMyCar
            // 
            this.BtnAccMyCar.Location = new System.Drawing.Point(144, 42);
            this.BtnAccMyCar.Name = "BtnAccMyCar";
            this.BtnAccMyCar.Size = new System.Drawing.Size(96, 44);
            this.BtnAccMyCar.TabIndex = 0;
            this.BtnAccMyCar.Text = "Accelerate My Car";
            this.BtnAccMyCar.UseVisualStyleBackColor = true;
            this.BtnAccMyCar.Click += new System.EventHandler(this.BtnAccMyCar_Click);
            // 
            // BtnStartMyCar
            // 
            this.BtnStartMyCar.Location = new System.Drawing.Point(27, 42);
            this.BtnStartMyCar.Name = "BtnStartMyCar";
            this.BtnStartMyCar.Size = new System.Drawing.Size(96, 44);
            this.BtnStartMyCar.TabIndex = 0;
            this.BtnStartMyCar.Text = "Start My Car";
            this.BtnStartMyCar.UseVisualStyleBackColor = true;
            this.BtnStartMyCar.Click += new System.EventHandler(this.BtnStartMyCar_Click);
            // 
            // frmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClasses";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.frmClasses_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStartMyTruck;
        private System.Windows.Forms.Button BtnStopHisCar;
        private System.Windows.Forms.Button BtnAccHisCar;
        private System.Windows.Forms.Button BtnStartHisCar;
        private System.Windows.Forms.Button BtnStopMyCar;
        private System.Windows.Forms.Button BtnAccMyCar;
        private System.Windows.Forms.Button BtnStartMyCar;
    }
}