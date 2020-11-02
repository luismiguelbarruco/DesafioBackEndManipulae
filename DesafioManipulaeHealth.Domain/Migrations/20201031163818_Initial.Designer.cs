﻿// <auto-generated />
using System;
using DesafioManipulaeHealth.Domain.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioManipulaeHealth.Domain.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201031163818_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.ResourceVideoYoutube", b =>
                {
                    b.Property<int>("ResourceVideoYoutubeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChannelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kind")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaylistId")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoId")
                        .HasColumnType("TEXT");

                    b.HasKey("ResourceVideoYoutubeId");

                    b.ToTable("ResourcesVideoYoutube");
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.VideoYoutube", b =>
                {
                    b.Property<int>("VideoYoutubeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kind")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceVideoYoutubeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YoutubeSearchResultSnippetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VideoYoutubeId");

                    b.HasIndex("ResourceVideoYoutubeId");

                    b.HasIndex("YoutubeSearchResultSnippetId");

                    b.ToTable("VideosYoutube");
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.YoutubeSearchResultSnippet", b =>
                {
                    b.Property<int>("YoutubeSearchResultSnippetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChannelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChannelTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<string>("LiveBroadcastContent")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublishedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("YoutubeThumbnailDetailsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("YoutubeSearchResultSnippetId");

                    b.HasIndex("YoutubeThumbnailDetailsId");

                    b.ToTable("YoutubeSearchsResultSnippet");
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", b =>
                {
                    b.Property<int>("YoutubeThumbnailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("YoutubeThumbnailId");

                    b.ToTable("YoutubeThumbnails");
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnailDetails", b =>
                {
                    b.Property<int>("YoutubeThumbnailDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ETag")
                        .HasColumnType("TEXT");

                    b.Property<int>("YoutubeThumbnailDefaultId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YoutubeThumbnailHighId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YoutubeThumbnailMaxresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YoutubeThumbnailMediumId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YoutubeThumbnailStandardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("YoutubeThumbnailDetailsId");

                    b.HasIndex("YoutubeThumbnailDefaultId");

                    b.HasIndex("YoutubeThumbnailHighId");

                    b.HasIndex("YoutubeThumbnailMaxresId");

                    b.HasIndex("YoutubeThumbnailMediumId");

                    b.HasIndex("YoutubeThumbnailStandardId");

                    b.ToTable("YoutubeThumbnailDetails");
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.VideoYoutube", b =>
                {
                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.ResourceVideoYoutube", "ResourceVideoYoutube")
                        .WithMany()
                        .HasForeignKey("ResourceVideoYoutubeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeSearchResultSnippet", "YoutubeSearchResultSnippet")
                        .WithMany()
                        .HasForeignKey("YoutubeSearchResultSnippetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.YoutubeSearchResultSnippet", b =>
                {
                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnailDetails", "YoutubeThumbnailDetails")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnailDetails", b =>
                {
                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", "YoutubeThumbnailDefault")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailDefaultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", "YoutubeThumbnailHigh")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailHighId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", "YoutubeThumbnailMaxres")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailMaxresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", "YoutubeThumbnailMedium")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailMediumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioManipulaeHealth.Domain.Entities.YoutubeThumbnail", "YoutubeThumbnailStandard")
                        .WithMany()
                        .HasForeignKey("YoutubeThumbnailStandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}