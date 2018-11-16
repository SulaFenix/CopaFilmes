using System;

namespace CopaFilmes.Helpers
{
    public class Guard
    {
        public static void ForNullOrEmptyDefaultMessage(string value, string propName)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(propName + " é obrigatório!");
        }

        public static void ForNullOrEmpty(string value, string errorMessage)
        {
            if (String.IsNullOrEmpty(value))
                throw new Exception(errorMessage);
        }

        public static void ForNullDefaultMessage(DateTime anoLancamento, string v)
        {
            if (anoLancamento == null)
                throw new Exception(v + " é obrigatório!");
        }
    }
}
