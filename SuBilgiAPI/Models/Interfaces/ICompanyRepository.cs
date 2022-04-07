using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuBilgiAPI.Models.Interfaces
{
    public interface ICompanyRepository
    {
        List<Company> GetAllCompanies();
        Company GetCompanies(int id);
    }
}
