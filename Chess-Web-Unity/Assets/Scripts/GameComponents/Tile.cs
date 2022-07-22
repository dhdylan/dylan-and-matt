using Assets.Scripts.GameComponents.Piece;
/// <summary>
/// Class for all tiles on the chess board
/// </summary>
public class Tile
{
    private readonly string _location;

    /// <summary>
    /// Tile constructor
    /// </summary>
    public Tile(string location)
    {
        _location = location;
    }

    /// <summary>
    /// Location of the tile on the board
    /// </summary>
    public string Location => _location;

    /// <summary>
    /// Piece on the tile; null if tile is open
    /// </summary>
    public Piece OccupyingPiece { get; set; }

    /// <summary>
    /// Checks if the tile is open
    /// </summary>
    /// <returns>True if occupied by a piece; false otherwise</returns>
    public bool IsOccupied()
    {
        return OccupyingPiece != null;
    }
}