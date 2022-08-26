using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuboo : MonoBehaviour
{
    public int alto;
    public int ancho;
    public Tile[,] board;
    public GameObject perfile;
    public Camera cameraPlayer;
    void CreateBoard()
    {
        board = new Tile[ancho, alto];

        for (int i= 0; i < alto; i++)
        {
            for (int j = 0; j <ancho; j++)
            {
                GameObject go = Instantiate(perfile);
                go.name = "Tile("+i+", "+j+")";
                go.transform.position = new Vector3(i, j, 0);
                Tile tile = go.GetComponent<Tile>();
                tile.inicialization(i, j);
                board[i, j] = tile;

                cameraPlayer.transform.localPosition = new Vector3(i / 2, j / 2, -1);
                cameraPlayer.orthographicSize = (float)alto / 2;

            }
        }
    }

   


}


