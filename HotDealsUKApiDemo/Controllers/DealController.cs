using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HotDealsUKApiDemo.Controllers
{
    public class DealController : ApiController
    {
        private List<Deal> FindAllDeals()
		{
			var dealList = new List<Deal>();

			for (int i = 0; i < 10; i++)
			{
				var currentDeal = new Deal{
				     currentDeal.ID = i;
				     currentDeal.Name = i.ToString() + "- Deal";
				}
				dealList.Add(currentDeal);
			}

			return dealList;
		}
		public List<Deal> Get()
		{
			return FindAllDeals();
		}
		public Deal Get(int id)
		{
			return FindAllDeals()[id];
		}
    }
}
