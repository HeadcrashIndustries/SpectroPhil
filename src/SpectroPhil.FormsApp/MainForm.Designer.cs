namespace SpectroPhil.FormsApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart1 = new ZedGraph.ZedGraphControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showCieD65CheckBox = new System.Windows.Forms.CheckBox();
            this.smoothCurvesCheckBox = new System.Windows.Forms.CheckBox();
            this.showSpectrumCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comComboBox);
            this.panel1.Controls.Add(this.scanButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 27);
            this.panel1.TabIndex = 1;
            // 
            // comComboBox
            // 
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(3, 3);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.Size = new System.Drawing.Size(75, 21);
            this.comComboBox.TabIndex = 2;
            this.comComboBox.DropDown += new System.EventHandler(this.HandleComDropDownDropDown);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(496, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 21);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset View";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.HandleResetButtonClick);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(84, 3);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(63, 21);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.HandleScanButtonClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(728, 497);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.splitContainer2.Panel2MinSize = 370;
            this.splitContainer2.Size = new System.Drawing.Size(728, 395);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(3, 27);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(144, 344);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            this.chart1.ScrollGrace = 0D;
            this.chart1.ScrollMaxX = 0D;
            this.chart1.ScrollMaxY = 0D;
            this.chart1.ScrollMaxY2 = 0D;
            this.chart1.ScrollMinX = 0D;
            this.chart1.ScrollMinY = 0D;
            this.chart1.ScrollMinY2 = 0D;
            this.chart1.Size = new System.Drawing.Size(574, 361);
            this.chart1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showCieD65CheckBox);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.smoothCurvesCheckBox);
            this.panel2.Controls.Add(this.showSpectrumCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 27);
            this.panel2.TabIndex = 4;
            // 
            // showCieD65CheckBox
            // 
            this.showCieD65CheckBox.AutoSize = true;
            this.showCieD65CheckBox.Location = new System.Drawing.Point(214, 5);
            this.showCieD65CheckBox.Name = "showCieD65CheckBox";
            this.showCieD65CheckBox.Size = new System.Drawing.Size(66, 17);
            this.showCieD65CheckBox.TabIndex = 2;
            this.showCieD65CheckBox.Text = "CIE D65";
            this.showCieD65CheckBox.UseVisualStyleBackColor = true;
            this.showCieD65CheckBox.CheckedChanged += new System.EventHandler(this.HandleShowSpectrumCheckBoxCheckedChanged);
            // 
            // smoothCurvesCheckBox
            // 
            this.smoothCurvesCheckBox.AutoSize = true;
            this.smoothCurvesCheckBox.Location = new System.Drawing.Point(110, 5);
            this.smoothCurvesCheckBox.Name = "smoothCurvesCheckBox";
            this.smoothCurvesCheckBox.Size = new System.Drawing.Size(98, 17);
            this.smoothCurvesCheckBox.TabIndex = 1;
            this.smoothCurvesCheckBox.Text = "Smooth Curves";
            this.smoothCurvesCheckBox.UseVisualStyleBackColor = true;
            this.smoothCurvesCheckBox.CheckedChanged += new System.EventHandler(this.HandleSmoothCurvesCheckBoxCheckedChanged);
            // 
            // showSpectrumCheckBox
            // 
            this.showSpectrumCheckBox.AutoSize = true;
            this.showSpectrumCheckBox.Location = new System.Drawing.Point(3, 6);
            this.showSpectrumCheckBox.Name = "showSpectrumCheckBox";
            this.showSpectrumCheckBox.Size = new System.Drawing.Size(101, 17);
            this.showSpectrumCheckBox.TabIndex = 0;
            this.showSpectrumCheckBox.Text = "Show Spectrum";
            this.showSpectrumCheckBox.UseVisualStyleBackColor = true;
            this.showSpectrumCheckBox.CheckedChanged += new System.EventHandler(this.HandleShowSpectrumCheckBoxCheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 92);
            this.textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 371);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Size = new System.Drawing.Size(150, 24);
            this.panel3.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 21);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear Samples";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.HandleClearButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 497);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "MainForm";
            this.Text = "SpectroPhil";
            this.Load += new System.EventHandler(this.HandleMainFormLoad);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button scanButton;
		private System.Windows.Forms.Button resetButton;
		private ZedGraph.ZedGraphControl chart1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox smoothCurvesCheckBox;
		private System.Windows.Forms.CheckBox showSpectrumCheckBox;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.CheckBox showCieD65CheckBox;
        private System.Windows.Forms.ComboBox comComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearButton;
    }
}

