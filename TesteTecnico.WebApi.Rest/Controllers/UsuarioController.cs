using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Application.Interface;
using TesteTecnico.Application.ViewModel;

namespace TesteTecnico.WebApi.Rest.Controllers
{
    [Route("/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _appService;

        public UsuarioController(IUsuarioAppService appService)
        {
            _appService = appService;
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
                return Ok(await _appService.Insert(viewModel));
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
        [HttpPut]
        public async Task<IActionResult> Update(UsuarioViewModel viewModel)
        {
            try
            {
                return Ok(await _appService.Update(viewModel));
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
                return Ok(await _appService.Delete(viewModel));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
