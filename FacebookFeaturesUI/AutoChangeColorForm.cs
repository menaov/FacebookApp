using System;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookFeaturesUI
{
    public class AutoChangeColorForm : IFormsVisitor
    {
        private readonly Color[] r_Colors = new Color[14] { Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightSkyBlue, Color.LightBlue, Color.LightCoral, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow };
        private Timer m_Timer = new Timer();
        private int m_CurrentColor = 0;
        private VisitableForm m_MyVisitableForm;

        public void Invoke(VisitableForm i_VisitableForm)
        {
            m_MyVisitableForm = i_VisitableForm;
            m_Timer.Interval = 500;
            m_Timer.Tick += blinkControl;
            m_Timer.Start();
        }

        private void blinkControl(object sender, EventArgs e)
        {
            m_CurrentColor = (++m_CurrentColor) % r_Colors.Length;
            m_MyVisitableForm.BackColor = r_Colors[m_CurrentColor];
        }
    }
}
