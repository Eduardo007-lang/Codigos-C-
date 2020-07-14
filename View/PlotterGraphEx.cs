using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;
using TP1.Model;


namespace TP1.View
{        
    public partial class PlotterDisplayEx : UserControl
    {         

        delegate void InvokeVoidFuncDelegate();

        PlotterGraphSelectCurvesForm GraphPropertiesForm = null;
        PrintPreviewForm printPreviewForm = null;

        private Model.PrecisionTimer.Timer mTimer = null;
        private float play_speed = 0.5f;
        private float play_speed_max = 10f;
        private float play_speed_min = 0.5f;

        private bool paused = false;
        private bool isRunning = false;


        public PlotterDisplayEx()
        {
            InitializeComponent();
            mTimer = new Model.PrecisionTimer.Timer();
            mTimer.Period = 50;                        
            mTimer.Tick += new EventHandler(OnTimerTick);
            play_speed = 0.5f;
            mTimer.Start();
            isRunning = false;
        }
       
        void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String text = e.ClickedItem.Text;
            foreach (DataSource s in gPane.Sources)
            {
                if (s.Name == text)
                {
                    s.Active ^= true;
                    gPane.Invalidate();
                    break;
                }
            }
        }
         

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(System.ComponentModel.Design.CollectionEditor),
               typeof(System.Drawing.Design.UITypeEditor))]
        public List<DataSource> DataSources
        {
            get { return gPane.Sources; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(System.ComponentModel.Design.CollectionEditor),
               typeof(System.Drawing.Design.UITypeEditor))]
        public PlotterGraphPaneEx.LayoutMode PanelLayout
        {
            get { return gPane.layout; }
            set { gPane.layout = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(System.ComponentModel.Design.CollectionEditor),
               typeof(System.Drawing.Design.UITypeEditor))]
        public SmoothingMode Smoothing
        {
            get { return gPane.smoothing; }
            set { gPane.smoothing = value; }
        }

        [Category("Playback")]
        [DefaultValue(typeof(float), "2")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float PlaySpeed
        {
            get { return play_speed; }
            set { play_speed = value; }
        }

        [Category("Playback")]
        [DefaultValue(typeof(bool), "true")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowMovingGrid
        {
            get { return gPane.hasMovingGrid; }
            set { gPane.hasMovingGrid = value; }
        }


        [Category("Properties")]   
        [DefaultValue(typeof(Color), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColorTop
        {
            get { return gPane.BgndColorTop; }
            set { gPane.BgndColorTop = value; }
        }

        [Category("Properties")]  
        [DefaultValue(typeof(Color), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColorBot
        {
            get { return gPane.BgndColorBot; }
            set { gPane.BgndColorBot = value; }
        }

        [Category("Properties")]  
        [DefaultValue(typeof(Color), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color DashedGridColor
        {
            get { return gPane.MinorGridColor; }
            set { gPane.MinorGridColor = value; }
        }

        [Category("Properties")]
        [DefaultValue(typeof(Color), "")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color SolidGridColor
        {
            get { return gPane.MajorGridColor; }
            set { gPane.MajorGridColor = value; }
        }
                
      
        public bool DoubleBuffering
        {
            get { return gPane.useDoubleBuffer; }
            set { gPane.useDoubleBuffer = value; }
        }

        #region PUBLIC METHODS

        public void SetDisplayRangeX(float x_start, float x_end )
        {
            gPane.XD0 = x_start;
            gPane.XD1 = x_end;
            gPane.CurXD0 = gPane.XD0;
            gPane.CurXD1 = gPane.XD1;
        }
       
        public void SetGridDistanceX(float grid_dist_x_samples)
        {
            gPane.grid_distance_x = grid_dist_x_samples;           
        }
      
        public void SetGridOriginX(float off_x)
        {
            gPane.grid_off_x = off_x;          
        }

        
        #endregion

        #region PRIVATE METHODS

        protected override void Dispose(bool disposing)
        {
            paused = true;

            if (mTimer.IsRunning)
            {
                mTimer.Stop();
                mTimer.Dispose();
            }
            
            base.Dispose(disposing);
        }

        public void Start()
        {
            if (isRunning == false && paused == false)
            {
                gPane.starting_idx = 0;
                paused = false;
                isRunning = true;
               // mTimer.Start();                
                tb1.Buttons[0].ImageIndex = 2;                
            }
            else
            {
                if (paused == false)
                {
                    //mTimer.Stop();
                    paused = true;
                }
                else
                {
                   // mTimer.Start();
                    paused = false;
                }

                if (paused)
                {
                    
                    tb1.Buttons[0].ImageIndex = 0;  
                }
                else
                {
                   
                    tb1.Buttons[0].ImageIndex = 2;  
                }
            }
        }

        public void Stop()
        {
            if (isRunning)
            {
               // mTimer.Stop();
                isRunning = false;
                paused = false;
                tb1.Buttons[0].ImageIndex = 0;
            }
        }

       
        private void tb1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            bool pushed = e.Button.Pushed;
            switch (e.Button.Tag.ToString().ToLower())
            {
                case "play":

                    Start();
                      
                    break;

                case "stop":

                    Stop();
                   
                    break;       
              
                case "print":

                    ShowPrintPreview();

                    break;
            }
        }

        private void SetPlayPanelVisible()
        {          
            tb1.Buttons[0].Visible = true;
            tb1.Buttons[1].Visible = true;
        }

        public void SetPlayPanelInvisible()
        {
            tb1.Buttons[0].Visible = false;
            tb1.Buttons[1].Visible = false;
            
        }

        private void UpdateControl()
        {
            try
            {
                bool AllAutoscaled = true;

                foreach (DataSource s in gPane.Sources)
                {
                    AllAutoscaled &= s.AutoScaleX;
                }
           
            }
            catch
            {
            }
        }

        private void UpdatePlayback()
        {
            if (!paused && isRunning == true)
            {
                try
                {
                    gPane.starting_idx += play_speed;
                    UpdateScrollBar();
                    gPane.Invalidate();
                }
                catch { }
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            UpdateControl();

            UpdatePlayback();
        }
        
        private void UpdateScrollBar()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(UpdateScrollBar));
            }
            else
            {
                if (gPane.Sources.Count > 0)
                {
                    if (gPane.starting_idx > gPane.Sources[0].Length)
                    {
                    }
                    else if (gPane.starting_idx >= 0)
                    {
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }
        }
         
        private void OnScrollbarScroll(object sender, ScrollEventArgs e)
        {
            if (gPane.Sources.Count > 0)
            {
                gPane.starting_idx = (int)(gPane.Sources[0].Length * 1 / 10000.0f);
                gPane.Invalidate();
            }
        }

        private void OnScrollBarSpeedScroll(object sender, ScrollEventArgs e)
        {
            float delta = play_speed_max - play_speed_min;
            play_speed = play_speed_min + 1 * delta;
        }

        #endregion

        private void ShowPrintPreview()
        {
            if (printPreviewForm == null)
            {
                printPreviewForm = new PrintPreviewForm();
            }

            printPreviewForm.GraphPanel = this.gPane;
            printPreviewForm.Show();
            printPreviewForm.TopMost = true;
            printPreviewForm.Invalidate();
        }

        private void selectGraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GraphPropertiesForm == null)
            {
                GraphPropertiesForm = new PlotterGraphSelectCurvesForm();              
            }
                      
            GraphPropertiesForm.GraphPanel = this.gPane;            
            GraphPropertiesForm.Show();            
        }

        private void Back_Home_btn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            this.Hide();
        }
    }
}
