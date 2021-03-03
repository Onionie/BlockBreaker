using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]int breakableBlocks;

    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakbleblocks()
    {
        breakableBlocks++;
    }

    public void BlocksDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }


}
