namespace BlobMyData.Domain.Model
{
    public interface IBaseModel<TKey>
    {
        TKey Id { get; }
    }
}
