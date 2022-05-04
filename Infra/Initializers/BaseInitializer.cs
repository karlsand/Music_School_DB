﻿using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;

namespace Music_School_DB.Infra.Initializers
{
    public abstract class BaseInitializer<TData> where TData : UniqueData
    {
        internal protected DbContext? db;
        internal protected DbSet<TData>? set;
        protected BaseInitializer(DbContext? c, DbSet<TData>? s)
        {
            db = c;
            set = s;
        }
        public void Init()
        {
            if (set?.Any() ?? true) return;
            set.AddRange(getEntities);
            db?.SaveChanges();
        }
        protected abstract IEnumerable<TData> getEntities { get; }
        internal static bool isCorrectIsoCode(string id) => !string.IsNullOrWhiteSpace(id) && char.IsLetter(id[0]);
    }
    public static class MSDbInitializer
    {
        public static void Init(MSDb? db)
        {
            new InstructorInitializer(db).Init();
            new InstrumentInitializer(db).Init();
            new StudentInitializer(db).Init();
            new CountryInitalizer(db).Init();
            new CurrencyInitalizer(db).Init();
        }
    }
}
