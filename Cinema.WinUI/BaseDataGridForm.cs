using Cinema.Shared.Search;
using Cinema.WinUI.Authorization;
using Cinema.WinUI.Constants;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public class BaseDataGridForm : SecureBaseForm
    {
        protected string CurrentSortPropertyName;
        protected Shared.Enums.SortOrder? CurrentSortOrder;

        private IList<string> _nextFormPrincipal;

        public BaseDataGridForm()
        {

        }

        public BaseDataGridForm(string[] roles, IList<string> userPrincipal) : base(roles, userPrincipal)
        {
            _nextFormPrincipal = userPrincipal;
        }

        protected virtual void ChangeSorting(string clickedColumnName)
        {
            if (CurrentSortPropertyName == clickedColumnName)
            {
                if (CurrentSortOrder == Shared.Enums.SortOrder.ASC)
                {
                    CurrentSortOrder = Shared.Enums.SortOrder.DESC;
                }
                else
                {
                    CurrentSortOrder = Shared.Enums.SortOrder.ASC;
                }
            }
            else
            {
                CurrentSortOrder = Shared.Enums.SortOrder.ASC;
            }

            CurrentSortPropertyName = clickedColumnName;
        }

        protected virtual ISearchRequest ApplyDefaultSearchValues(ISearchRequest searchRequest)
        {
            searchRequest.SortColumn = CurrentSortPropertyName;
            searchRequest.SortOrder = CurrentSortOrder;
            searchRequest.PageSize = Paging.DEFAULT_PAGE_SIZE;
            searchRequest.PageIndex = Paging.DEFAULT_PAGE_INDEX;

            return searchRequest;
        }

        protected virtual void BindNavigationColumns(DataGridView dataGridView, object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView.Rows[e.RowIndex].DataBoundItem != null)
                && (dataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(
                              dataGridView.Rows[e.RowIndex].DataBoundItem,
                              dataGridView.Columns[e.ColumnIndex].DataPropertyName
                            );
            }
        }

        protected virtual string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }
    }
}
