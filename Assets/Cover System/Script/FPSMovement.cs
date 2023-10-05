using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Kecepatan pergerakan karakter FPS
    public float maxDistance = 1.0f; // Jarak maksimum yang dapat ditempuh saat tombol spasi ditekan

    private Vector3 initialPosition;
    private bool isMoving = false;
    private float currentDistance = 0.0f;

    void OnEnable()
    {
        // Ketika skrip diaktifkan, set initialPosition ke posisi saat ini
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Memeriksa apakah pemain mencapai jarak maksimum
            if (currentDistance < maxDistance)
            {
                Vector3 moveDirection = new Vector3(1.3f, 0, 0);

                // Menggunakan Transform untuk menggerakkan karakter
                transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

                // Menambah jarak yang sudah ditempuh
                currentDistance += moveSpeed * Time.deltaTime;
                isMoving = true;
            }
        }
        else if (isMoving)
        {
            // Jika tombol spasi dilepas dan pemain sedang bergerak, hentikan pergerakan
            isMoving = false;
        }

        // Jika pemain tidak sedang bergerak dan belum mencapai jarak maksimum,
        // pergerakannya akan mundur ke posisi awal
        if (!isMoving && currentDistance > 0.0f)
        {
            float distanceToInitial = Vector3.Distance(transform.position, initialPosition);
            
            if (distanceToInitial > 0.01f)
            {
                // Menggerakkan pemain ke posisi awal
                float step = moveSpeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, initialPosition, step);
            }
            else
            {
                // Menghentikan pergerakan setelah mencapai posisi awal
                currentDistance = 0.0f;
            }
        }
    }
}
