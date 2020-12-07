using MatchGame.Factory;
using MatchGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchGame.Achieve
{
    class Game : IGame
    {
        private LinkedList<Player> _players = new LinkedList<Player>();
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

        public void JoinPlayer(Player player)
        {
            player.Extract += Player_ExtractEvent;
            _players.AddLast(player);
        }

        private void Player_ExtractEvent(int index, int count)
        {
            max -= count;
            _count[index] -= count;
        }

        public void Start()
        {
            LinkedListNode<Player> currentNode = _players.First;
            while(max>0)
            {
                Player currentPlayer = currentNode.Value;
                var r = currentPlayer.Get?.Invoke();
                if(r!=null)
                    currentPlayer.Extract?.Invoke(r.Value.Index, r.Value.Count);


                currentNode = currentNode.Next ?? _players.First;
            }
        }

    }
}
