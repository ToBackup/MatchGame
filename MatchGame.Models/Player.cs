using System;
using System.Collections.Generic;
using System.Text;

namespace MatchGame.Models
{
    public delegate void ExtractDelegate(int index, int count);
    public delegate (int, int) GetDelegate();
    public class Player
    {
        public ExtractDelegate Extract;
        public GetDelegate Get;
    }

}
