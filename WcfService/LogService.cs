using System.Linq;

namespace WcfService {
    public class LogService:ILogService {
        
        public void LogFil(string s) {
            Repo.logListe.Add(s);
        }

        public string GetLast() {
            return Repo.logListe.Last();
        }
    }
}