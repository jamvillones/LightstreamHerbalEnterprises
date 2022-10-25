using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class RecipeForm : Form
    {
        private DbContextFactory factory = new DbContextFactory();
        public RecipeForm()
        {
            InitializeComponent();
        }
        List<Unit> AvailableUnits { get; set; } = null!;
        List<Conversion> AvailableConversion { get; set; } = null!;
        private void RecipeForm_Load(object sender, EventArgs e)
        {
            using (var context = factory.CreateDbContext())
            {
                var ingredients = context.Ingredients.Include(x => x.UnitMeasurement)
                    .Select(a => new { Value = a, Key = a.Name + " in " + a.UnitMeasurement.SingularName })
                    .ToArray();

                ingredientOption.DataSource = ingredients;

                AvailableUnits = context.Units.ToList();

                unitOption.DataSource = AvailableUnits;

                AvailableConversion = context.Conversions
                    .Include(x => x.FromUnit)
                    .Include(y => y.ToUnit)
                    .ToList();
            }
        }
        Conversion? selectedConversion = null;

        //bool isFound;
        private void ingredientOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ingredientOption.SelectedValue is Ingredient ing && unitOption.SelectedItem is Unit fromUnit)
            {
                bool isFound = IsConversionAvailable(fromUnit, ing.UnitMeasurement, out selectedConversion);

                //addConversionBtn.Enabled = !isFound;
                //saveBtn.Visible = isFound;
                _save.Text = isFound ? "Save" : "Define Conversion";
                _save.BackColor = isFound ? SystemColors.ActiveCaption : Color.IndianRed;
            }
        }

        bool IsConversionAvailable(Unit from, Unit to, out Conversion? conversion)
        {
            if (from.Id == to.Id)
            {
                conversion = null;
                return true;
            }

            conversion = AvailableConversion.FirstOrDefault(x => x.FromUnitId == from.Id && x.ToUnitId == to.Id);

            return conversion != null;
        }

        void OpenConversionCreation()
        {
            using (var conversion = new ConversionForm
                (
                (Unit)(unitOption.SelectedItem),
                ((Ingredient)(ingredientOption.SelectedValue)).UnitMeasurement)
                )
            {
                if (conversion.ShowDialog() == DialogResult.OK)
                {
                    var result = conversion.ResultConversion;
                    if (result is not null)
                    {
                        AvailableConversion.Add(result);
                        if (ingredientOption.SelectedValue is Ingredient ing && unitOption.SelectedItem is Unit fromUnit)
                        {
                            bool isFound = IsConversionAvailable(fromUnit, ing.UnitMeasurement, out selectedConversion);

                            //addConversionBtn.Enabled = !isFound;
                            //saveBtn.Visible = isFound;
                            _save.Text = isFound ? "Save" : "Define Conversion";
                            _save.BackColor = isFound ? SystemColors.ActiveCaption : Color.IndianRed;
                        }
                    }
                }
            }
        }

        bool Save()
        {
            RecipeDetails = new Recipe()
            {
                Qty = qty.Value,
                Ingredient = (Ingredient)ingredientOption.SelectedValue,
                Conversion = selectedConversion
            };

            DialogResult = DialogResult.OK;

            return true;
        }

        public Recipe RecipeDetails { get; private set; }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ingredientOption.SelectedValue is Ingredient ing && unitOption.SelectedItem is Unit fromUnit)
            {
                bool isFound = IsConversionAvailable(fromUnit, ing.UnitMeasurement, out selectedConversion);
                if (isFound)
                    Save();
                else
                    OpenConversionCreation();
            }
        }

        private void addConversionBtn_Click(object sender, EventArgs e)
        {
            //OpenConversionCreation();
        }
    }

}
