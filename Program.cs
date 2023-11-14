using System.Reflection;

namespace CalcSubnet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }

        public static string ExibirVersao()
        {
            string versao = Assembly.GetEntryAssembly()!.GetName().Version!.ToString();
            string nomeVersao = $"CalcSubnet v{versao} (beta)";
            return nomeVersao;
        }
    }
}