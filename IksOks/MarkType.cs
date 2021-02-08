﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IksOks
{
    /// <summary>
    /// The type of value a cell in the game is currently at
    /// </summary>
    public enum MarkType
    {
        /// <summary>
        ///  The cell hasn't been clicked yet
        /// </summary>
        Free,
        /// <summary>
        /// The cell is a 0
        /// </summary>
        Nought,
        /// <summary>
        /// The cell is an X
        /// </summary>
        Cross
    }
}
