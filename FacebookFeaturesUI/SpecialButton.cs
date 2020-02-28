using System;
using System.Drawing.Drawing2D;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookFeaturesUI
{
    public abstract class SpecialButton : Button
    {
        private Timer m_Timer;

        public SpecialButton()
        {
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Click += StopEffect;
        }

        public void StartEffect()
        {
            m_Timer = new Timer();
            m_Timer.Interval = 500;
            m_Timer.Tick += Effect;
            m_Timer.Start();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, Width, Height);
            Region = new Region(grPath);
            base.OnPaint(pevent);
        }

        protected void StopEffect(object sender, EventArgs e)
        {
            m_Timer.Stop();
        }

        protected abstract void Effect(object sender, EventArgs e);
    }
}
