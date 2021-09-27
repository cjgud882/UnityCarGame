using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameMode : MonoBehaviour
{
    public GameObject Menu;

    //Cursor Stuff
    public Texture2D menuCursor;
    public Texture2D gameCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    private void Update()
    {
        if (Menu.active == true)
        {
            Cursor.SetCursor(menuCursor, hotSpot, cursorMode);
        } else
        {
            Cursor.SetCursor(gameCursor, hotSpot, cursorMode);


        }


    }







}
