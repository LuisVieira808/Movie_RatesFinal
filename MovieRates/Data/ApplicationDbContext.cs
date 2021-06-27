using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieRates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieRates.Data
{
  

    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "c", Name = "Cliente", NormalizedName = "CLIENTE" },
            new IdentityRole { Id = "g", Name = "Gestor", NormalizedName = "GESTOR" }
         );


            // insert DB seed

            modelBuilder.Entity<Filmes>().HasData(
               new Filmes { IdFilmes = 1, Capa = "6Underground.jpg", Titulo = "6 Underground", Data = new DateTime(2019, 12, 13), Descricao = "Six individuals from all around the globe, each the very best at what they do, have been chosen not only for their skill, but for a unique desire to delete their pasts to change the future.", Elenco = " Ryan Reynolds, Mélanie Laurent, Manuel Garcia-Rulfo ", Link = "https://www.imdb.com/title/tt8106534/?ref_=nv_sr_srsg_0", Realizador = "Michael Bay", Duracao = "2h 8min", Pontuacao = 6.1 },
               new Filmes { IdFilmes = 2, Capa = "SpenserConfidential.jpg", Titulo = "Spenser Confidential", Data = new DateTime(2020, 3, 6), Descricao = "When two Boston police officers are murdered, ex-cop Spenser teams up with his no-nonsense roommate, Hawk, to take down criminals.", Elenco = "Mark Wahlberg, Winston Duke, Alan Arkin", Link = "https://www.imdb.com/title/tt8629748/?ref_=nv_sr_srsg_0", Realizador = "Peter Berg", Duracao = "1h 51min", Pontuacao = 6.2 },
               new Filmes { IdFilmes = 3, Capa = "Extraction.jpg", Titulo = "Extraction", Data = new DateTime(2020, 4, 24), Descricao = "Tyler Rake, a fearless black market mercenary, embarks on the most deadly extraction of his career when he's enlisted to rescue the kidnapped son of an imprisoned international crime lord.", Elenco = "Chris Hemsworth, Bryon Lerum, Ryder Lerum", Link = "https://www.imdb.com/title/tt8936646/?ref_=nv_sr_srsg_0", Realizador = "Sam Hargrave", Duracao = "1h 56min", Pontuacao = 6.7 },
               new Filmes { IdFilmes = 4, Capa = "LoveAndMonsters.jpg", Titulo = "Love and Monsters", Data = new DateTime(2020, 10, 16), Descricao = "Seven years after he survived the monster apocalypse, lovably hapless Joel leaves his cozy underground bunker behind on a quest to reunite with his ex.", Elenco = "Dylan O'Brien, Jessica Henwick, Michael Rooker", Link = "https://www.imdb.com/title/tt2222042/?ref_=nv_sr_srsg_0", Realizador = "Michael Matthews", Duracao = "1h 49min", Pontuacao = 7.0 },
               new Filmes { IdFilmes = 5, Capa = "Skyscraper.jpg", Titulo = "Skyscraper", Data = new DateTime(2018, 7, 13), Descricao = "A security expert must infiltrate a burning skyscraper, 225 stories above ground, when his family is trapped inside by criminals.", Elenco = "Dwayne Johnson, Neve Campbell, Chin Han", Link = "https://www.imdb.com/title/tt5758778/?ref_=nv_sr_srsg_0", Realizador = "Rawson Marshall Thurber", Duracao = "1h 42min", Pontuacao = 5.8 },
               new Filmes { IdFilmes = 6, Capa = "Fighting.jpg", Titulo = "Fighting", Data = new DateTime(2009, 4, 24), Descricao = "In New York City, a young counterfeiter is introduced to the world of underground street fighting by a seasoned scam artist, who becomes his manager on the bare-knuckling brawling circuit.", Elenco = "Channing Tatum, Terrence Howard, Luis Guzmán", Link = "https://www.imdb.com/title/tt1082601/?ref_=nv_sr_srsg_0", Realizador = "Dito Montiel", Duracao = "1h 45min", Pontuacao = 5.6 },
               new Filmes { IdFilmes = 7, Capa = "Avatar.jpg", Titulo = "Avatar", Data = new DateTime(2009, 12, 18), Descricao = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", Elenco = "Sam Worthington, Zoe Saldana, Sigourney Weaver", Link = "https://www.imdb.com/title/tt0499549/?ref_=nv_sr_srsg_3", Realizador = "James Cameron", Duracao = "2h 42min", Pontuacao = 7.8 },
               new Filmes { IdFilmes = 8, Capa = "Faster.jpg", Titulo = "Faster", Data = new DateTime(2010, 11, 24), Descricao = "An ex-con gets on a series of apparently unrelated killings. He gets tracked by a veteran cop with secrets of his own and an egocentric hit man.", Elenco = " Dwayne Johnson, Billy Bob Thornton, Maggie Grace", Link = "https://www.imdb.com/title/tt1433108/?ref_=nv_sr_srsg_0", Realizador = "George Tillman Jr.", Duracao = "1h 38min", Pontuacao = 6.4 },
               new Filmes { IdFilmes = 9, Capa = "Hancock.jpg", Titulo = "Hancock", Data = new DateTime(2008, 7, 2), Descricao = "Hancock is a superhero whose ill-considered behavior regularly causes damage in the millions. He changes when the person he saves helps him improve his public image.", Elenco = "Will Smith, Charlize Theron, Jason Bateman", Link = "https://www.imdb.com/title/tt0448157/?ref_=nv_sr_srsg_0", Realizador = " Peter Berg", Duracao = "1h 32min", Pontuacao = 6.4 },
               new Filmes { IdFilmes = 10, Capa = "DeathRace.jpg", Titulo = "Death Race", Data = new DateTime(2008, 8, 22), Descricao = "Ex-con Jensen Ames is forced by the warden of a notorious prison to compete in our post-industrial world's most popular sport: a car race in which inmates must brutalize and kill one another on the road to victory.", Elenco = " Jason Statham, Joan Allen, Tyrese Gibson", Link = "https://www.imdb.com/title/tt0452608/?ref_=nv_sr_srsg_0", Realizador = "Paul W.S. Anderson", Duracao = "1h 45min", Pontuacao = 6.4 },
               new Filmes { IdFilmes = 11, Capa = "DeathRace2.jpg", Titulo = "Death Race 2", Data = new DateTime(2011, 1, 18), Descricao = "Explores the origins of the first 'Frankenstein' car driver, Carl 'Luke' Lucas, who died in a race at the beginning of the first film.", Elenco = " Luke Goss, Lauren Cohan, Sean Bean", Link = "https://www.imdb.com/title/tt1500491/?ref_=nv_sr_srsg_5", Realizador = "Roel Reiné", Duracao = "1h 36min", Pontuacao = 5.6 },
               new Filmes { IdFilmes = 12, Capa = "DeathRace3.jpg", Titulo = "Death Race: Inferno", Data = new DateTime(2013, 1, 20), Descricao = "Convicted cop-killer Carl Lucas, aka Frankenstein, is a superstar driver in the brutal prison yard demolition derby known as Death Race. Only one victory away from winning freedom for himself and his pit crew.", Elenco = " Luke Goss, Tanit Phoenix Copley, Danny Trejo", Link = "https://www.imdb.com/title/tt1988591/?ref_=nv_sr_srsg_6", Realizador = "Roel Reiné", Duracao = "1h 44min", Pontuacao = 5.5 },
               new Filmes { IdFilmes = 13, Capa = "DeathRace4.jpg", Titulo = "Death Race 4: Beyond Anarchy", Data = new DateTime(2018, 9, 2), Descricao = "With the U.S. on its knees, suffering from complete societal collapse and rampant anarchy, the nefarious Weyland Corporation has created a vast and impenetrable prison-city called 'The Sprawl', where more than 400,000 inmates are left to rot. Under those circumstances, the secluded community's undisputed ruler is the unknown iconic driver known only as 'Frankenstein', who is still the king of the deadly Death Races, now broadcast over the Dark Web. Then, a new powerful contestant arrives--the mysterious, Connor Gibson--who is hell-bent on beating Frankenstein himself at his own game; however, this is easier said than done. Does Connor have what it takes to humiliate the master of the races before millions of spectators?", Elenco = " Lucy Aarden, Nicholas Aaron, Jasette Amos", Link = "https://www.imdb.com/title/tt3807900/?ref_=nv_sr_srsg_3", Realizador = "Don Michael Paul", Duracao = "1h 51min", Pontuacao = 5.2 },
               new Filmes { IdFilmes = 14, Capa = "EdgeOfTomorrow.jpg", Titulo = "Edge of Tomorrow", Data = new DateTime(2014, 6, 6), Descricao = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.", Elenco = " Tom Cruise, Emily Blunt, Bill Paxton", Link = "https://www.imdb.com/title/tt1631867/?ref_=nv_sr_srsg_0", Realizador = " Doug Liman", Duracao = "1h 53min", Pontuacao = 7.9 },
               new Filmes { IdFilmes = 15, Capa = "Avengement.jpg", Titulo = "Avengement", Data = new DateTime(2019, 5, 24), Descricao = "After years of assaults on him in prison, convicted felon Cain Burgess escapes for avengement on those responsible.", Elenco = " Scott Adkins, Craig Fairbrass, Thomas Turgoose", Link = "https://www.imdb.com/title/tt8836988/?ref_=nv_sr_srsg_0", Realizador = " Jesse V. Johnson", Duracao = " 1h 27min", Pontuacao = 6.5 },
               new Filmes { IdFilmes = 16, Capa = "Saw.jpg", Titulo = "Saw - Enigma Mortal", Data = new DateTime(2005, 3, 3), Descricao = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.", Elenco = "Cary Elwes, Leigh Whannell, Danny Glover", Link = "https://www.imdb.com/title/tt0387564/?ref_=fn_al_tt_1", Realizador = "James Wan", Duracao = "1h 43min", Pontuacao = 7.6},
               new Filmes { IdFilmes = 17, Capa = "SawV.jpg", Titulo = "Jigsaw: O Legado de Saw", Data = new DateTime(2017, 10, 26), Descricao = "Bodies are turning up around the city, each having met a uniquely gruesome demise. As the investigation proceeds, evidence points to one suspect: John Kramer, the man known as Jigsaw, who has been dead for over 10 years.", Elenco = "Matt Passmore, Tobin Bell, Callum Keith Rennie", Link = "https://www.imdb.com/title/tt3348730/?ref_=tt_mv_close", Realizador = "Michael Spierig, Peter Spierig", Duracao = "1h 32min", Pontuacao = 5.8 },
               new Filmes { IdFilmes = 18, Capa = "SawII.jpg", Titulo = "Saw II - A Experiência do Medo", Data = new DateTime(2016, 1, 19), Descricao = "A detective and his team must rescue 8 people trapped in a factory by the twisted serial killer known as Jigsaw.", Elenco = "Donnie Wahlberg, Beverley Mitchell, Franky G", Link = "https://www.imdb.com/title/tt0432348/?ref_=tt_mv_close", Realizador = "Darren Lynn Bousman", Duracao = "1h 33min", Pontuacao = 6.6 },
               new Filmes { IdFilmes = 19, Capa = "SawIII.jpg", Titulo = "Saw 3D - O Capítulo Final", Data = new DateTime(2018, 11, 18), Descricao = "As a deadly battle rages over Jigsaw's brutal legacy, a group of Jigsaw survivors gathers to seek the support of self-help guru and fellow survivor Bobby Dagen, a man whose own dark secrets unleash a new wave of terror.", Elenco = "Tobin Bell, Costas Mandylor, Betsy Russell", Link = "https://www.imdb.com/title/tt1477076/?ref_=tt_mv_close", Realizador = "Kevin Greutert", Duracao = "1h 30min", Pontuacao = 5.6 },
               new Filmes { IdFilmes = 20, Capa = "EscapeRoom.jpg", Titulo = "Escape Room", Data = new DateTime(2017, 10, 26), Descricao = "Six friends test their intelligence when an escape room they participate in takes a dark and twisted turn.", Elenco = "Evan Williams, Annabelle Stephenson, Elisabeth Hower", Link = "https://www.imdb.com/title/tt5159414/?ref_=tt_mv_close", Realizador = "Will Wernick", Duracao = "1h 21min", Pontuacao = 4.2 },
               new Filmes { IdFilmes = 21, Capa = "EscapeRoomII.jpg", Titulo = "Escape Room 2", Data = new DateTime(2019, 1, 10), Descricao = "Six strangers find themselves in a maze of deadly mystery rooms and must use their wits to survive.", Elenco = "Taylor Russell, Logan Miller, Jay Ellis", Link = "https://www.imdb.com/title/tt5886046/?ref_=tt_mv_close", Realizador = "Adam Robitel", Duracao = " 1h 39min", Pontuacao = 6.4 },
               new Filmes { IdFilmes = 22, Capa = "IT.jpg", Titulo = "It", Data = new DateTime(2017, 11, 14), Descricao = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", Elenco = "Bill Skarsgård, Jaeden Martell, Finn Wolfhard", Link = "https://www.imdb.com/title/tt1396484/?ref_=tt_mv_close", Realizador = "Andy Muschietti", Duracao = "2h 15min", Pontuacao = 7.3 },
               new Filmes { IdFilmes = 23, Capa = "ITII.jpg", Titulo = "It Capítulo 2", Data = new DateTime(2019, 11, 5), Descricao = "Twenty-seven years after their first encounter with the terrifying Pennywise, the Losers Club have grown up and moved away, until a devastating phone call brings them back.", Elenco = "Jessica Chastain, James McAvoy, Bill Hader", Link = "https://www.imdb.com/title/tt7349950/?ref_=tt_mv_close", Realizador = "Andy Muschietti", Duracao = "2h 49min", Pontuacao = 6.5 }
            );

            modelBuilder.Entity<Categorias>().HasData(
               new Categorias { IdCategorias = 1, Nome = "Action" },
               new Categorias { IdCategorias = 2, Nome = "Comedy" },
               new Categorias { IdCategorias = 3, Nome = "dasfew" },
               new Categorias { IdCategorias = 4, Nome = "Thriller" },
               new Categorias { IdCategorias = 5, Nome = "Horror" },
               new Categorias { IdCategorias = 6, Nome = "Crime" },
               new Categorias { IdCategorias = 7, Nome = "Drama" },
               new Categorias { IdCategorias = 8, Nome = "Fantasy" },
               new Categorias { IdCategorias = 9, Nome = "Adventure" },
               new Categorias { IdCategorias = 10, Nome = "Sci-Fi" },
               new Categorias { IdCategorias = 11, Nome = "Animation" },
               new Categorias { IdCategorias = 12, Nome = "Mystery" },
               new Categorias { IdCategorias = 13, Nome = "Classic" },
               new Categorias { IdCategorias = 14, Nome = "Romance" },
               new Categorias { IdCategorias = 15, Nome = "Musical" },
               new Categorias { IdCategorias = 16, Nome = "Documentarie" },
               new Categorias { IdCategorias = 17, Nome = "War" },
               new Categorias { IdCategorias = 18, Nome = "Western Films" },
               new Categorias { IdCategorias = 19, Nome = "Romantic Comedy" },
               new Categorias { IdCategorias = 20, Nome = "Foreign Movie" }
            );

            modelBuilder.Entity<FilmeCategorias>().HasData(
                new FilmeCategorias { IdFilmeCategorias = 1, CategoriasFK = 1, FilmesFK = 1 },
                new FilmeCategorias { IdFilmeCategorias = 2, CategoriasFK = 2, FilmesFK = 2 },
                new FilmeCategorias { IdFilmeCategorias = 3, CategoriasFK = 3, FilmesFK = 3 },
                new FilmeCategorias { IdFilmeCategorias = 4, CategoriasFK = 4, FilmesFK = 4 },
                new FilmeCategorias { IdFilmeCategorias = 5, CategoriasFK = 5, FilmesFK = 5 },
                new FilmeCategorias { IdFilmeCategorias = 6, CategoriasFK = 6, FilmesFK = 6 },
                new FilmeCategorias { IdFilmeCategorias = 7, CategoriasFK = 7, FilmesFK = 7 },
                new FilmeCategorias { IdFilmeCategorias = 8, CategoriasFK = 8, FilmesFK = 8 },
                new FilmeCategorias { IdFilmeCategorias = 9, CategoriasFK = 9, FilmesFK = 9 },
                new FilmeCategorias { IdFilmeCategorias = 10, CategoriasFK = 10, FilmesFK = 10 },
                new FilmeCategorias { IdFilmeCategorias = 11, CategoriasFK = 11, FilmesFK = 11 },
                new FilmeCategorias { IdFilmeCategorias = 12, CategoriasFK = 12, FilmesFK = 12 },
                new FilmeCategorias { IdFilmeCategorias = 13, CategoriasFK = 13, FilmesFK = 13 },
                new FilmeCategorias { IdFilmeCategorias = 14, CategoriasFK = 14, FilmesFK = 14 },
                new FilmeCategorias { IdFilmeCategorias = 15, CategoriasFK = 15, FilmesFK = 15 },
                new FilmeCategorias { IdFilmeCategorias = 16, CategoriasFK = 16, FilmesFK = 16 },
                new FilmeCategorias { IdFilmeCategorias = 17, CategoriasFK = 17, FilmesFK = 17},
                new FilmeCategorias { IdFilmeCategorias = 18, CategoriasFK = 18, FilmesFK = 18},
                new FilmeCategorias { IdFilmeCategorias = 19, CategoriasFK = 19, FilmesFK = 19 },
                new FilmeCategorias { IdFilmeCategorias = 20, CategoriasFK = 20, FilmesFK = 20 }



            );



        }

        /// <summary>
        /// Representar a Tabela Filmes da BD
        /// </summary>
        public DbSet<Filmes> Filmes { get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<FilmeCategorias> FilmeCategorias { get; set; }
        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}