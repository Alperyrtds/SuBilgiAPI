using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuBilgiAPI.Models;
using SuBilgiAPI.Models.Interfaces;
using SuBilgiAPI.Models.Repositories;
using System.Collections.Generic;

namespace SuBilgiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        SuBilgiDBContext _context = new SuBilgiDBContext();
        private readonly CompanyRepository _companyRepository;
        public CompaniesController()
        {
            _companyRepository = new CompanyRepository(_context);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetAllCompanies()
        {
            IEnumerable<Company> companies = _companyRepository.GetAllCompanies();
            return new ActionResult<IEnumerable<Company>>(companies);
        }
        [HttpGet("{id}")]
        public ActionResult<Company> GetCompany(int id)
        {
            var company = _companyRepository.GetCompanies(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }
    }
}
