using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_api.Dtos.Stock
{
    public class UpdateStockRequestDto
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
    }
}