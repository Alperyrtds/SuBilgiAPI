using SuBilgiAPI.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SuBilgiAPI.Models.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly SuBilgiDBContext _suBilgiDBContext;
        public CompanyRepository(SuBilgiDBContext suBilgiDBContext)
        {
            this._suBilgiDBContext = suBilgiDBContext;
        }
        public List<Company> GetAllCompanies()
        {
            return _suBilgiDBContext.Companies.ToList();

        }

        public Company GetCompanies(int id)
        {
            return _suBilgiDBContext.Companies.FirstOrDefault(x => x.Id == id);
        }
    }
}
