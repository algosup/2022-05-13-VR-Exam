using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Piece currentPiece;

    void Update()
    {
        if (currentPiece && currentPiece.canMove())
        {
            // Move it with arrow keys
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                currentPiece.MoveLeft();

            if (Input.GetKeyDown(KeyCode.RightArrow))
                currentPiece.MoveRight();

            
        }
    }
}
