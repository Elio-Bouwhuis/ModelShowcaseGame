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
        transform.position += (new Vector3(0.0f, 0.0f, -10f) * Time.deltaTime);
        transform.Rotate(new Vector3(0.0f, 0.0f, 0.1f) * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}
