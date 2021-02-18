using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp
{
    class ScoreManager
    {
        public int Score { get; private set; }
        public int HighScore { get; private set; }
        private readonly string file;

        public ScoreManager(string file) 
        {
            this.file = file;
            this.HighScore = ReadFileScore();
        }

        private int ReadFileScore()
        {
            //  TODO: Add reading highscore from file
            throw new NotImplementedException();
        }

        public void AddScore(int score)
        {
            //  TODO: Implement a good score system
            this.Score += score;
        }

    }
}
