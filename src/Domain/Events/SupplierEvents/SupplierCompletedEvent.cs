using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Common;
using Store.Domain.Entities;

namespace Store.Domain.Events;
public class SupplierCompleteEvent : BaseEvent
{
    public SupplierCompleteEvent(Supplier supplier)
    {
        Supplier = supplier;
    }
    public Supplier Supplier { get; set; }
}
