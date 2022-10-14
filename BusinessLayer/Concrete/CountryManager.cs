using DataAccessLayer.Repositories;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CountryManager
    {
        GenericRepository<CountryInfo> genericRepository = new GenericRepository<CountryInfo>();

        public void CountryAddBL(CountryInfo _countryInfo)
        {
            try
            {
                genericRepository.Insert(_countryInfo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
