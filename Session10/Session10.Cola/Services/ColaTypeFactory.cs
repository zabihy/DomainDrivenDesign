using Session10.ColaStoreProject.ValueObjects;

namespace Session10.ColaStoreProject.Services
{
    public static class ColaTypeFactory
    {
        public static ColaType GetColaType(string type)
        {
            var returnType = ColaType.None;

            if(type.ToLower()=="b" || type.ToLower()=="black")
            {
                returnType = ColaType.Black;
            }

            if (type.ToLower() == "o" || type.ToLower() == "orange")
            {
                returnType = ColaType.Black;
            }

            if (type == "B" || type == "b" || type == "Black" || type == "black")
            {
                returnType = ColaType.Black;
            }

            return returnType;
        }
    }
}
