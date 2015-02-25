using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIWebApp.Data;
using BIWebApp.Repository;

namespace BIWebApp.Services
{
    public class CostService
    {
        private readonly IGenericRepository<BI_K3_Costs> _costRepository = new GenericRepository<BI_K3_Costs>();

        public IList<BI_K3_Costs> GetCosts()
        {
            var query = _costRepository.Table;
            query.OrderBy(c => c.Role_Name);
            return query.ToList();
        }

        public BI_K3_Costs GetCostById(int costId)
        {

            return _costRepository.GetById(costId);
           
        }

        public void DeleteCost(BI_K3_Costs cost)
        {
            if (cost == null)
            {
                throw new ArgumentNullException("cost");
            }

            _costRepository.Delete(cost);
        }

        public void UpdateCost(BI_K3_Costs cost)
        {
            if (cost == null)
            {
                throw new ArgumentNullException("cost");
            }
            _costRepository.Update(cost);
        }

        public void InsertCost(BI_K3_Costs cost)
        {
            if (cost == null)
            {
                throw new ArgumentNullException("cost");
            }
            _costRepository.Insert(cost);
        }
    }
}
