using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface ICommentService
{
    void AddComment(Comment comment);
    void UpdateComment(Comment comment);
    void DeleteComment(Comment comment);
    Comment GetCommentById(int id);
    List<Comment> GetAllComment();
    List<Comment> GetAll(int id);
}
