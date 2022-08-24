using Interface.Components;

namespace Interface
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.compilarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.infoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new Interface.Components.RichtTextBoxNoZoom();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.toolStripSeparator,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.recortarToolStripButton,
            this.toolStripSeparator1,
            this.compilarToolStripButton,
            this.infoToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(900, 70);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(900, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            this.novaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novaToolStripButton.Image")));
            this.novaToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novaToolStripButton.Name = "novaToolStripButton";
            this.novaToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.novaToolStripButton.Size = new System.Drawing.Size(98, 67);
            this.novaToolStripButton.Text = "&novo [ctrl-n]";
            this.novaToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.novaToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.novaToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.novaToolStripButton.Click += new System.EventHandler(this.novaToolStripButton_Click);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.abrirToolStripButton.Size = new System.Drawing.Size(95, 67);
            this.abrirToolStripButton.Text = "&abrir [ctrl-o]";
            this.abrirToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abrirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abrirToolStripButton.ToolTipText = "abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.salvarToolStripButton.Size = new System.Drawing.Size(99, 67);
            this.salvarToolStripButton.Text = "&salvar [ctrl-s]";
            this.salvarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salvarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.copiarToolStripButton.Size = new System.Drawing.Size(103, 67);
            this.copiarToolStripButton.Text = "copiar [ctrl-c]";
            this.copiarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copiarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.colarToolStripButton.Size = new System.Drawing.Size(96, 67);
            this.colarToolStripButton.Text = "colar [ctrl-v]";
            this.colarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.recortarToolStripButton.Size = new System.Drawing.Size(111, 67);
            this.recortarToolStripButton.Text = "recortar [ctrl-x]";
            this.recortarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recortarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // compilarToolStripButton
            // 
            this.compilarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("compilarToolStripButton.Image")));
            this.compilarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compilarToolStripButton.Name = "compilarToolStripButton";
            this.compilarToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.compilarToolStripButton.Size = new System.Drawing.Size(101, 67);
            this.compilarToolStripButton.Text = "compilar [F7]";
            this.compilarToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compilarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // infoToolStripButton
            // 
            this.infoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripButton.Image")));
            this.infoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoToolStripButton.Name = "infoToolStripButton";
            this.infoToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.infoToolStripButton.Size = new System.Drawing.Size(90, 67);
            this.infoToolStripButton.Text = "equipe [F1]";
            this.infoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(900, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 20);
            this.toolStripStatusLabel1.Text = "pasta\\nome do arquivo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.LineNumberTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(894, 326);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(34, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(860, 206);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Enabled = false;
            this.LineNumberTextBox.Location = new System.Drawing.Point(0, 0);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(34, 206);
            this.LineNumberTextBox.TabIndex = 0;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.WordWrap = false;
            this.LineNumberTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.LineNumberTextBox_ContentsResized);
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(894, 116);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 421);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(899, 422);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton infoToolStripButton;
        private StatusStrip statusStrip1;
        private ToolStripButton compilarToolStripButton;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private RichTextBox LineNumberTextBox;
        private RichtTextBoxNoZoom richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}