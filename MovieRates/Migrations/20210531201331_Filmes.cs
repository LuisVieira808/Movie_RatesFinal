using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRates.Migrations
{
    public partial class Filmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategorias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategorias);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    IdFilmes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Realizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Elenco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pontuacao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.IdFilmes);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    IdUtilizador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.IdUtilizador);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmeCategorias",
                columns: table => new
                {
                    IdFilmeCategorias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriasFK = table.Column<int>(type: "int", nullable: false),
                    FilmesFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeCategorias", x => x.IdFilmeCategorias);
                    table.ForeignKey(
                        name: "FK_FilmeCategorias_Categorias_CategoriasFK",
                        column: x => x.CategoriasFK,
                        principalTable: "Categorias",
                        principalColumn: "IdCategorias",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmeCategorias_Filmes_FilmesFK",
                        column: x => x.FilmesFK,
                        principalTable: "Filmes",
                        principalColumn: "IdFilmes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    IdReview = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pontuacao = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilizadoresFK = table.Column<int>(type: "int", nullable: false),
                    FilmesFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.IdReview);
                    table.ForeignKey(
                        name: "FK_Reviews_Filmes_FilmesFK",
                        column: x => x.FilmesFK,
                        principalTable: "Filmes",
                        principalColumn: "IdFilmes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Utilizadores_UtilizadoresFK",
                        column: x => x.UtilizadoresFK,
                        principalTable: "Utilizadores",
                        principalColumn: "IdUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategorias", "Nome" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 20, "Foreign Movie" },
                    { 19, "Romantic Comedy" },
                    { 18, "Western Films" },
                    { 17, "War" },
                    { 16, "Documentarie" },
                    { 14, "Romance" },
                    { 13, "Classic" },
                    { 12, "Mystery" },
                    { 11, "Animation" },
                    { 15, "Musical" },
                    { 9, "Adventure" },
                    { 8, "Fantasy" },
                    { 7, "Drama" },
                    { 6, "Crime" },
                    { 5, "Horror" },
                    { 4, "Thriller" },
                    { 3, "dasfew" },
                    { 2, "Comedy" },
                    { 10, "Sci-Fi" }
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilmes", "Capa", "Data", "Descricao", "Duracao", "Elenco", "Link", "Pontuacao", "Realizador", "Titulo" },
                values: new object[,]
                {
                    { 14, "EdgeOfTomorrow.jpg", new DateTime(2014, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.", "1h 53min", " Tom Cruise, Emily Blunt, Bill Paxton", "https://www.imdb.com/title/tt1631867/?ref_=nv_sr_srsg_0", 7.9000000000000004, " Doug Liman", "Edge of Tomorrow" },
                    { 15, "Avengement.jpg", new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "After years of assaults on him in prison, convicted felon Cain Burgess escapes for avengement on those responsible.", " 1h 27min", " Scott Adkins, Craig Fairbrass, Thomas Turgoose", "https://www.imdb.com/title/tt8836988/?ref_=nv_sr_srsg_0", 6.5, " Jesse V. Johnson", "Avengement" },
                    { 16, "Saw.jpg", new DateTime(2005, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.", "1h 43min", "Cary Elwes, Leigh Whannell, Danny Glover", "https://www.imdb.com/title/tt0387564/?ref_=fn_al_tt_1", 7.5999999999999996, "James Wan", "Saw - Enigma Mortal" },
                    { 17, "SawV.jpg", new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bodies are turning up around the city, each having met a uniquely gruesome demise. As the investigation proceeds, evidence points to one suspect: John Kramer, the man known as Jigsaw, who has been dead for over 10 years.", "1h 32min", "Matt Passmore, Tobin Bell, Callum Keith Rennie", "https://www.imdb.com/title/tt3348730/?ref_=tt_mv_close", 5.7999999999999998, "Michael Spierig, Peter Spierig", "Jigsaw: O Legado de Saw" },
                    { 21, "EscapeRoomII.jpg", new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Six strangers find themselves in a maze of deadly mystery rooms and must use their wits to survive.", " 1h 39min", "Taylor Russell, Logan Miller, Jay Ellis", "https://www.imdb.com/title/tt5886046/?ref_=tt_mv_close", 6.4000000000000004, "Adam Robitel", "Escape Room 2" },
                    { 19, "SawIII.jpg", new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "As a deadly battle rages over Jigsaw's brutal legacy, a group of Jigsaw survivors gathers to seek the support of self-help guru and fellow survivor Bobby Dagen, a man whose own dark secrets unleash a new wave of terror.", "1h 30min", "Tobin Bell, Costas Mandylor, Betsy Russell", "https://www.imdb.com/title/tt1477076/?ref_=tt_mv_close", 5.5999999999999996, "Kevin Greutert", "Saw 3D - O Capítulo Final" },
                    { 20, "EscapeRoom.jpg", new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Six friends test their intelligence when an escape room they participate in takes a dark and twisted turn.", "1h 21min", "Evan Williams, Annabelle Stephenson, Elisabeth Hower", "https://www.imdb.com/title/tt5159414/?ref_=tt_mv_close", 4.2000000000000002, "Will Wernick", "Escape Room" },
                    { 13, "DeathRace4.jpg", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "With the U.S. on its knees, suffering from complete societal collapse and rampant anarchy, the nefarious Weyland Corporation has created a vast and impenetrable prison-city called 'The Sprawl', where more than 400,000 inmates are left to rot. Under those circumstances, the secluded community's undisputed ruler is the unknown iconic driver known only as 'Frankenstein', who is still the king of the deadly Death Races, now broadcast over the Dark Web. Then, a new powerful contestant arrives--the mysterious, Connor Gibson--who is hell-bent on beating Frankenstein himself at his own game; however, this is easier said than done. Does Connor have what it takes to humiliate the master of the races before millions of spectators?", "1h 51min", " Lucy Aarden, Nicholas Aaron, Jasette Amos", "https://www.imdb.com/title/tt3807900/?ref_=nv_sr_srsg_3", 5.2000000000000002, "Don Michael Paul", "Death Race 4: Beyond Anarchy" },
                    { 18, "SawII.jpg", new DateTime(2016, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A detective and his team must rescue 8 people trapped in a factory by the twisted serial killer known as Jigsaw.", "1h 33min", "Donnie Wahlberg, Beverley Mitchell, Franky G", "https://www.imdb.com/title/tt0432348/?ref_=tt_mv_close", 6.5999999999999996, "Darren Lynn Bousman", "Saw II - A Experiência do Medo" },
                    { 12, "DeathRace3.jpg", new DateTime(2013, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Convicted cop-killer Carl Lucas, aka Frankenstein, is a superstar driver in the brutal prison yard demolition derby known as Death Race. Only one victory away from winning freedom for himself and his pit crew.", "1h 44min", " Luke Goss, Tanit Phoenix Copley, Danny Trejo", "https://www.imdb.com/title/tt1988591/?ref_=nv_sr_srsg_6", 5.5, "Roel Reiné", "Death Race: Inferno" },
                    { 2, "SpenserConfidential.jpg", new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "When two Boston police officers are murdered, ex-cop Spenser teams up with his no-nonsense roommate, Hawk, to take down criminals.", "1h 51min", "Mark Wahlberg, Winston Duke, Alan Arkin", "https://www.imdb.com/title/tt8629748/?ref_=nv_sr_srsg_0", 6.2000000000000002, "Peter Berg", "Spenser Confidential" },
                    { 10, "DeathRace.jpg", new DateTime(2008, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex-con Jensen Ames is forced by the warden of a notorious prison to compete in our post-industrial world's most popular sport: a car race in which inmates must brutalize and kill one another on the road to victory.", "1h 45min", " Jason Statham, Joan Allen, Tyrese Gibson", "https://www.imdb.com/title/tt0452608/?ref_=nv_sr_srsg_0", 6.4000000000000004, "Paul W.S. Anderson", "Death Race" },
                    { 9, "Hancock.jpg", new DateTime(2008, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hancock is a superhero whose ill-considered behavior regularly causes damage in the millions. He changes when the person he saves helps him improve his public image.", "1h 32min", "Will Smith, Charlize Theron, Jason Bateman", "https://www.imdb.com/title/tt0448157/?ref_=nv_sr_srsg_0", 6.4000000000000004, " Peter Berg", "Hancock" },
                    { 8, "Faster.jpg", new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "An ex-con gets on a series of apparently unrelated killings. He gets tracked by a veteran cop with secrets of his own and an egocentric hit man.", "1h 38min", " Dwayne Johnson, Billy Bob Thornton, Maggie Grace", "https://www.imdb.com/title/tt1433108/?ref_=nv_sr_srsg_0", 6.4000000000000004, "George Tillman Jr.", "Faster" },
                    { 7, "Avatar.jpg", new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", "2h 42min", "Sam Worthington, Zoe Saldana, Sigourney Weaver", "https://www.imdb.com/title/tt0499549/?ref_=nv_sr_srsg_3", 7.7999999999999998, "James Cameron", "Avatar" },
                    { 6, "Fighting.jpg", new DateTime(2009, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "In New York City, a young counterfeiter is introduced to the world of underground street fighting by a seasoned scam artist, who becomes his manager on the bare-knuckling brawling circuit.", "1h 45min", "Channing Tatum, Terrence Howard, Luis Guzmán", "https://www.imdb.com/title/tt1082601/?ref_=nv_sr_srsg_0", 5.5999999999999996, "Dito Montiel", "Fighting" },
                    { 5, "Skyscraper.jpg", new DateTime(2018, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A security expert must infiltrate a burning skyscraper, 225 stories above ground, when his family is trapped inside by criminals.", "1h 42min", "Dwayne Johnson, Neve Campbell, Chin Han", "https://www.imdb.com/title/tt5758778/?ref_=nv_sr_srsg_0", 5.7999999999999998, "Rawson Marshall Thurber", "Skyscraper" },
                    { 4, "LoveAndMonsters.jpg", new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seven years after he survived the monster apocalypse, lovably hapless Joel leaves his cozy underground bunker behind on a quest to reunite with his ex.", "1h 49min", "Dylan O'Brien, Jessica Henwick, Michael Rooker", "https://www.imdb.com/title/tt2222042/?ref_=nv_sr_srsg_0", 7.0, "Michael Matthews", "Love and Monsters" },
                    { 3, "Extraction.jpg", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler Rake, a fearless black market mercenary, embarks on the most deadly extraction of his career when he's enlisted to rescue the kidnapped son of an imprisoned international crime lord.", "1h 56min", "Chris Hemsworth, Bryon Lerum, Ryder Lerum", "https://www.imdb.com/title/tt8936646/?ref_=nv_sr_srsg_0", 6.7000000000000002, "Sam Hargrave", "Extraction" },
                    { 22, "IT.jpg", new DateTime(2017, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.", "2h 15min", "Bill Skarsgård, Jaeden Martell, Finn Wolfhard", "https://www.imdb.com/title/tt1396484/?ref_=tt_mv_close", 7.2999999999999998, "Andy Muschietti", "It" },
                    { 1, "6Underground.jpg", new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Six individuals from all around the globe, each the very best at what they do, have been chosen not only for their skill, but for a unique desire to delete their pasts to change the future.", "2h 8min", " Ryan Reynolds, Mélanie Laurent, Manuel Garcia-Rulfo ", "https://www.imdb.com/title/tt8106534/?ref_=nv_sr_srsg_0", 6.0999999999999996, "Michael Bay", "6 Underground" },
                    { 11, "DeathRace2.jpg", new DateTime(2011, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explores the origins of the first 'Frankenstein' car driver, Carl 'Luke' Lucas, who died in a race at the beginning of the first film.", "1h 36min", " Luke Goss, Lauren Cohan, Sean Bean", "https://www.imdb.com/title/tt1500491/?ref_=nv_sr_srsg_5", 5.5999999999999996, "Roel Reiné", "Death Race 2" }
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilmes", "Capa", "Data", "Descricao", "Duracao", "Elenco", "Link", "Pontuacao", "Realizador", "Titulo" },
                values: new object[] { 23, "ITII.jpg", new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twenty-seven years after their first encounter with the terrifying Pennywise, the Losers Club have grown up and moved away, until a devastating phone call brings them back.", "2h 49min", "Jessica Chastain, James McAvoy, Bill Hader", "https://www.imdb.com/title/tt7349950/?ref_=tt_mv_close", 6.5, "Andy Muschietti", "It Capítulo 2" });

            migrationBuilder.InsertData(
                table: "FilmeCategorias",
                columns: new[] { "IdFilmeCategorias", "CategoriasFK", "FilmesFK" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 18, 18, 18 },
                    { 17, 17, 17 },
                    { 16, 16, 16 },
                    { 15, 15, 15 },
                    { 14, 14, 14 },
                    { 13, 13, 13 },
                    { 12, 12, 12 },
                    { 11, 11, 11 },
                    { 10, 10, 10 },
                    { 9, 9, 9 },
                    { 8, 8, 8 },
                    { 7, 7, 7 },
                    { 6, 6, 6 },
                    { 5, 5, 5 },
                    { 4, 4, 4 },
                    { 3, 3, 3 },
                    { 2, 2, 2 },
                    { 19, 19, 19 },
                    { 20, 20, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeCategorias_CategoriasFK",
                table: "FilmeCategorias",
                column: "CategoriasFK");

            migrationBuilder.CreateIndex(
                name: "IX_FilmeCategorias_FilmesFK",
                table: "FilmeCategorias",
                column: "FilmesFK");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FilmesFK",
                table: "Reviews",
                column: "FilmesFK");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UtilizadoresFK",
                table: "Reviews",
                column: "UtilizadoresFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FilmeCategorias");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
