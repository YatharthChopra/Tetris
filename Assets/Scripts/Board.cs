using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public TetronimoData[] tetronimos;
    public Piece activePiece;
    public Tilemap tilemap;

    private void Start()
    {
        SpawnPiece();
    }

    void SpawnPiece()
    {
        activePiece.Initialize(this, Tetronimo.T);
        Set(activePiece);
    }

    // Set color's the tiles for the piece
    public void Set(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int cellPosition = (Vector3Int)(piece.cells[i] + piece.position);
            tilemap.SetTile(cellPosition, piece.data.tile);
        }
    }

    public void Clear(Piece piece)
    {
        for (int i = 0; i < piece.cells.Length; i++)
        {
            Vector3Int cellPosition = (Vector3Int)(piece.cells[i] + piece.position);
            tilemap.SetTile(cellPosition, piece.data.tile);
        }
    }
}
