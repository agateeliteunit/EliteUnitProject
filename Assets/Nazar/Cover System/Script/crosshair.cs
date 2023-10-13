using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    public Texture2D customCursor;
    public float jarakTembak = 100f;
    public LayerMask enemyLayer;
    public Camera FPSCamera;

    void OnEnable()
    {
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnDisable()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    void Update()
    {
        Ray ray = FPSCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit, jarakTembak, enemyLayer))
            {
                    Debug.Log("Musuh Terkena!");
            }
        }
    }
}
