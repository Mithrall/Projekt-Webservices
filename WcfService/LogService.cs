using System.Linq;

namespace WcfService {
    public class LogService:ILogService {
        
        //Adds the string (sent from client) to the list in repository
        public void LogFil(string s) {
            Repo.logListe.Add(s);
        }

        //Gets the last string in the list from the repository and returns it to the client.
        public string GetLast() {
            return Repo.logListe.Last();
        }
    }
}