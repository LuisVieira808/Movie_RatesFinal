using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    /// <summary>
    /// Review de cada utilizador (comentário/pontuação)
    /// </summary>
    public class Reviews
    {
        /// <summary>
        /// Identificador da review
        /// </summary>
        [Key]
        public int IdReview { get; set; }

        /// <summary>
        /// Comentário do utilizador inscrito sobre o filme
        /// </summary>
        public string Comentario { get; set; }

        /// <summary>
        /// Pontuação que o utilizador dá ao filme
        /// </summary>
        public int Pontuacao { get; set; }

        /// <summary>
        /// Data que o utilizador meteu a review
        /// </summary>
        public DateTime Data { get; set; }

        //********************************************
        /// <summary>
        /// FK para o utilizador da review
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadoresFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        /// <summary>
        /// FK para o filme da review
        /// </summary>
        [ForeignKey(nameof(Filme))]
        public int FilmesFK { get; set; }
        public Filmes Filme { get; set; }
    }
}
