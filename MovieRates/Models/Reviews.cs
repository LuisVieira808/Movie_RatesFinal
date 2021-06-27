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
        /// Data que o utilizador submeteu a review
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Visibilidade da review
        /// </summary>
        public Boolean Visibilidade { get; set; }

        //********************************************
        /// <summary>
        /// FK para o utilizador que fez a review
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadoresFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        /// <summary>
        /// FK para o filme ao qual review foi feita
        /// </summary>
        [ForeignKey(nameof(Filme))]
        public int FilmesFK { get; set; }
        public Filmes Filme { get; set; }
    }
}
