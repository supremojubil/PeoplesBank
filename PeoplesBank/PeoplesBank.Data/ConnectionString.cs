
namespace PeoplesBank.Data {
    public partial class ConnectionString {
        public static string ENTITY_CONNECTION_STRING =>
            $"server=localhost;" +
            $"port=3309;" +
            $"database=peoplesbank;" +
            $"uid=adminserver;" +
            $"pwd=admin123!@#;" +
            $"SSLMode=None;";
    }
}
