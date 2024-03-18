namespace Infrastructures.Inrerfaces;

public interface IUnitOfWork
{
    IAuthorInterface authorInterface { get; }
    IBookInterface bookInterface { get; }
    IJanrInterface janrInterface { get; }
}
