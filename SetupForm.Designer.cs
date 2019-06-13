namespace pluginVivado
{
    partial class SetupForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XilinxTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.runXSimTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.vivadoGUITsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XilinxTsmi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 67);
            // 
            // XilinxTsmi
            // 
            this.XilinxTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runXSimTsmi,
            this.vivadoGUITsmi});
            this.XilinxTsmi.Name = "XilinxTsmi";
            this.XilinxTsmi.Size = new System.Drawing.Size(240, 30);
            this.XilinxTsmi.Text = "Xilinx";
            // 
            // runXSimTsmi
            // 
            this.runXSimTsmi.Name = "runXSimTsmi";
            this.runXSimTsmi.Size = new System.Drawing.Size(252, 30);
            this.runXSimTsmi.Text = "Run xSim";
            this.runXSimTsmi.Click += new System.EventHandler(this.RunXSimTsmi_Click);
            // 
            // vivadoGUITsmi
            // 
            this.vivadoGUITsmi.Name = "vivadoGUITsmi";
            this.vivadoGUITsmi.Size = new System.Drawing.Size(252, 30);
            this.vivadoGUITsmi.Text = "Vivado GUI";
            this.vivadoGUITsmi.Click += new System.EventHandler(this.VivadoGUITsmi_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem XilinxTsmi;
        private System.Windows.Forms.ToolStripMenuItem runXSimTsmi;
        private System.Windows.Forms.ToolStripMenuItem vivadoGUITsmi;
    }
}