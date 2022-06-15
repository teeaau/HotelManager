using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Styles;
using UI.Views;
using UI.Wrappers;

namespace UI.ViewModels
{
    public class CustomerViewModel : IViewModel
    {
        CustomerView customerView;
        CustomerRepository customerRepository = new CustomerRepository();
        List<CustomerWrapper> customers;
        TableStyle<CustomerWrapper> tableStyle;
        public CustomerViewModel(CustomerView customerView)
        {
            this.customerView = customerView;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _customers = await customerRepository.GetAllAsync();
            

            customers = new List<CustomerWrapper>();
            foreach (var model in _customers)
            {
                var wrapper = new CustomerWrapper(model);
                customers.Add(wrapper);
            }
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            var haeders = new List<string>() { "ID khách hàng", "Tên khách hàng", "Ngày sinh" };
            tableStyle = new TableStyle<CustomerWrapper>(haeders, customers);
            customerView.pnlTable.Controls.Clear();
            customerView.pnlTable.Controls.Add(tableStyle);
        }
    }
}
