
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNinja.Client.Pages

{
    [Authorize(Roles = "User")]
    public partial class Counter
    {

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
