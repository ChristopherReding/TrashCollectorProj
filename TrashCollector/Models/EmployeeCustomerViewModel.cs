using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeCustomerViewModel
    {
        public Employee employee { get; set; }
        public List<Customer> customerList { get; set; }
        public EmployeeCustomerViewModel(Employee employee, List<Customer> customerList)
        {
            this.employee = employee;
            this.customerList = customerList;
        }
    }
    
}
