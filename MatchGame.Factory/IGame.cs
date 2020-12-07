using MatchGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchGame.Factory
{
    public interface IGame
    {
        /// <summary>
        /// 游戏开始
        /// </summary>
        /// <returns>输家</returns>
        Player Start();
        /// <summary>
        /// 加入玩家
        /// </summary>
        /// <param name="player">玩家</param>
        void JoinPlayer(Player[] players);
    }
}
