using Lightstream.Forms;
using Lightstream.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Usercontrols
{
    public partial class IngredientUserControl : UserControl
    {
        private DbContextFactory factory = new DbContextFactory();

        public IngredientUserControl()
        {
            InitializeComponent();
        }

        private void IngredientUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    foreach (var i in context.Ingredients)
                        ingredientsTable.Rows.Add(CreateRow(ingredientsTable, i));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var ingredientForm = new IngredientsForm())
            {
                if (ingredientForm.ShowDialog() == DialogResult.OK)
                    if (ingredientForm.NewItemCreated)
                        ingredientsTable.Rows.Add(CreateRow(ingredientsTable, ingredientForm.CreatedIngredient));
            }
        }

        /// <summary>
        /// create the row for ingredient
        /// </summary>
        /// <param name="d">datagridview</param>
        /// <param name="i">data source for ingredient</param>
        /// <returns></returns>
        DataGridViewRow CreateRow(DataGridView d, Ingredient i)
        {
            var row = new DataGridViewRow();

            row.CreateCells(d,
                i.Id,
                i.Name,
                string.Format("₱ {0:n}", i.Cost),
                i.UnitOfMeasurement,
                "edit",
                "delete"
                );

            return row;
        }

        private void ingredientsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /// check if the index click is not the row index which is -1
            if (e.RowIndex == -1) return;
            /// check the index if 5. 5 which is the index for the delete button 
            if (e.ColumnIndex != 5) return;
            /// add a validation for the delete
            if (MessageBox.Show("Are you sure you want to delete this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            ///get the datagridview who fired the event, check if the one who fired the event is a datagridview and assign it to d
            if (sender is not DataGridView d) return;
            ///get the id. 0 because the id is always in 0 index.
            if (d[0, e.RowIndex].Value is int id)
            {
                ///open connection
                using (var context = factory.CreateDbContext())
                {
                    /// get the item using the id selected during the click
                    var tobeRemoved = context.Ingredients.FirstOrDefault(x => x.Id == id);
                    /// if found
                    if (tobeRemoved is not null)
                    {
                        /// remove from the list
                        context.Ingredients.Remove(tobeRemoved);
                        ///save the changes to the database
                        context.SaveChanges();
                        ///finally, remove the item to the table itself by using the rowindex that is supplied during the click event
                        d.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

        }
    }
}
