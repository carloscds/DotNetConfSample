﻿using System;
using System.Collections.Generic;

namespace LibraryCoreStandard
{
    /// <summary>
    /// Servico em Memória, não tem persistência
    /// </summary>
    public class CustomerService
    {
        private List<Customer> _customer;

        public CustomerService()
        {
            _customer = new List<Customer>();
        }

        public void Add(Customer newCustomer)
        {
            _customer.Add(newCustomer);
        }

        public List<Customer> GetAll() => _customer;

    }
}
