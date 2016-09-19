namespace CookBook.Views
{
    partial class MeasurementUnitsForm
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
            this.dgvMeasurementUnits = new CookBook.CustomControls.DataGridViewEx();
            this.bsMeasurementUnits = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(732, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvMeasurementUnits
            // 
            this.dgvMeasurementUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeasurementUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeasurementUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurementUnits.Location = new System.Drawing.Point(13, 13);
            this.dgvMeasurementUnits.Name = "dgvMeasurementUnits";
            this.dgvMeasurementUnits.Size = new System.Drawing.Size(805, 456);
            this.dgvMeasurementUnits.TabIndex = 0;
            // 
            // bsMeasurementUnits
            // 
            this.bsMeasurementUnits.DataSource = typeof(BLL.Models.MeasurementUnitModel);
            // 
            // MeasurementUnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 521);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMeasurementUnits);
            this.Name = "MeasurementUnitsForm";
            this.Text = "Единицы измерения";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DataGridViewEx dgvMeasurementUnits;
        private System.Windows.Forms.BindingSource bsMeasurementUnits;
        private System.Windows.Forms.Button btnSave;
    }
}