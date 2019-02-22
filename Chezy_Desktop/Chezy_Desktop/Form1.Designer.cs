namespace Chezy_Desktop
{
    partial class main_window
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
            this.initQ = new System.Windows.Forms.TextBox();
            this.pSlope = new System.Windows.Forms.TextBox();
            this.rougness = new System.Windows.Forms.TextBox();
            this.initDepth = new System.Windows.Forms.TextBox();
            this.diameter = new System.Windows.Forms.TextBox();
            this.lbl_Flow = new System.Windows.Forms.Label();
            this.lbl_Slope = new System.Windows.Forms.Label();
            this.lbl_Roughness = new System.Windows.Forms.Label();
            this.lbl_initDepth = new System.Windows.Forms.Label();
            this.lbl_diam = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.lbl_calcDepth = new System.Windows.Forms.Label();
            this.calcDepth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // initQ
            // 
            this.initQ.Location = new System.Drawing.Point(123, 53);
            this.initQ.Name = "initQ";
            this.initQ.Size = new System.Drawing.Size(136, 20);
            this.initQ.TabIndex = 0;
            // 
            // pSlope
            // 
            this.pSlope.Location = new System.Drawing.Point(123, 90);
            this.pSlope.Name = "pSlope";
            this.pSlope.Size = new System.Drawing.Size(136, 20);
            this.pSlope.TabIndex = 1;
            // 
            // rougness
            // 
            this.rougness.Location = new System.Drawing.Point(123, 129);
            this.rougness.Name = "rougness";
            this.rougness.Size = new System.Drawing.Size(136, 20);
            this.rougness.TabIndex = 2;
            // 
            // initDepth
            // 
            this.initDepth.Location = new System.Drawing.Point(123, 166);
            this.initDepth.Name = "initDepth";
            this.initDepth.Size = new System.Drawing.Size(136, 20);
            this.initDepth.TabIndex = 3;
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(123, 204);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(136, 20);
            this.diameter.TabIndex = 4;
            // 
            // lbl_Flow
            // 
            this.lbl_Flow.AutoSize = true;
            this.lbl_Flow.Location = new System.Drawing.Point(25, 53);
            this.lbl_Flow.Name = "lbl_Flow";
            this.lbl_Flow.Size = new System.Drawing.Size(62, 13);
            this.lbl_Flow.TabIndex = 5;
            this.lbl_Flow.Text = "Flow [m3/s]";
            // 
            // lbl_Slope
            // 
            this.lbl_Slope.AutoSize = true;
            this.lbl_Slope.Location = new System.Drawing.Point(24, 92);
            this.lbl_Slope.Name = "lbl_Slope";
            this.lbl_Slope.Size = new System.Drawing.Size(82, 13);
            this.lbl_Slope.TabIndex = 6;
            this.lbl_Slope.Text = "Pipe slope [abs]";
            // 
            // lbl_Roughness
            // 
            this.lbl_Roughness.AutoSize = true;
            this.lbl_Roughness.Location = new System.Drawing.Point(26, 132);
            this.lbl_Roughness.Name = "lbl_Roughness";
            this.lbl_Roughness.Size = new System.Drawing.Size(61, 13);
            this.lbl_Roughness.TabIndex = 7;
            this.lbl_Roughness.Text = "Roughness";
            // 
            // lbl_initDepth
            // 
            this.lbl_initDepth.AutoSize = true;
            this.lbl_initDepth.Location = new System.Drawing.Point(26, 169);
            this.lbl_initDepth.Name = "lbl_initDepth";
            this.lbl_initDepth.Size = new System.Drawing.Size(78, 13);
            this.lbl_initDepth.TabIndex = 8;
            this.lbl_initDepth.Text = "Initial depth [m]";
            // 
            // lbl_diam
            // 
            this.lbl_diam.AutoSize = true;
            this.lbl_diam.Location = new System.Drawing.Point(26, 204);
            this.lbl_diam.Name = "lbl_diam";
            this.lbl_diam.Size = new System.Drawing.Size(66, 13);
            this.lbl_diam.TabIndex = 9;
            this.lbl_diam.Text = "Diameter [m]";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(123, 241);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(134, 33);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // lbl_calcDepth
            // 
            this.lbl_calcDepth.Location = new System.Drawing.Point(26, 290);
            this.lbl_calcDepth.Name = "lbl_calcDepth";
            this.lbl_calcDepth.Size = new System.Drawing.Size(91, 15);
            this.lbl_calcDepth.TabIndex = 11;
            this.lbl_calcDepth.Text = "Calculated depth";
            // 
            // calcDepth
            // 
            this.calcDepth.Location = new System.Drawing.Point(123, 290);
            this.calcDepth.Name = "calcDepth";
            this.calcDepth.Size = new System.Drawing.Size(136, 20);
            this.calcDepth.TabIndex = 12;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 349);
            this.Controls.Add(this.calcDepth);
            this.Controls.Add(this.lbl_calcDepth);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.lbl_diam);
            this.Controls.Add(this.lbl_initDepth);
            this.Controls.Add(this.lbl_Roughness);
            this.Controls.Add(this.lbl_Slope);
            this.Controls.Add(this.lbl_Flow);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.initDepth);
            this.Controls.Add(this.rougness);
            this.Controls.Add(this.pSlope);
            this.Controls.Add(this.initQ);
            this.Name = "main_window";
            this.Text = "ChezyCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initQ;
        private System.Windows.Forms.TextBox pSlope;
        private System.Windows.Forms.TextBox rougness;
        private System.Windows.Forms.TextBox initDepth;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.Label lbl_Flow;
        private System.Windows.Forms.Label lbl_Slope;
        private System.Windows.Forms.Label lbl_Roughness;
        private System.Windows.Forms.Label lbl_initDepth;
        private System.Windows.Forms.Label lbl_diam;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label lbl_calcDepth;
        private System.Windows.Forms.TextBox calcDepth;

        private void initQFill(object sender, System.EventArgs e)
        {
           
        }
    }
}

