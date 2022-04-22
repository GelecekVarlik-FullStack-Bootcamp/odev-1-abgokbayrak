using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    class deneme
    {
        public void denenene(DtoCustomer entity)
        {

            var x= ObjectMapper.Mapper.Map<Customer>(entity);
        }
    }
}
