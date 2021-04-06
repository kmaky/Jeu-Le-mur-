using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{

    public GameObject brick;
     
    // Start is called before the first frame update
    void Start()
    {
        BuildWall();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            RemoveTheWall();
            BuildWall();
        }
    }

    void BuildWall() 
    {
        for (int h = 0; h < 30; h++)
        {
            for (int i = 0; i < 40; i++)
            {
                Instantiate(brick, new Vector3(i * 0.5F, h * 0.2f, 0.1f), Quaternion.identity);
            }
        }
    }

    void RemoveTheWall() 
    {
        
    }
}
