using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class CommentManager : ICommentService
{

    ICommentDal _commentDal;
    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public void AddComment(Comment comment)
    {
        _commentDal.Add(comment);
    }

    public void DeleteComment(Comment comment)
    {
        _commentDal.Delete(comment);
    }

    public Comment GetCommentById(int id)
    {
        var comment = _commentDal.Get(x => x.CommentId == id);
        return comment;
    }

    public List<Comment> GetAll(int id)
    {
        return _commentDal.GetAll(x => x.BlogId == id);
    }

    public void UpdateComment(Comment comment)
    {
        _commentDal.Update(comment);
    }

    public List<Comment> GetAllComment()
    {
        return _commentDal.GetAll();
    }
}
