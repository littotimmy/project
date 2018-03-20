using UnityEngine;

using System.Collections;

public class spin : MonoBehaviour
{

    public float speed;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
