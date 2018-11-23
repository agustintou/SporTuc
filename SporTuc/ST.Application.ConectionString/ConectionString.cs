namespace ST.Application.ConectionString
{
    public static class ConectionString
    {
        const string BaseDatos = "SporTuc2018";
        const string Servidor = @"DESKTOP-IS9FM4M\SQLTOUCEDA";

        public static string Get => $"Data Source = {Servidor}; " +
            $"Initial Catalog = {BaseDatos};" +
            $"Integrated Security = true;";
    }
}
