using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float xHorizontal = Input.GetAxis("Horizontal");
        float zVertical = Input.GetAxis("Vertical");
        Vector3 movesystem = new Vector3(xHorizontal, 0.0f, zVertical);
        transform.position += movesystem * speed * Time.deltaTime;
    }
}
