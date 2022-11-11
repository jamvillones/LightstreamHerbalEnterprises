using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        static Color ArchivedColor = Color.Gray;
        static Color ActiveColor = Color.DarkGreen;

        static Color RetrieveColor = SystemColors.ActiveCaption;
        static Color ArchiveColor = Color.IndianRed;

        public static void SetRowColor(this DataGridViewRow row, bool isArchived)
        {
            row.DefaultCellStyle.ForeColor = isArchived ? ArchivedColor : ActiveColor;
        }
        public static void SetButtonBehavior(this Button button, bool isArchived)
        {
            button.Text = isArchived ? "Retrieve" : "Archive";
            button.BackColor = isArchived ? RetrieveColor : ArchiveColor;
        }

        public static IEnumerable<TModel> FilterByStatus<TModel>(this IEnumerable<TModel> items, int index) where TModel : class, IArchivable
        {
            var status = (ArchiveStatus)index;
            switch (status)
            {
                case ArchiveStatus.Active:
                    return items.Where(i => !i.IsArchived);

                case ArchiveStatus.Inactive:
                    return items.Where(i => i.IsArchived);
            }

            return items;
        }

        public static void LoadArchiveStatus(this ComboBox option)
        {
            for (int i = 0; i < (int)ArchiveStatus.Count; i++)
                option.Items.Add((ArchiveStatus)i);

            option.SelectedIndex = 0;
        }
    }
}
