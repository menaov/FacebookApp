using System;

namespace FacebookFeaturesUI
{
    public class AutoSizeSpecialButton : SpecialButton
    {
        private const float k_Threshold = 0.2f;
        private readonly int r_DeltaWidth;
        private readonly int r_DeltaHeight;
        private int m_DeltaFactor = -1;

        public AutoSizeSpecialButton()
        {
            r_DeltaWidth = (int)(Width * k_Threshold);
            r_DeltaHeight = (int)(Height * k_Threshold);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (m_DeltaFactor == 1)
            {
                Width += r_DeltaWidth * m_DeltaFactor;
                Height += r_DeltaHeight * m_DeltaFactor;
                m_DeltaFactor = -1;
            }
        }

        protected override void Effect(object sender, EventArgs e)
        {
            Width += r_DeltaWidth * m_DeltaFactor;
            Height += r_DeltaHeight * m_DeltaFactor;
            m_DeltaFactor *= -1;
        }
    }
}
