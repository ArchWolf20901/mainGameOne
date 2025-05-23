using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public Vector3 cameraChangePos;
    public Vector3 playerChangePos;
    private Camera cam;
    
    // Вызываем объект Камера

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
    }

    // Если какой либо объект касается триггера, то он перемещается вместе с камеой на указанное колличество клеток

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position += playerChangePos;
            cam.transform.position += cameraChangePos;
        }
    }

}
