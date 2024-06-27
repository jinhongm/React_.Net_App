using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_api.Dtos.Stock;
using backend_api.Models;

namespace backend_api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();

        
        public Task<Stock?> GetByIdAsync(int id);

        public Task<Stock> CreateAsync(Stock stockDto);

        // ? means that Stock can be null
        public Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);

        public Task<Stock?> DeleteAsync(int id);

        public Task<bool> StockExists(int id);
    }
}