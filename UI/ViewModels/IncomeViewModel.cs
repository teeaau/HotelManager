using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Styles;
using UI.Views;
using UI.Wrappers;

namespace UI.ViewModels
{
    public class IncomeViewModel : IViewModel
    {
        IncomeView incomeView; 
        BillRepository billRepository = new BillRepository();
        List<IncomeWrapper> incomes;
        TableStyle<IncomeWrapper> tableStyle;
        public IncomeViewModel(IncomeView incomeView)
        {
            this.incomeView = incomeView;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _incomes = await billRepository.GetAllAsync();


            incomes = new List<IncomeWrapper>();
            foreach (var model in _incomes)
            {
                var wrapper = new IncomeWrapper(model);
                incomes.Add(wrapper);
            }
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            var haeders = new List<string>() { "ID", "Phòng", "Tên khách hàng", "Checkin", "Checkout", "Ngày thanh toán", "Tổng tiền" };
            tableStyle = new TableStyle<IncomeWrapper>(haeders, incomes);
            incomeView.pnlTable.Controls.Clear();
            incomeView.pnlTable.Controls.Add(tableStyle);
        }
    }
}
