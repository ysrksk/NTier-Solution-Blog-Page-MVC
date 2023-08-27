﻿using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class Comment : IEntity
{
    [Key]
    public int CommentId { get; set; }
    public string CommentUserName { get; set; }
    public string CommentTitle { get; set; }
    public string CommentContent { get; set; }
    public DateTime CommentDate { get; set; }
    public int BlogScore { get; set; }
    public bool CommentStatus { get; set; }
    public int BlogId { get; set; }

    public Blog Blog { get; set; }
}
