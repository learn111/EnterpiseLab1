namespace CookBook.Views
{
    partial class DishesToFoodstuffsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbDishes = new System.Windows.Forms.ComboBox();
            this.bsDishes = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDishesToFoodstuffs = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDishesToFoodstuffs = new System.Windows.Forms.DataGridView();
            this.foodstuffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consumptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishesToFoodstuffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishesToFoodstuffs)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDishes
            // 
            this.cmbDishes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDishes.DataSource = this.bsDishes;
            this.cmbDishes.DisplayMember = "Key";
            this.cmbDishes.FormattingEnabled = true;
            this.cmbDishes.Location = new System.Drawing.Point(12, 12);
            this.cmbDishes.Name = "cmbDishes";
            this.cmbDishes.Size = new System.Drawing.Size(309, 21);
            this.cmbDishes.TabIndex = 0;
            this.cmbDishes.ValueMember = "Value";
            this.cmbDishes.SelectedIndexChanged += new System.EventHandler(this.cmbDishes_SelectedIndexChanged);
            // 
            // bsDishes
            // 
            this.bsDishes.DataSource = typeof(Common.KeyValueStringInt);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(590, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Используется";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Потребление";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            // 
            // measurementUnitDataGridViewTextBoxColumn
            // 
            this.measurementUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit";
            this.measurementUnitDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.measurementUnitDataGridViewTextBoxColumn.Name = "measurementUnitDataGridViewTextBoxColumn";
            this.measurementUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDishesToFoodstuffs
            // 
            this.bsDishesToFoodstuffs.DataSource = typeof(BLL.Models.DishToFoodstuffsModel);
            // 
            // dgvDishesToFoodstuffs
            // 
            this.dgvDishesToFoodstuffs.AllowUserToAddRows = false;
            this.dgvDishesToFoodstuffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishesToFoodstuffs.AutoGenerateColumns = false;
            this.dgvDishesToFoodstuffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishesToFoodstuffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishesToFoodstuffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodstuffNameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn1,
            this.consumptionDataGridViewTextBoxColumn1,
            this.measurementUnitDataGridViewTextBoxColumn1});
            this.dgvDishesToFoodstuffs.DataSource = this.bsDishesToFoodstuffs;
            this.dgvDishesToFoodstuffs.Location = new System.Drawing.Point(13, 40);
            this.dgvDishesToFoodstuffs.Name = "dgvDishesToFoodstuffs";
            this.dgvDishesToFoodstuffs.Size = new System.Drawing.Size(652, 293);
            this.dgvDishesToFoodstuffs.TabIndex = 2;
            // 
            // foodstuffNameDataGridViewTextBoxColumn
            // 
            this.foodstuffNameDataGridViewTextBoxColumn.DataPropertyName = "FoodstuffName";
            this.foodstuffNameDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.foodstuffNameDataGridViewTextBoxColumn.Name = "foodstuffNameDataGridViewTextBoxColumn";
            this.foodstuffNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn1
            // 
            this.isActiveDataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn1.HeaderText = "Используется";
            this.isActiveDataGridViewCheckBoxColumn1.Name = "isActiveDataGridViewCheckBoxColumn1";
            // 
            // consumptionDataGridViewTextBoxColumn1
            // 
            this.consumptionDataGridViewTextBoxColumn1.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn1.HeaderText = "Потребление";
            this.consumptionDataGridViewTextBoxColumn1.Name = "consumptionDataGridViewTextBoxColumn1";
            // 
            // measurementUnitDataGridViewTextBoxColumn1
            // 
            this.measurementUnitDataGridViewTextBoxColumn1.DataPropertyName = "MeasurementUnit";
            this.measurementUnitDataGridViewTextBoxColumn1.HeaderText = "Единица измерения";
            this.measurementUnitDataGridViewTextBoxColumn1.Name = "measurementUnitDataGridViewTextBoxColumn1";
            this.measurementUnitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DishesToFoodstuffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 376);
            this.Controls.Add(this.dgvDishesToFoodstuffs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbDishes);
            this.Name = "DishesToFoodstuffsForm";
            this.Text = "Настройка блюд";
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishesToFoodstuffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishesToFoodstuffs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDishes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsDishes;
        private System.Windows.Forms.BindingSource bsDishesToFoodstuffs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvDishesToFoodstuffs;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodstuffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitDataGridViewTextBoxColumn1;
    }
}