namespace CookBook.Views
{
    partial class DishesForm
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
            this.bsDishes = new System.Windows.Forms.BindingSource(this.components);
            this.bsDishTypes = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDishes = new CookBook.CustomControls.DataGridViewEx();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(764, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bsDishes
            // 
            this.bsDishes.DataSource = typeof(BLL.Models.DishModel);
            // 
            // bsDishTypes
            // 
            this.bsDishTypes.DataSource = typeof(Common.KeyValueStringInt);
            // 
            // dgvDishes
            // 
            this.dgvDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Location = new System.Drawing.Point(13, 13);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.Size = new System.Drawing.Size(826, 416);
            this.dgvDishes.TabIndex = 0;
            // 
            // DishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 484);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDishes);
            this.Name = "DishesForm";
            this.Text = "Блюда";
            ((System.ComponentModel.ISupportInitialize)(this.bsDishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DataGridViewEx dgvDishes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsDishes;
        private System.Windows.Forms.BindingSource bsDishTypes;
    }
}