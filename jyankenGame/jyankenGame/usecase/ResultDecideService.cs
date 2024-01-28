namespace jyankenGame.usecase
{
    class ResultDecideService
    {
        private static int RATE = 30;
        public Boolean ServiceWinGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, RATE);
            if (num == 1) return false;
            return true;
        }
    }
}
