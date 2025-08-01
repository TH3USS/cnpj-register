using CNPJ_Register.Data;
using CNPJ_Register.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;

namespace CNPJ_Register.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmpresaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpClientFactory _httpClientFactory;

        public EmpresaController(ApplicationDbContext context, IHttpClientFactory factory)
        {
            _context = context;
            _httpClientFactory = factory;
        }

        [HttpPost("{cnpj}")]
        public async Task<IActionResult> CadastrarEmpresa(string cnpj)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var http = _httpClientFactory.CreateClient();
            var response = await http.GetFromJsonAsync<JsonElement>($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");

            if (response.TryGetProperty("status", out var status) && status.GetString() == "ERROR")
                return BadRequest("CNPJ inválido");

            var empresa = new Empresa
            {
                Cnpj = response.GetProperty("cnpj").GetString(),
                NomeEmpresarial = response.GetProperty("nome").GetString(),
                NomeFantasia = response.GetProperty("fantasia").GetString(),
                Situacao = response.GetProperty("situacao").GetString(),
                Abertura = response.GetProperty("abertura").GetString(),
                Tipo = response.GetProperty("tipo").GetString(),
                NaturezaJuridica = response.GetProperty("natureza_juridica").GetString(),
                AtividadePrincipal = response.GetProperty("atividade_principal")[0].GetProperty("text").GetString(),
                Logradouro = response.GetProperty("logradouro").GetString(),
                Numero = response.GetProperty("numero").GetString(),
                Complemento = response.GetProperty("complemento").GetString(),
                Bairro = response.GetProperty("bairro").GetString(),
                Municipio = response.GetProperty("municipio").GetString(),
                Uf = response.GetProperty("uf").GetString(),
                Cep = response.GetProperty("cep").GetString(),
                UserId = userId
            };

            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();

            return Ok(empresa);
        }

        [HttpGet]
        public IActionResult ListarEmpresas()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var empresas = _context.Empresas.Where(e => e.UserId == userId).ToList();
            return Ok(empresas);
        }
    }

}
