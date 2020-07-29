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
    }
}
