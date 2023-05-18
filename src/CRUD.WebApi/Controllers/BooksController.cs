using System.Net; 
using CRUD.Model.Books;
using CRUD.Service.Services.Books; 
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CRUD.WebApi.Controllers
{
    /// <summary>
    /// Represents an books controller
    /// </summary>
    [Route("api/[controller]")]
    [SwaggerTag("Books public operations")]
    public class BooksController : BaseController
    {
        #region Properties

        private readonly IBookService _bookService;

        #endregion

        #region Ctor

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion

        #region Methods

        #region List

        /// <summary>
        /// GET all records
        /// </summary>
        /// <returns>Result</returns>
        [HttpGet]
        [SwaggerResponse((int) HttpStatusCode.OK, "Books list", typeof(IList<BookModel>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Anything wrong with the input")]
        public IActionResult List()
        {
            // get all books
            var result = _bookService.GetAll();

            // return result
            return Ok(result);
        }


        #endregion

        #region Get

        /// <summary>
        /// GET book by identifier
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Result</returns>
        [HttpGet("{id:int}")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Book detail", typeof(BookModel))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Anything wrong with the input")]
        public IActionResult Get(int id)
        {
            // get book detail by identifier
            var result = _bookService.GetById(id);

            // result
            return Ok(result);
        }

        #endregion

        #region Add

        /// <summary>
        /// ADD book
        /// </summary>
        /// <param name="model">Book model</param>
        /// <returns>Result</returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK, "Successfully added", typeof(int))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Anything wrong with the input")]
        public IActionResult Add([FromBody] BookModel model)
        {
            // add book
            var result = _bookService.Add(model);

            // return result
            return Ok(result);
        }

        #endregion

        #region Update

        /// <summary>
        /// Update book
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <param name="model">Book model</param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        [SwaggerResponse((int)HttpStatusCode.NoContent, "Successfully updated")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Anything wrong with the input")]
        public IActionResult Update(int id, [FromBody] BookModel model)
        {
            // update book
            _bookService.Update(id, model);

            // return
            return NoContent();
        }

        #endregion

        #region Delete

        /// <summary>
        /// Delete the book
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        [SwaggerResponse((int)HttpStatusCode.NoContent, "Successfully deleted")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Anything wrong with the input")]
        public IActionResult Delete(int id)
        {
            // delete a book
            _bookService.Delete(id);

            // return
            return NoContent();
        }

        #endregion

        #endregion
    }
}
