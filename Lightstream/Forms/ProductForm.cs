﻿using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private BindingList<Recipe> recipes = new BindingList<Recipe>();
        private void addIngBtn_Click(object sender, EventArgs e)
        {
            using (var recimeForm = new RecipeForm())
            {
                if (recimeForm.ShowDialog() == DialogResult.OK)
                {
                    var recipe = recimeForm.RecipeDetails;
                    if (RecipeValidationSuccessfull(recipe.Ingredient.Name) || _recipe.Items.Count == 0)
                        recipes.Add(recipe);
                }
            }
        }

        private bool RecipeValidationSuccessfull(string incomingIngName)
        {
            return true;
            //   _ingredientsTable.Rows.Cast<DataGridViewRow>().Any(x =>
            //!string.Equals(incomingIngName, x.Cells[3].Value.ToString(), StringComparison.OrdinalIgnoreCase)
            //);
            //return a.ToLower().Trim() != b.ToLower().Trim();
        }

        /// <summary>
        /// create datagridrow, centralized
        /// </summary>
        /// <param name="d"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private DataGridViewRow CreateRow(DataGridView d, Recipe r)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(d,
                r.Id,
                r.Qty,
                r.Conversion == null ? r.Ingredient.UnitMeasurement.Name : r.Conversion.FromUnit.Name,
                r.Ingredient.Name
                );
            return row;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _recipe.DataSource = recipes;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
