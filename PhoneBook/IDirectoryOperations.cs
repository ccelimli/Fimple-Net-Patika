namespace PhoneBook
{
    public interface IDirectoryOperations
    {
        public void Add();
        public void Delete();
        public void Update();
        public void GetAll();
        public void GetByNameOrSurname();
    }
}