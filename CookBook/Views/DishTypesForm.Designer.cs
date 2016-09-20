namespace CookBook.Views
{
    partial class DishTypesForm
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
            this.dgvDishTypes = new CookBook.CustomControls.DataGridViewEx();
            this.btnSave = new System.Windows.Forms.Button();
            this.bsDishTypes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishTypes
            // 
            this.dgvDishTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishTypes.Location = new System.Drawing.Point(12, 12);
            this.dgvDishTypes.Name = "dgvDishTypes";
            this.dgvDishTypes.Size = new System.Drawing.Size(751, 424);
            this.dgvDishTypes.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(688, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DishTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 487);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDishTypes);
            this.Name = "DishTypesForm";
            this.Text = "Типы блюд";
            this.Load += new System.EventHandler(this.DishTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDishTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DataGridViewEx dgvDishTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsDishTypes;
    }
}