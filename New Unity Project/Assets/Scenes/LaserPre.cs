using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPre : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    // Update is called once per frame
    void Update()
    {
        //translate laser up 
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        //if laser is >= 8 on y, destroy object
        if (transform.position.y >= 8f)
        {
            Destroy(this.gameObject);
        }
    }
}
