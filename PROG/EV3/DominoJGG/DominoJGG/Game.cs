using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoJGG
{
    public class Game
    {
        private List<Participant> _participants;
        private DominoDeck _amountOfDominoes;
        private Participant? _winner;

        public Game(List<Participant> participants, DominoDeck amountOfDominoes) 
        { 
            _participants = participants;
            _amountOfDominoes = amountOfDominoes;
        }
        public void StartGame()//
        {

        }
        public void SimulateGame()
        {
            _amountOfDominoes.Shuffle();
            foreach (Participant participant in _participants)
            {
                _amountOfDominoes.ExtractPiece();
            }
        }
    }
}
