using System;
using System.Collections.Generic;
using System.Text;
using T3MVVM.Models;
using System.Threading.Tasks;
namespace T3MVVM.Services
{
    public interface repPagos
    {
        Task<bool> AddPagoAsync(Pagos pago);

        Task<bool> UpdatePagoAsync(Pagos pago);
        Task<bool> DeletePagoAsync(int id);
       

        Task<IEnumerable<Pagos>> GetPagosAsync();

    }
}
