﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheArtOfExtensions.Classes
{
    public static class EnumerableExtensiosn
    {
        public static void Upsert<T>(this List<T> target, T upsertee, Predicate<T> equals)
        {
            var idx = target.FindIndex(equals);
            if (idx == -1)
            {
                target.Add(upsertee);
            }
            else
            {
                target[idx] = upsertee;
            }
        } 
    }
}
