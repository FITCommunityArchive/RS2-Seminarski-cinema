using Cinema.Shared.Search;
using Cinema.WinUI.Authorization;
using Cinema.WinUI.Constants;
using Cinema.WinUI.UserControls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public class BaseDataGridForm : SecureBaseForm
    {
        protected string CurrentSortPropertyName;
        protected Shared.Enums.SortOrder? CurrentSortOrder;

        private IList<string> _nextFormPrincipal;
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
    }
}
