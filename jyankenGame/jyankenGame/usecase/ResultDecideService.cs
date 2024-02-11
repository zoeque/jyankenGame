using jyankenGame.domain;
using System.Configuration;

namespace jyankenGame.usecase
{
    class ResultDecideService
    {
        private static int RATE = int.Parse(ConfigurationManager.AppSettings["Rate"]);

        public ResultModel GetResultOfService()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, RATE);
            if (num == 1)
            {
                return ResultModel.LOSE;
            }
            if (num % 2 == 1)
            {
                return ResultModel.DRAW;
            }
            return ResultModel.WIN;
        }
    }
}
