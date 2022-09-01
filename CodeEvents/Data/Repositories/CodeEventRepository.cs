namespace CodeEvents.Api.Data.Repositories
{
    public class CodeEventRepository
    {
        private CodeEventsApiContext db;

        public CodeEventRepository(CodeEventsApiContext db)
        {
            this.db = db;

        }
    }
}
