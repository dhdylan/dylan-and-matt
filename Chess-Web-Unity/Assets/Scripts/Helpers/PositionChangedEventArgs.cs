using Assets.Scripts.GameComponents.Piece;
using System;

namespace Assets.Scripts.Helpers
{
    /// <summary>
    /// Event args when the position of the piece has changed
    /// </summary>
    public class PositionChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Piece whose position changed
        /// </summary>
        public Piece Piece { get; set; }

        /// <summary>
        /// New position of the piece
        /// </summary>
        public string NewPosition { get; set; }

        /// <summary>
        /// Previous position of the piece
        /// </summary>
        public string PreviousPosition { get; set; }
    }
}