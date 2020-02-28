using System.Windows.Forms;

namespace FacebookFeaturesUI
{
    public abstract class VisitableForm : Form
    {
        public void Accept(IFormsVisitor i_Visitor)
        {
            i_Visitor.Invoke(this);
        }
    }
}
