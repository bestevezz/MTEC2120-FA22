using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiate : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        for (var i =0; i <10; i++)
        {
            Instantiate(prefab, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
