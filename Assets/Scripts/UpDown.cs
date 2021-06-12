using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float speed = 1;

    private bool goUp = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 1 && goUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);    
        } else if (transform.position.y > 0.2f && !goUp)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        else
        {
            goUp = !goUp;
        }

        
    }
}
