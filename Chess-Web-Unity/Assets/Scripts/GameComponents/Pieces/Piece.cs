using Assets.Scripts.Helpers;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.GameComponents.Piece
{
    /// <summary>
    /// Base class all chess pieces inherit from
    /// </summary>
    public abstract class Piece
    {
        private string _position;

        /// <summary>
        /// Piece constructor
        /// </summary>
        protected Piece()
        {
        }
        
        /// <summary>
        /// Board position of the piece
        /// </summary>
        public string Position => _position;

        /// <summary>
        /// List of valid moves the piece can make at a given tile
        /// </summary>
        public List<string> ValidMoves { get; protected set; }

        /// <summary>
        /// Event when the position of this piece has changed
        /// </summary>
        public event EventHandler<PositionChangedEventArgs> PositionChanged;

        /// <summary>
        /// Function inherited by each piece subclass that updates its list of possible moves
        /// </summary>
        public abstract List<string> UpdateValidMoves();

        /// <summary>
        /// Moves the chess piece to a tile position if it is a valid move
        /// </summary>
        /// <param name="position">Tile position</param>
        public void MoveToPosition(string position)
        {
            if(ValidMoves.Contains(position))
            {
                string prevPosition = _position;

                _position = position;

                PositionChanged?.Invoke(this, new PositionChangedEventArgs() { NewPosition = _position, PreviousPosition = prevPosition, Piece = this });
            }
        }
    }
}
