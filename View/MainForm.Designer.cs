namespace TP1.View
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
            this.Graph_Menu_Drag = new System.Windows.Forms.MenuStrip();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyAlignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyAlignedAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledVerticalAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledHorizontalAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animatedGraphDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.display = new TP1.View.PlotterDisplayEx();
            this.Graph_DragControl = new TP1.Model.Custom_DragControl();
            this.Exit_btn = new ns1.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back_Home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Graph_Menu_Drag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graph_Menu_Drag
            // 
            this.Graph_Menu_Drag.Dock = System.Windows.Forms.DockStyle.None;
            this.Graph_Menu_Drag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem});
            this.Graph_Menu_Drag.Location = new System.Drawing.Point(646, 2);
            this.Graph_Menu_Drag.Name = "Graph_Menu_Drag";
            this.Graph_Menu_Drag.Size = new System.Drawing.Size(69, 24);
            this.Graph_Menu_Drag.TabIndex = 2;
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examplesToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.layoutToolStripMenuItem.Text = "Settings";
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticallyAlignedToolStripMenuItem,
            this.verticallyAlignedAutoscaledToolStripMenuItem,
            this.tiledVerticalToolStripMenuItem,
            this.tiledVerticalAutoscaledToolStripMenuItem,
            this.tiledHorizontalToolStripMenuItem,
            this.tiledHorizontalAutoscaledToolStripMenuItem,
            this.animatedGraphDemoToolStripMenuItem});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.ShowShortcutKeys = false;
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // verticallyAlignedToolStripMenuItem
            // 
            this.verticallyAlignedToolStripMenuItem.Name = "verticallyAlignedToolStripMenuItem";
            this.verticallyAlignedToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.verticallyAlignedToolStripMenuItem.Text = "Vertically Aligned";
            this.verticallyAlignedToolStripMenuItem.Click += new System.EventHandler(this.verticallyAlignedToolStripMenuItem_Click);
            // 
            // verticallyAlignedAutoscaledToolStripMenuItem
            // 
            this.verticallyAlignedAutoscaledToolStripMenuItem.Name = "verticallyAlignedAutoscaledToolStripMenuItem";
            this.verticallyAlignedAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.verticallyAlignedAutoscaledToolStripMenuItem.Text = "Vertically Aligned Autoscaled";
            this.verticallyAlignedAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.verticallyAlignedAutoscaledToolStripMenuItem_Click);
            // 
            // tiledVerticalToolStripMenuItem
            // 
            this.tiledVerticalToolStripMenuItem.Name = "tiledVerticalToolStripMenuItem";
            this.tiledVerticalToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tiledVerticalToolStripMenuItem.Text = "Tiled Vertical";
            this.tiledVerticalToolStripMenuItem.Click += new System.EventHandler(this.tiledVerticalToolStripMenuItem_Click);
            // 
            // tiledVerticalAutoscaledToolStripMenuItem
            // 
            this.tiledVerticalAutoscaledToolStripMenuItem.Name = "tiledVerticalAutoscaledToolStripMenuItem";
            this.tiledVerticalAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tiledVerticalAutoscaledToolStripMenuItem.Text = "Tiled Vertical Autoscaled";
            this.tiledVerticalAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.tiledVerticalAutoscaledToolStripMenuItem_Click);
            // 
            // tiledHorizontalToolStripMenuItem
            // 
            this.tiledHorizontalToolStripMenuItem.Name = "tiledHorizontalToolStripMenuItem";
            this.tiledHorizontalToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tiledHorizontalToolStripMenuItem.Text = "Tiled Horizontal";
            this.tiledHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tiledHorizontalToolStripMenuItem_Click);
            // 
            // tiledHorizontalAutoscaledToolStripMenuItem
            // 
            this.tiledHorizontalAutoscaledToolStripMenuItem.Name = "tiledHorizontalAutoscaledToolStripMenuItem";
            this.tiledHorizontalAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tiledHorizontalAutoscaledToolStripMenuItem.Text = "Tiled Horizontal Autoscaled";
            this.tiledHorizontalAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.tiledHorizontalAutoscaledToolStripMenuItem_Click);
            // 
            // animatedGraphDemoToolStripMenuItem
            // 
            this.animatedGraphDemoToolStripMenuItem.Name = "animatedGraphDemoToolStripMenuItem";
            this.animatedGraphDemoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.animatedGraphDemoToolStripMenuItem.Text = "Animated Graph Demo";
            this.animatedGraphDemoToolStripMenuItem.Click += new System.EventHandler(this.animatedGraphDemoToolStripMenuItem_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Transparent;
            this.display.BackgroundColorBot = System.Drawing.Color.White;
            this.display.BackgroundColorTop = System.Drawing.Color.White;
            this.display.DashedGridColor = System.Drawing.Color.DarkGray;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.DoubleBuffering = false;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.PlaySpeed = 0.5F;
            this.display.Size = new System.Drawing.Size(779, 462);
            this.display.SolidGridColor = System.Drawing.Color.DarkGray;
            this.display.TabIndex = 3;
            // 
            // Graph_DragControl
            // 
            this.Graph_DragControl.Select_Control = this.Graph_Menu_Drag;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Activecolor = System.Drawing.Color.Firebrick;
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.Silver;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.BorderRadius = 0;
            this.Exit_btn.ButtonText = "x";
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_btn.Iconimage = null;
            this.Exit_btn.Iconimage_right = null;
            this.Exit_btn.Iconimage_right_Selected = null;
            this.Exit_btn.Iconimage_Selected = null;
            this.Exit_btn.IconMarginLeft = 0;
            this.Exit_btn.IconMarginRight = 0;
            this.Exit_btn.IconRightVisible = true;
            this.Exit_btn.IconRightZoom = 0D;
            this.Exit_btn.IconVisible = true;
            this.Exit_btn.IconZoom = 90D;
            this.Exit_btn.IsTab = false;
            this.Exit_btn.Location = new System.Drawing.Point(731, 2);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Normalcolor = System.Drawing.Color.Silver;
            this.Exit_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit_btn.selected = false;
            this.Exit_btn.Size = new System.Drawing.Size(48, 29);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "x";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_btn.Textcolor = System.Drawing.Color.White;
            this.Exit_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_Home_btn);
            this.panel1.Controls.Add(this.Graph_Menu_Drag);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.display);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 462);
            this.panel2.TabIndex = 6;
            // 
            // Back_Home_btn
            // 
            this.Back_Home_btn.Active = false;
            this.Back_Home_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Back_Home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Back_Home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Home_btn.BorderRadius = 0;
            this.Back_Home_btn.ButtonText = "<";
            this.Back_Home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Home_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Back_Home_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Back_Home_btn.Iconimage = null;
            this.Back_Home_btn.Iconimage_right = null;
            this.Back_Home_btn.Iconimage_right_Selected = null;
            this.Back_Home_btn.Iconimage_Selected = null;
            this.Back_Home_btn.IconMarginLeft = 0;
            this.Back_Home_btn.IconMarginRight = 0;
            this.Back_Home_btn.IconRightVisible = true;
            this.Back_Home_btn.IconRightZoom = 0D;
            this.Back_Home_btn.IconVisible = true;
            this.Back_Home_btn.IconZoom = 90D;
            this.Back_Home_btn.IsTab = false;
            this.Back_Home_btn.Location = new System.Drawing.Point(0, 0);
            this.Back_Home_btn.Name = "Back_Home_btn";
            this.Back_Home_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Back_Home_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Back_Home_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Back_Home_btn.selected = false;
            this.Back_Home_btn.Size = new System.Drawing.Size(21, 34);
            this.Back_Home_btn.TabIndex = 9;
            this.Back_Home_btn.Text = "<";
            this.Back_Home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back_Home_btn.Textcolor = System.Drawing.Color.White;
            this.Back_Home_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Graph_Menu_Drag;
            this.Name = "MainForm";
            this.Text = "Eletromiograma(EMG)";
            this.Graph_Menu_Drag.ResumeLayout(false);
            this.Graph_Menu_Drag.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip Graph_Menu_Drag;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private PlotterDisplayEx display;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticallyAlignedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticallyAlignedAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledVerticalAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledHorizontalAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animatedGraphDemoToolStripMenuItem;
        private Model.Custom_DragControl Graph_DragControl;
        private ns1.BunifuFlatButton Exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Back_Home_btn;
    }
}

