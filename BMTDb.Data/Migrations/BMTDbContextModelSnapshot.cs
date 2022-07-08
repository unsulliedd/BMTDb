﻿// <auto-generated />
using System;
using BMTDb.Data.Concrete.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BMTDb.Data.Migrations
{
    [DbContext(typeof(BMTDbContext))]
    partial class BMTDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BMTDb.Entity.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<DateTime?>("Episode_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Episode_Number")
                        .HasColumnType("int");

                    b.Property<string>("Episode_Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("BMTDb.Entity.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.Favourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.FavouriteItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FavouriteId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavouriteId");

                    b.HasIndex("MovieId");

                    b.ToTable("FavouriteItems");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.Watchlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Watchlists");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.WatchlistItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("WatchlistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("WatchlistId");

                    b.ToTable("WatchlistItems");
                });

            modelBuilder.Entity("BMTDb.Entity.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<int?>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMDBId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieBackdrop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoviePoster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieRatings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieTagline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RunTime")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TMDbId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieCrew", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("MovieCrew");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieStudio", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("StudioId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "StudioId");

                    b.HasIndex("StudioId");

                    b.ToTable("MovieStudio");
                });

            modelBuilder.Entity("BMTDb.Entity.Network", b =>
                {
                    b.Property<int>("NetworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NetworkId"), 1L, 1);

                    b.Property<string>("Network_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Netwotk_logo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NetworkId");

                    b.ToTable("Networks");
                });

            modelBuilder.Entity("BMTDb.Entity.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deathday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imdb_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BMTDb.Entity.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeasonId"), 1L, 1);

                    b.Property<string>("Air_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Season_Number")
                        .HasColumnType("int");

                    b.Property<string>("Season_poster")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("BMTDb.Entity.SeasonEpisode", b =>
                {
                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("SeasonId", "EpisodeId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("SeasonEpisode");
                });

            modelBuilder.Entity("BMTDb.Entity.Studio", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudioId"), 1L, 1);

                    b.Property<string>("Studio_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Studio_logo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioId");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShow", b =>
                {
                    b.Property<int>("TvShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TvShowId"), 1L, 1);

                    b.Property<int?>("Episode_RunTime")
                        .HasColumnType("int");

                    b.Property<string>("IMDBId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number_of_Episodes")
                        .HasColumnType("int");

                    b.Property<int?>("Number_of_Seasons")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("TMDbId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Backdrop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TvShow_Budget")
                        .HasColumnType("int");

                    b.Property<string>("TvShow_Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Ratings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Tagline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TvShow_Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TvShowId");

                    b.ToTable("TvShows");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowCrew", b =>
                {
                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("TvShowId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("TvShowCrew");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowGenre", b =>
                {
                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("TvShowId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("TvShowGenre");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowNetwork", b =>
                {
                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.Property<int>("NetworkId")
                        .HasColumnType("int");

                    b.HasKey("TvShowId", "NetworkId");

                    b.HasIndex("NetworkId");

                    b.ToTable("TvShowNetwork");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowSeason", b =>
                {
                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.HasKey("TvShowId", "SeasonId");

                    b.HasIndex("SeasonId");

                    b.ToTable("TvShowSeason");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.FavouriteItem", b =>
                {
                    b.HasOne("BMTDb.Entity.Lists.Favourite", "Favourite")
                        .WithMany("FavouriteItems")
                        .HasForeignKey("FavouriteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Favourite");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.WatchlistItem", b =>
                {
                    b.HasOne("BMTDb.Entity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Lists.Watchlist", "Watchlist")
                        .WithMany("WatchlistItems")
                        .HasForeignKey("WatchlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Watchlist");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieCrew", b =>
                {
                    b.HasOne("BMTDb.Entity.Movie", "Movie")
                        .WithMany("MovieCrews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Person", "Person")
                        .WithMany("MovieCrews")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieGenre", b =>
                {
                    b.HasOne("BMTDb.Entity.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BMTDb.Entity.MovieStudio", b =>
                {
                    b.HasOne("BMTDb.Entity.Movie", "Movie")
                        .WithMany("MovieStudios")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Studio", "Studios")
                        .WithMany("MovieStudios")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Studios");
                });

            modelBuilder.Entity("BMTDb.Entity.SeasonEpisode", b =>
                {
                    b.HasOne("BMTDb.Entity.Episode", "Episode")
                        .WithMany("SeasonEpisodes")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.Season", "Season")
                        .WithMany("SeasonEpisodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowCrew", b =>
                {
                    b.HasOne("BMTDb.Entity.Person", "Person")
                        .WithMany("TvCrews")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.TvShow", "TvShow")
                        .WithMany("TvCrews")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowGenre", b =>
                {
                    b.HasOne("BMTDb.Entity.Genre", "Genre")
                        .WithMany("TvShowGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.TvShow", "TvShow")
                        .WithMany("TvShowGenres")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowNetwork", b =>
                {
                    b.HasOne("BMTDb.Entity.Network", "Networks")
                        .WithMany("TvShowNetworks")
                        .HasForeignKey("NetworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.TvShow", "TvShow")
                        .WithMany("TvShowNetworks")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Networks");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShowSeason", b =>
                {
                    b.HasOne("BMTDb.Entity.Season", "Season")
                        .WithMany("TvShowSeasons")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMTDb.Entity.TvShow", "TvShow")
                        .WithMany("TvShowSeasons")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("BMTDb.Entity.Episode", b =>
                {
                    b.Navigation("SeasonEpisodes");
                });

            modelBuilder.Entity("BMTDb.Entity.Genre", b =>
                {
                    b.Navigation("MovieGenres");

                    b.Navigation("TvShowGenres");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.Favourite", b =>
                {
                    b.Navigation("FavouriteItems");
                });

            modelBuilder.Entity("BMTDb.Entity.Lists.Watchlist", b =>
                {
                    b.Navigation("WatchlistItems");
                });

            modelBuilder.Entity("BMTDb.Entity.Movie", b =>
                {
                    b.Navigation("MovieCrews");

                    b.Navigation("MovieGenres");

                    b.Navigation("MovieStudios");
                });

            modelBuilder.Entity("BMTDb.Entity.Network", b =>
                {
                    b.Navigation("TvShowNetworks");
                });

            modelBuilder.Entity("BMTDb.Entity.Person", b =>
                {
                    b.Navigation("MovieCrews");

                    b.Navigation("TvCrews");
                });

            modelBuilder.Entity("BMTDb.Entity.Season", b =>
                {
                    b.Navigation("SeasonEpisodes");

                    b.Navigation("TvShowSeasons");
                });

            modelBuilder.Entity("BMTDb.Entity.Studio", b =>
                {
                    b.Navigation("MovieStudios");
                });

            modelBuilder.Entity("BMTDb.Entity.TvShow", b =>
                {
                    b.Navigation("TvCrews");

                    b.Navigation("TvShowGenres");

                    b.Navigation("TvShowNetworks");

                    b.Navigation("TvShowSeasons");
                });
#pragma warning restore 612, 618
        }
    }
}
