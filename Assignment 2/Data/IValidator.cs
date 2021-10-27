namespace Assignment_2.Data
{
    public interface IValidator
    {
        public void Set(bool authorize);
        public bool GetAuthorization();
    }
}