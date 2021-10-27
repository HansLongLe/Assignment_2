namespace Assignment_2_Server.Logic
{
    public interface IVerifier
    {
        public bool Authorize(string username, string password);
    }
}