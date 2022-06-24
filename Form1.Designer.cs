namespace CliffordAttractor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.randomizeBtn = new System.Windows.Forms.Panel();
            this.numPointsL = new System.Windows.Forms.Label();
            this.resSlider = new System.Windows.Forms.TrackBar();
            this.exportBtn = new System.Windows.Forms.Button();
            this.border1 = new System.Windows.Forms.Label();
            this.randomizerBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.DLabel = new System.Windows.Forms.Label();
            this.DSlider = new System.Windows.Forms.TrackBar();
            this.CLabel = new System.Windows.Forms.Label();
            this.CSlider = new System.Windows.Forms.TrackBar();
            this.BLabel = new System.Windows.Forms.Label();
            this.BSlider = new System.Windows.Forms.TrackBar();
            this.ASlider = new System.Windows.Forms.TrackBar();
            this.ALabel = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randomizeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASlider)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Controls.Add(this.numPointsL);
            this.randomizeBtn.Controls.Add(this.resSlider);
            this.randomizeBtn.Controls.Add(this.exportBtn);
            this.randomizeBtn.Controls.Add(this.border1);
            this.randomizeBtn.Controls.Add(this.randomizerBtn);
            this.randomizeBtn.Controls.Add(this.drawBtn);
            this.randomizeBtn.Controls.Add(this.DLabel);
            this.randomizeBtn.Controls.Add(this.DSlider);
            this.randomizeBtn.Controls.Add(this.CLabel);
            this.randomizeBtn.Controls.Add(this.CSlider);
            this.randomizeBtn.Controls.Add(this.BLabel);
            this.randomizeBtn.Controls.Add(this.BSlider);
            this.randomizeBtn.Controls.Add(this.ASlider);
            this.randomizeBtn.Controls.Add(this.ALabel);
            this.randomizeBtn.Controls.Add(this.instructions);
            this.randomizeBtn.Controls.Add(this.header);
            this.randomizeBtn.Location = new System.Drawing.Point(9, 11);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(358, 924);
            this.randomizeBtn.TabIndex = 0;
            // 
            // numPointsL
            // 
            this.numPointsL.AutoSize = true;
            this.numPointsL.Location = new System.Drawing.Point(15, 446);
            this.numPointsL.Name = "numPointsL";
            this.numPointsL.Size = new System.Drawing.Size(253, 20);
            this.numPointsL.TabIndex = 16;
            this.numPointsL.Text = "Resolution of preview: 100000 points";
            // 
            // resSlider
            // 
            this.resSlider.Location = new System.Drawing.Point(9, 469);
            this.resSlider.Maximum = 200000;
            this.resSlider.Minimum = 10;
            this.resSlider.Name = "resSlider";
            this.resSlider.Size = new System.Drawing.Size(340, 56);
            this.resSlider.TabIndex = 15;
            this.resSlider.TickFrequency = 6000;
            this.resSlider.Value = 100000;
            this.resSlider.Scroll += new System.EventHandler(this.resSlider_Scroll);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(15, 582);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(152, 29);
            this.exportBtn.TabIndex = 14;
            this.exportBtn.Text = "Export Image";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // border1
            // 
            this.border1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border1.Location = new System.Drawing.Point(0, 567);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(357, 1);
            this.border1.TabIndex = 12;
            // 
            // randomizerBtn
            // 
            this.randomizerBtn.Location = new System.Drawing.Point(129, 531);
            this.randomizerBtn.Name = "randomizerBtn";
            this.randomizerBtn.Size = new System.Drawing.Size(216, 29);
            this.randomizerBtn.TabIndex = 11;
            this.randomizerBtn.Text = "Randomize Parameters";
            this.randomizerBtn.UseVisualStyleBackColor = true;
            this.randomizerBtn.Click += new System.EventHandler(this.randomizerBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(15, 531);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(94, 29);
            this.drawBtn.TabIndex = 10;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(15, 364);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(39, 20);
            this.DLabel.TabIndex = 9;
            this.DLabel.Text = "d: -2";
            // 
            // DSlider
            // 
            this.DSlider.Location = new System.Drawing.Point(9, 387);
            this.DSlider.Maximum = 30000;
            this.DSlider.Minimum = -30000;
            this.DSlider.Name = "DSlider";
            this.DSlider.Size = new System.Drawing.Size(340, 56);
            this.DSlider.TabIndex = 8;
            this.DSlider.TickFrequency = 1000;
            this.DSlider.Value = -20000;
            this.DSlider.Scroll += new System.EventHandler(this.DSlider_Scroll);
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(15, 284);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(48, 20);
            this.CLabel.TabIndex = 7;
            this.CLabel.Text = "c: -1.2";
            // 
            // CSlider
            // 
            this.CSlider.Location = new System.Drawing.Point(9, 307);
            this.CSlider.Maximum = 30000;
            this.CSlider.Minimum = -30000;
            this.CSlider.Name = "CSlider";
            this.CSlider.Size = new System.Drawing.Size(340, 56);
            this.CSlider.TabIndex = 6;
            this.CSlider.TickFrequency = 1000;
            this.CSlider.Value = -12000;
            this.CSlider.Scroll += new System.EventHandler(this.CSlider_Scroll);
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(15, 205);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(39, 20);
            this.BLabel.TabIndex = 5;
            this.BLabel.Text = "b: -2";
            // 
            // BSlider
            // 
            this.BSlider.Location = new System.Drawing.Point(9, 228);
            this.BSlider.Maximum = 30000;
            this.BSlider.Minimum = -30000;
            this.BSlider.Name = "BSlider";
            this.BSlider.Size = new System.Drawing.Size(340, 56);
            this.BSlider.TabIndex = 4;
            this.BSlider.TickFrequency = 1000;
            this.BSlider.Value = -20000;
            this.BSlider.Scroll += new System.EventHandler(this.BSlider_Scroll);
            // 
            // ASlider
            // 
            this.ASlider.Location = new System.Drawing.Point(9, 152);
            this.ASlider.Maximum = 30000;
            this.ASlider.Minimum = -30000;
            this.ASlider.Name = "ASlider";
            this.ASlider.Size = new System.Drawing.Size(340, 56);
            this.ASlider.TabIndex = 3;
            this.ASlider.TickFrequency = 1000;
            this.ASlider.Value = -20000;
            this.ASlider.Scroll += new System.EventHandler(this.ASlider_Scroll);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(15, 117);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(38, 20);
            this.ALabel.TabIndex = 2;
            this.ALabel.Text = "a: -2";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(9, 54);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(336, 63);
            this.instructions.TabIndex = 1;
            this.instructions.Text = "Play with the sliders and click Draw. See what cool patterns you can make!";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(3, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(342, 37);
            this.header.TabIndex = 0;
            this.header.Text = "Clifford Attractor Generator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.previewBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(384, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 924);
            this.panel2.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(3, 14);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(94, 37);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Result:";
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(99, 0);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(950, 924);
            this.previewBox.TabIndex = 14;
            this.previewBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 926);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 947);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.randomizeBtn);
            this.Name = "Form1";
            this.Text = "Clifford Attractor Generator";
            this.randomizeBtn.ResumeLayout(false);
            this.randomizeBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASlider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel randomizeBtn;
        private Label header;
        private Panel panel2;
        private Label instructions;
        private Button randomizerBtn;
        private Button drawBtn;
        private Label DLabel;
        private TrackBar DSlider;
        private Label CLabel;
        private TrackBar CSlider;
        private Label BLabel;
        private TrackBar BSlider;
        private TrackBar ASlider;
        private Label ALabel;
        private Label border1;
        private Label label1;
        private PictureBox previewBox;
        private Label resultLabel;
        private Label numPointsL;
        private TrackBar resSlider;
        private Button exportBtn;
        private Label resQualL;
        private TrackBar qualSlider;
    }
}