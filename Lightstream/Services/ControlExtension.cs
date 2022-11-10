using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public static Color ArchivedColor = Color.Gray;
        public static Color ActiveColor = Color.Black;

        public static void SetRowColor(this DataGridViewRow row, bool isArchived)
        {
            row.DefaultCellStyle.ForeColor = isArchived ? ArchivedColor : ActiveColor;
        }
        public static void SetButtonBehavior(this Button button, bool isArchived)
        {
            button.Text = isArchived ? "Retrieve" : "Archive";
        }
    }
}
