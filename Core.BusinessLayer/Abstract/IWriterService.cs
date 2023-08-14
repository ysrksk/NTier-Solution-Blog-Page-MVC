﻿using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface IWriterService
{
    void AddWriter(Writer writer);
    void UpdateWriter(Writer writer);
    void DeleteWriter(Writer writer);
    Writer GetWriterById(int id);
    List<Writer> GetAllWriter();
}
