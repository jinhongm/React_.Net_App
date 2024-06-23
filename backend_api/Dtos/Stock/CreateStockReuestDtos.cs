using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_api.Dtos.Comment;
// DTO (Data Transfer Object)
// DTO 用于封装数据并将其传输层与业务逻辑分离。它帮助在不同层之间传递数据，而不需要暴露数据库实体。
// StockDto 和 CreateStockRequestDto 是 DTO 的例子，其中 StockDto 用于数据的读操作，而 CreateStockRequestDto 用于封装创建新股票时来自客户端的数据。
namespace backend_api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        
        public string Symbol {get; set;} = string.Empty;
        // TypeName："decimal(18,2)" 表示该列在数据库中将被设置为 decimal 类型，其中18是数字的总位数（精度），2是小数点后的位数（小数精度）。
        public string CompanyName { get; set; } = string.Empty;
        // 表示股票的购买价
        public decimal Purchase { get; set;}
        // 表示最后一次分红

        public decimal LastDiv { get; set; }
        // I表示公司所属的行业
        public string? Industry { get; set; } 
        // 表示公司的市值。
        public long MarketCap { get; set; }

        public List<CommentDto> Comments { get; set; }
    }
}