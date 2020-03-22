using System.Configuration;

namespace Sample.Domain
{
    
    /// <summary>
    /// アプリケーション全体から参照する設定を格納
    /// </summary>
    public static class Shared
    {
        public static bool IsFake { get; } = 
            ConfigurationManager.AppSettings["IsFake"] == "1";
    }
}
