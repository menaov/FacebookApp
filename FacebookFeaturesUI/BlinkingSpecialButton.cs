using System;
using System.Drawing;

namespace FacebookFeaturesUI
{
    public class BlinkingSpecialButton : SpecialButton
    {
        public BlinkingSpecialButton(Color i_Original, Color i_Blink)
        {
            m_OriginalColor = i_Original;
            m_BlinkingColor = i_Blink;
        }

        public Color m_OriginalColor
        {
            get;
            set;
        }

        public Color m_BlinkingColor
        {
            get;
            set;
        }

        protected override void Effect(object sender, EventArgs e)
        {
            BackColor = BackColor == m_OriginalColor ? m_BlinkingColor : m_OriginalColor;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            BackColor = m_OriginalColor;
        }
    }
}
