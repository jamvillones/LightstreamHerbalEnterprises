﻿using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class IngredientsForm : Form
    {
        private DbContextFactory factory = new DbContextFactory();
        public string IngredientName => ingredientField.IngredientName;
        public Unit SelectedUnit => ingredientField.UnitOfMeasurement;
        string UOMString => ingredientField.UnitOfMeasurementString;
        public decimal Cost => ingredientField.Cost;
        public bool NewItemCreated { get; private set; }
        public Ingredient CreatedIngredient { get; private set; }
        IAddRepository<Ingredient> _ingService;
        public IngredientsForm(IAddRepository<Ingredient> ingService)
        {
            _ingService = ingService;
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                MessageBox.Show("Name and Description cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /// create new ingredient
            var ingredient = new Ingredient()
            {
                Name = this.IngredientName,
                Cost = this.Cost,
                UnitMeasurement = SelectedUnit ?? new Unit() { SingularName = UOMString }
            };

            await _ingService.Add_Async(ingredient);

            CreatedIngredient = ingredient;
            NewItemCreated = true;
            DialogResult = DialogResult.OK;
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}
