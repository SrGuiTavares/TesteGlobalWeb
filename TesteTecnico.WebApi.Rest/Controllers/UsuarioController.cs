using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Application.Interface;
using TesteTecnico.Application.ViewModel;

namespace TesteTecnico.WebApi.Rest.Controllers
{
    [Route("/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _appService;
        private readonly IMapper _mapper;
        private readonly IValidator<UsuarioViewModel> _validator;

        public UsuarioController(IUsuarioAppService appService, IMapper mapper, IValidator<UsuarioViewModel> validator)
        {
            _appService = appService;
            _mapper = mapper;
            _validator = validator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] UsuarioViewModel viewModel)
        {
            try
            {
                var resultadoValidacao = await _validator.ValidateAsync(viewModel);

                if (resultadoValidacao.IsValid)
                {
                    var usuario = await _appService.SelecionarPorDocumento(viewModel.Documento);

                    if (usuario == null)
                    {

                    }

                    var retornoRequisicao = await _appService.Insert(viewModel);

                    return Ok();
                }
                else
                {
                    return BadRequest(Results.ValidationProblem(resultadoValidacao.ToDictionary()));
                }
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UsuarioViewModel viewModel)
        {
            try
            {
                var resultadoRequisicao = await _appService.Update(viewModel);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(UsuarioViewModel viewModel)
        {
            try
            {
                var resultadoRequisicao = await _appService.Delete(viewModel);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
