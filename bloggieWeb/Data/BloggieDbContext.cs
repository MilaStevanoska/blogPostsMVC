﻿using bloggieWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace bloggieWeb.Data
{
    public class BloggieDbContext : DbContext
        {
            public BloggieDbContext(DbContextOptions<BloggieDbContext> options) : base(options)
            {
            }
            public DbSet<BlogPost> BlogPosts { get; set; }
            public DbSet<Tag> Tags { get; set; }
            public DbSet<BlogPostLike> BlogPostLike { get; set; }
            public DbSet<BlogPostComment> BlogPostComment { get; set; }
        }
    }

