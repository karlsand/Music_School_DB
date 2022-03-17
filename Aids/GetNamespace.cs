namespace Music_School_DB.Aids
{
    public static class GetNamespace
    {
        public static string? OfType(object obj) => Safe.Run(() => obj.GetType().Namespace, string.Empty);
    }
}
