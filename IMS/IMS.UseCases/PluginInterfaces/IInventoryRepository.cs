﻿using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public  interface IInventoryRepository
    {   
        Task AddInventoryAsync(Inventory inventory);//burası eksik çık ekledim
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
    }
}
