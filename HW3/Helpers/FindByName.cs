using HW3.Models;

namespace HW3.Helpers
{
    public static class FindByName
    {
        public static Sweetness FindBName(this Sweetness[] present, string name)
        {
            foreach (var item in present)
            {
                if (item.Name == name)
                {
                    item.Name = name;
                    return item;
                }
            }

            return null;
        }
    }
}
