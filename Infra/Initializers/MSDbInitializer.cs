namespace Music_School_DB.Infra.Initializers
{
    public static class MSDbInitializer
    {
        public static void Init(MSDb? db)
        {
            new InstructorsInitializer(db).Init();
            new InstrumentsInitializer(db).Init();
            new StudentsInitializer(db).Init();
            new CountriesInitalizer(db).Init();
            new CurrenciesInitalizer(db).Init();
            new CountryCurrenciesInitalizer(db).Init();
        }
    }
}
