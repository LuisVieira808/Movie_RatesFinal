using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    public class FilmeCategorias
    {
        /// <summary>
        /// PK para a tabela do relacionamento entre Filmes e Categorias
        /// </summary>
        [Key]
        public int IdFilmeCategorias { get; set; }

        //*****************************
        /// <summary>
        /// Fk para Categoria
        /// </summary>
        [ForeignKey(nameof(Categoria))]
        public int CategoriasFK { get; set; }
        public Categorias Categoria { get; set; }


        /// <summary>
        /// FK para o Filme
        /// </summary>
        [ForeignKey(nameof(Filme))]
        public int FilmesFK { get; set; }
        public Filmes Filme { get; set; }
    }
}
