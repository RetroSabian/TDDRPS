using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class RPS
    {
           public RPS()
        {
        }

        public int play(char p1, char p2)
        {
            int result = -1;
            if(p1 == 'R' && p2 == 'R')
            {
                result = 0;
            }
            if (p1 == 'R' && p2=='P' )
            {
                result = 2;
            }
            if (p1 == 'R' && p2 == 'S')
            {
                result = 1;
            }
            if (p1 == 'P' && p2 == 'P')
            {
                result = 0;
            }
            if (p1 == 'P' && p2 == 'R')
            {
                result = 1;
            }
            if (p1 == 'P' && p2 == 'S')
            {
                result = 2;
            }
            if (p1 == 'S' && p2 == 'S')
            {
                result = 0;
            }
            if (p1 == 'S' && p2 == 'R')
            {
                result = 2;
            }
            if (p1 == 'S' && p2 == 'P')
            {
                result = 1;
            }
            if (p1 == 'R' && p2 == 'X')
            {
                result = 2;

            }
            if (p1 == 'P' && p2 == 'X')
            {
                result = 1;
            }
            if (p1 == 'S' && p2 == 'X')
            {
                result = 2;
            }
            if (p1 == 'X' && p2 == 'R')
            {
                result = 1;
            }
            if (p1 == 'X' && p2 == 'P')
            {
                result = 2;
            }
            if (p1 == 'X' && p2 == 'S')
            {
                result = 1;
            }
            return result;
        }
    }
}
