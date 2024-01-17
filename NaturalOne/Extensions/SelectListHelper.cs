using NaturalOne.Models;

namespace NaturalOne
{
    public static class SelectListHelper
    {
        public static IList<SelectListItem> ToSelectList<TEnum>(TEnum? except = null)
            where TEnum : struct
        {
            var list = new List<SelectListItem>();

            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                if (except is not null && except.Value.Equals(value))
                    continue;

                list.Add(new SelectListItem
                {
                    Text = value.GetLocalizedEnum(),
                    Value = Convert.ToInt32(value).ToString()
                });
            }

            return list;
        }
    }
}