using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeScrolling : MonoBehaviour
{
    public float edgeScrollSpeed = 15.0f;
    public float scrollArea = 10.0f;
    private Vector3 rotasiAwal;
    private Vector3 rotasi;
    private Vector3 mousePosition;
    
    public Camera playerCamera;

    void OnEnable()
    {
        rotasiAwal = playerCamera.transform.eulerAngles;
    }

    void OnDisable()
    {
        playerCamera.transform.eulerAngles = rotasiAwal;
    }

    void Update()
    {
        rotasi = playerCamera.transform.eulerAngles;
        mousePosition = Input.mousePosition;

        if (mousePosition.x < scrollArea)
        {
            rotasi.y -= edgeScrollSpeed * Time.deltaTime;
        }
        else if (mousePosition.x > Screen.width - scrollArea)
        {
            rotasi.y += edgeScrollSpeed * Time.deltaTime;
        }

        if (mousePosition.y < scrollArea)
        {
            rotasi.x += edgeScrollSpeed * Time.deltaTime;
        }
        else if (mousePosition.y > Screen.height - scrollArea)
        {
            rotasi.x -= edgeScrollSpeed * Time.deltaTime;
        }

        playerCamera.transform.eulerAngles = rotasi;
    }
}
