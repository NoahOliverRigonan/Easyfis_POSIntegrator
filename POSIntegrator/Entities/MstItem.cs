﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSIntegrator
{
    class MstItem
    {
        public String ManualArticleCode { get; set; }
        public String Article { get; set; }
        public Int32 ArticleTypeId { get; set; }
        public String Category { get; set; }
        public String Unit { get; set; }
        public Decimal Price { get; set; }
        public Decimal Cost { get; set; }
        public Boolean IsInventory { get; set; }
        public String Particulars { get; set; }
        public String UpdatedDateTime { get; set; }
        public List<MstItemPrice> ListPOSIntegrationMstItemPrice { get; set; }
    }
}
