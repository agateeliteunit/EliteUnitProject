using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float maxMove = 1.0f;
    private Vector3 posisiAwal;
    private bool moving = false;
    private float posisiSekarang = 0.0f;

    void OnEnable()
    {
        posisiAwal = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (posisiSekarang < maxMove)
            {
                Vector3 playerCenter = transform.position;
                Vector3 boxSize = Vector3.one * 2f;
                Collider[] colliders = Physics.OverlapBox(playerCenter, boxSize);

                foreach (Collider collider in colliders)
                {
                    if (collider.gameObject.layer == LayerMask.NameToLayer("coverKanan"))
                    {
                        transform.Translate(new Vector3(1.3f, 0, 0) * moveSpeed * Time.deltaTime);
                        posisiSekarang += moveSpeed * Time.deltaTime;
                        moving = true;
                    }
                    else if (collider.gameObject.layer == LayerMask.NameToLayer("coverKiri"))
                    {
                        transform.Translate(new Vector3(-1.3f, 0, 0) * moveSpeed * Time.deltaTime);
                        posisiSekarang += moveSpeed * Time.deltaTime;
                        moving = true;
                    }
                    else if (collider.gameObject.layer == LayerMask.NameToLayer("coverAtas"))
                    {
                        transform.Translate(new Vector3(0, 0.3f, 0) * moveSpeed * Time.deltaTime);
                        posisiSekarang += moveSpeed * Time.deltaTime;
                        moving = true;
                    }
                }
            }
        }
        else if (moving)
        {
            moving = false;
        }

        if (!moving && posisiSekarang > 0.0f)
        {
            float kembali = Vector3.Distance(transform.position, posisiAwal);

            if (kembali > 0.01f)
            {
                float step = moveSpeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, posisiAwal, step);
            }
            else
            {
                posisiSekarang = 0.0f;
            }
        }
    }
}
