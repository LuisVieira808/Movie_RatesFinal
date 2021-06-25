using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    /// <summary>
    /// Descrição de um filme
    /// </summary>
    public class Filmes
    {

        /// <summary>
        /// Construtores
        /// </summary>
        public Filmes()
        {
            ListaDeFilmes = new HashSet<Reviews>();
            ListaDeCategorias = new HashSet<FilmeCategorias>();
        }

        /// <summary>
        /// Identificador do filme
        /// </summary>
        [Key]
        public int IdFilmes { get; set; }

        /// <summary>
        /// Título do filme
        /// </summary>
        [Required]
        public string Titulo { get; set; }

        /// <summary>
        /// Data de lançamento do filme
        /// </summary>
        [Required]
        public DateTime Data { get; set; }

        /// <summary>
        /// Capa do filme
        /// </summary>
        [Required]
        public string Capa { get; set; }

        /// <summary>
        /// Nome do Realizador
        /// </summary>
        [Required]
        public string Realizador { get; set; }

        /// <summary>
        /// Nome do Elenco
        /// </summary>
        [Required]
        public string Elenco { get; set; }

        /// <summary>
        /// Breve descrição sobre o filme
        /// </summary>
        [Required]
        public string Descricao { get; set; }

        /// <summary>
        /// Link da Stream
        /// </summary>
        [Required]
        public string Link { get; set; }

        /// <summary>
        /// Duração do filme
        /// </summary>
        [Required]
        public string Duracao { get; set; }

        /// <summary>
        /// Pontuação do filme
        /// </summary>
        [Required]
        public double Pontuacao { get; set; }

        /// <summary>
        /// Lista das reviews dos filmes
        /// </summary>
        public ICollection<Reviews> ListaDeFilmes { get; set; }

        /// <summary>
        /// Lista de categorias dos filmes
        /// </summary>
        public ICollection<FilmeCategorias> ListaDeCategorias { get; set; }
    }
}
