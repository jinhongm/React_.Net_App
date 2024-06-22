using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_api.Data;
using backend_api.Dtos.Stock;
using backend_api.Interfaces;
using backend_api.Models;
using Microsoft.EntityFrameworkCore;


namespace backend_api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context){
            _context = context;
        }
        public async Task<List<Stock>> GetAllAsync()
        {
            return await _context.Stocks.ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.FindAsync(id);
    
        }
        // _stockRepository.CreateAsync(stockDto) 方法应该异步地将数据添加到数据库中，
        // 并在成功后返回创建的 Stock 实体。这个实体中应该包含数据库自动生成的 Id，这个 Id 是在数据被保存到数据库时由数据库自动设置的（例如，如果使用的是 SQL Server，Id 可以设置为自增字段）。
        
        public async Task<Stock> CreateAsync(Stock stockDto){
            await _context.Stocks.AddAsync(stockDto);
            await _context.SaveChangesAsync();
            return stockDto;
        }

        public async Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto){
            var stockModel = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);
            if (stockModel == null){
                return null;
            }
            stockModel.Symbol = stockDto.Symbol;
            stockModel.CompanyName = stockDto.CompanyName;
            stockModel.Purchase = stockDto.Purchase;
            stockModel.LastDiv = stockDto.LastDiv;
            stockModel.Industry = stockDto.Industry;
            stockModel.MarketCap = stockDto.MarketCap;
            await _context.SaveChangesAsync();
            return stockModel;
        }

        public async Task<Stock?> DeleteAsync(int id){
            var existing_Model = await _context.Stocks.FirstOrDefaultAsync( x => x.Id == id);
            if (existing_Model == null)
            {
                return null;
            }
            _context.Stocks.Remove(existing_Model);
            await _context.SaveChangesAsync();
            return existing_Model;
        }
    }
}