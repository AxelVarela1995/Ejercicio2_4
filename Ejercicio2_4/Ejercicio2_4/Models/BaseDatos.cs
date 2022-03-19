using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2_4.Models
{
    public class BaseDatos
    {
        readonly SQLiteAsyncConnection basedatos;

        public BaseDatos(String pathdb)
        {
            basedatos = new SQLiteAsyncConnection(pathdb);

            basedatos.CreateTableAsync<Video>().Wait();
        }

    
        public Task<List<Video>> ObtenerListaVideos()
        {
            return basedatos.Table<Video>().ToListAsync();
        }

        public Task<Video> ObtenerVideoCodigo(int codeParam)
        {
            return basedatos.Table<Video>()
                .Where(i => i.codigo == codeParam)
                .FirstOrDefaultAsync();
        }

       
        public Task<int> GuardarVideo(Video photo)
        {
            if (photo.codigo != 0)
            {
                return basedatos.UpdateAsync(photo);
            }
            else
            {
                return basedatos.InsertAsync(photo);
            }

        }

        public Task<int> EliminarVideo(Video photo)
        {
            return basedatos.DeleteAsync(photo);
        }

    }
}

