using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.0f, 0.0f, -0.0150f));
        transform.Rotate(new Vector3(0.0f, 0.0f, 0.1f));
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}
