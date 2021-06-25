using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    /// <summary>
    /// Diferentes tipos de categorias de Filmes
    /// </summary>
    public class Categorias
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Categorias()
        {
            ListaDeCategorias = new HashSet<FilmeCategorias>();
        }
        /// <summary>
        /// Identificador de categorias
        /// </summary>
        [Key]
        public int IdCategorias { get; set; }

        /// <summary>
        /// Nome da categoria
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Lista de categorias
        /// </summary>
        public ICollection<FilmeCategorias> ListaDeCategorias { get; set; }
    }
}
