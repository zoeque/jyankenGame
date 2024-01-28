using System.Configuration;

namespace jyankenGame.usecase
{
    class ResultDecideService
    {
        private static int RATE = int.Parse(ConfigurationManager.AppSettings["Rate"]);

        public Boolean ServiceWinGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, RATE);
            if (num == 1) return false;
            return true;
        }
    }
}
