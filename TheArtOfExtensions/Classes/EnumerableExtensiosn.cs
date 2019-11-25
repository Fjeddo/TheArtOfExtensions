using System;
using System.Collections.Generic;

namespace TheArtOfExtensions.Classes
{
    public static class EnumerableExtensiosn
    {
        public static void Upsert<T>(this List<T> target, T upsertee, Predicate<T> equals)
        {
            if(target.TryFindIndex(equals, out var idx))
            {
                target[idx] = upsertee;
            }
            else
            {
                target.Add(upsertee);
            }
        }

        public static bool TryFindIndex<T>(this List<T> target, Predicate<T> equals, out int idx)
        {
            idx = target.FindIndex(equals);

            return idx != -1;
        }
    }
}
