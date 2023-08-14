﻿using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class Writer : IEntity
{
    [Key]
    public int WriterID { get; set; }
    public string WriterName { get; set; }
    public string WriterAbout { get; set; }
    public string WriterImage { get; set; }
    public string WriterMail { get; set; }
    public string WriterPassword { get; set; }
    public string WriterStatus { get; set; }
}