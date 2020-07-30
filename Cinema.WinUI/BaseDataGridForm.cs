using Cinema.Shared.Search;
using Cinema.WinUI.Constants;
using Cinema.WinUI.UserControls;
using System.Windows.Forms;

namespace Cinema.WinUI
{
    public abstract class BaseDataGridForm : Form
    {
        protected string CurrentSortPropertyName;
        protected Cinema.Shared.Enums.SortOrder? CurrentSortOrder;

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
