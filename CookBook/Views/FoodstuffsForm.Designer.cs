namespace CookBook.Views
{
    partial class FoodstuffsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.bsFoodstuffs = new System.Windows.Forms.BindingSource(this.components);
            this.bsMeasurementUnits = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFoodstuffs = new CookBook.CustomControls.DataGridViewEx();
            ((System.ComponentModel.ISupportInitialize)(this.bsFoodstuffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodstuffs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(722, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bsFoodstuffs
            // 
            this.bsFoodstuffs.DataSource = typeof(BLL.Models.FoodstuffModel);
            // 
            // bsMeasurementUnits
            // 
            this.bsMeasurementUnits.DataSource = typeof(Common.KeyValueStringInt);
            // 
            // dgvFoodstuffs
            // 
            this.dgvFoodstuffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodstuffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodstuffs.Location = new System.Drawing.Point(12, 12);
            this.dgvFoodstuffs.Name = "dgvFoodstuffs";
            this.dgvFoodstuffs.Size = new System.Drawing.Size(794, 443);
            this.dgvFoodstuffs.TabIndex = 2;
            // 
            // FoodstuffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 505);
            this.Controls.Add(this.dgvFoodstuffs);
            this.Controls.Add(this.btnSave);
            this.Name = "FoodstuffsForm";
            this.Text = "Ингредиенты";
            this.Load += new System.EventHandler(this.FoodstuffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFoodstuffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodstuffs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsFoodstuffs;
        private System.Windows.Forms.BindingSource bsMeasurementUnits;
        private CustomControls.DataGridViewEx dgvFoodstuffs;
    }
}