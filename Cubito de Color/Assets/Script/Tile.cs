using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int indicex;
    public int indicey;


    public  void inicialization (int x, int y)
    {
        indicex = x;
        indicey = y;
    }
}
