
using FreeCourse.Services.Basket.Services;
using FreeCourse.Shared.Messages;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Application.Consumers
{
    public class BasketCourseNameChangedEventConsumer : IConsumer<BasketCourseNameChangeEvent>
    {
        private readonly IBasketService _basketService;

        public BasketCourseNameChangedEventConsumer(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task Consume(ConsumeContext<BasketCourseNameChangeEvent> context)
        {
            var basket = await _basketService.GetBasket(context.Message.UserId);

            basket.Data.BasketItems.Where(x=>x.CourseId == context.Message.CourseId).ToList().ForEach(x =>
            {
                x.CourseName = context.Message.UpdatedName;
            });

            await _basketService.SaveOrUpdate(basket.Data);
        }
    }
}
