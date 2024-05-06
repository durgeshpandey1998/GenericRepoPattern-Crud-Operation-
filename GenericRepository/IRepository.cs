namespace GenericRepoPattern.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
       void Insert(T obj);
        void Delete(T Id);
        T Update(T obj);
        void Save();
    }
}
