using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakbleblocks();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyedBlock();
    }

    private void DestroyedBlock()
    {
        FindObjectOfType<GameStatus>().AddScore();
        Destroy(gameObject, 0f);
        level.BlocksDestroyed();
    }


}
