using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Common;

namespace CookBook.CustomControls
{
    internal class DataGridViewEx : DataGridView
    {
        public DataGridViewEx()
        {
            ColumnAdded += OnAdded;
        }


        private void OnAdded(object s, DataGridViewColumnEventArgs e)
        {
            var fi =
                typeof (BindingSource)
                    .GetField("itemType", BindingFlags.NonPublic | BindingFlags.Instance);
            var type
                = fi.GetValue(DataSource) as Type;


            var propDesc = type.GetProperty(e.Column.DataPropertyName);

            if (!e.Column.IsDataBound)
            {
                return;
            }

            var isEnum = propDesc.PropertyType.IsEnum;
            if (isEnum || e.Column.DataPropertyName.EndsWith("Id"))
            {
                Columns.Remove(e.Column);
                var tolocalizedlist = nameof(EnumExtension.ToLocalizedListKeyValue);

                var dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
                {
                    Name = e.Column.Name,
                    HeaderText = e.Column.HeaderText,
                    DataPropertyName = e.Column.DataPropertyName
                };
                Columns.Insert(e.Column.Index, dataGridViewComboBoxColumn);

                dataGridViewComboBoxColumn.DataSource =
                    isEnum
                        ? new BindingSource(typeof (EnumExtension).GetMethod(tolocalizedlist)
                            .MakeGenericMethod(propDesc.PropertyType)
                            .Invoke(this, null) as List<KeyValueStringInt>, null)
                        : null;
                dataGridViewComboBoxColumn.ValueMember = "Value";
                dataGridViewComboBoxColumn.DisplayMember = "Key";
            }
        }
    }
}