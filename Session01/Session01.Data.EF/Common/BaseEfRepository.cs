namespace Session01.Data.EF.Common
{
    public class BaseEfRepository
    {
        protected Session01DbContext _ctx;
        public BaseEfRepository(Session01DbContext ctx)
        {
            _ctx = ctx;
        }
    }
}
