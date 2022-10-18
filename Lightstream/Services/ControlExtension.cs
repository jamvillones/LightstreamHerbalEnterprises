using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Extensions
{
    public static class ControlExtension
    {
        public static void InvokeIfRequired(this Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action.Invoke();
        }

        public static DialogResult OpenFormModal(this Form control, FormClosedEventHandler closingCallback = null)
        {
            using (control)
            {
                if (closingCallback != null)
                    control.FormClosed += closingCallback;

                return control.ShowDialog();
            }
        }


    }
}
