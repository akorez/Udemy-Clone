using FreeCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<ResponseDto<List<Models.Discount>>> GetAll();
        
        Task<ResponseDto<Models.Discount>> GetById(int id);

        Task<ResponseDto<NoContent>> Save(Models.Discount discount);

        Task<ResponseDto<NoContent>> Update(Models.Discount discount);

        Task<ResponseDto<NoContent>> Delete(int id);

        Task<ResponseDto<Models.Discount>> GetByCodeAndUserId(string code,string userId);

    }
}
