using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface ICategoriaModelRepository
    {
        void Add(CategoriasModel categoriaModel);
        void Edit(CategoriasModel categoriaModel);
        void Delete(int id);

        IEnumerable<CategoriasModel> GetAll();
        IEnumerable<CategoriasModel> GetByValue(string value);
    }
}
