using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyankenGame.usecase
{
    class ResultDecideService
    {
        private static int RATE = 100;
        public Boolean ServiceWinGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, RATE);
            if (num == 1) return false;
            return true;
        }
    }
}
