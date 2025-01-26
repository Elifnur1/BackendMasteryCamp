using System;
using AutoMapper;
using EShop.Data.Abstract;
using EShop.Entity.Concrete;
using EShop.Services.Abstract;
using EShop.Shared.ComplexTypes;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Concrete;

public class OrderManager : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICartService _cartManager;
    private readonly IGenericRepository<Order> _orderRepository;
    private readonly IGenericRepository<Product> _productRepository;

    public OrderManager(IUnitOfWork unitOfWork, IMapper mapper, ICartService cartManager)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cartManager = cartManager;
        _orderRepository = _unitOfWork.GetRepository<Order>();
        _productRepository = _unitOfWork.GetRepository<Product>();
    }

    public async Task<ResponseDto<OrderDto>> AddAsync(OrderCreateDto orderCreateDto)
    {
        try
        {
            foreach (var orderItem in orderCreateDto.OrderItems)
            {
                var isExists = await _productRepository.ExistsAsync(x=>x.Id==orderItem.ProductId);
                
            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public Task<ResponseDto<NoContent>> CancelOrderAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string applicationUserId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<OrderDto>> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> UpdateOrderStatusAsync(int id, OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }
}
