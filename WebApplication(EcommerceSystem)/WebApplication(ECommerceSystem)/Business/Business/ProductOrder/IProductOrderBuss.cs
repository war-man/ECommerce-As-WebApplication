﻿using Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business.ProductOrder
{
    public interface IProductOrderBuss
    {

		ProductOrderCommon ClothesData(string ProductReferenceId, string User);
        ProductOrderCommon ComputerData(string ProductReferenceId, string User);
        ProductOrderCommon GadgetData(string ProductReferenceId, string User);
        ProductOrderCommon GroceriesData(string ProductReferenceId, string User);
        DbResponse Manage(ProductOrderCommon common);
        DbResponse MakePayment(string OrderId, string TotalPrice, string User);

    }
}
