using System;
using System.Collections.Generic;
using System.Text;
using T3MVVM.Models;
using System.Threading.Tasks;
using SQLite;

namespace T3MVVM.Services
{
    public class pagoService : repPagos
    {
        public SQLiteAsyncConnection _database;

        public pagoService(string dbPath)
            {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Pagos>().Wait();
            }

        //INSERTAR Y ACTUALIZAR 
        public async Task<bool> AddPagoAsync(Pagos pago)
        {
            if (pago.Id_empleados > 0)
            {
                await _database.UpdateAsync(pago);
            }
            else
            {
                await _database.InsertAsync(pago);
            }
            return await Task.FromResult(true);

        }

        //BORRAR REGISTRO
        public async Task<bool> DeletePagoAsync(int id)
        {
            await _database.DeleteAsync<Pagos>(id);
            return await Task.FromResult(true);
        }



        //CONSULTAR PAGOS EN LISTA
        public async Task<IEnumerable<Pagos>> GetPagosAsync()
        {
            return await Task.FromResult( await _database.Table<Pagos>().ToListAsync());
        }

        public async Task<bool> UpdatePagoAsync(Pagos pago)
        {
            throw new NotImplementedException();
        }
    }
}
