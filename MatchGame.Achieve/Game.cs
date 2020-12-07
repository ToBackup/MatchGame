using MatchGame.Factory;
using MatchGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchGame.Achieve
{
    class Game : IGame
    {
        private Player[] _players;
        private int[] _count;
        private int max;
        public Game(int[] count)
        {
            _count = count;
            foreach (int item in count)
            {
                max += item;
            }
        }

        public virtual void JoinPlayer(Player[] players)
        {
            _players = players;
            foreach (Player player in _players)
            {
                player.Extract += Player_ExtractEvent;
            }
        }

        public Player Start()
        {
            Player current = null;

            int index = 0;
            while(!IsEnd())
            {
                current = _players[index];
                var ic = current.Get();
            }


            return current;
        }
        protected virtual bool IsEnd()
        {
            bool isEnd = false;


            return isEnd;
        }

        private void Player_ExtractEvent(int index, int count)
        {
            max -= count;
            _count[index] -= count;
        }

        //public void Start()
        //{
        //    int index = 0;
        //    while(End())
        //    {
        //        Player currentPlayer = _players[index];
        //        var r = currentPlayer.Get?.Invoke();
        //        if(r!=null)
        //            currentPlayer.Extract?.Invoke(r.Value.Index, r.Value.Count);


        //        index = index++ >= _players.Length ? 0 : index;
        //    }
        //}
    }
}
