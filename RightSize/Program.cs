﻿using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
          foreach (string arg in args)
            {
                if (arg.Length > 6)
                {
                    return;
                }

            }
        }
    }
}
