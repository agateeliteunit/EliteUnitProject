using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.Shared.Events;
using Opsive.Shared.Game;
using Opsive.Shared.StateSystem;
using Opsive.Shared.Utility;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Inventory;

public class FPSMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float maxMove = 1.0f;
    public Animator anim;
    private Vector3 posisiAwal;
    private bool moving = false;
    private float posisiSekarang = 0.0f;
    public tes controller;
    public coverShoot shoot;

    void start()
    {
        controller = GetComponent<tes>();
        shoot = GetComponent<coverShoot>();
        shoot.enabled = false;
        controller.enabled = false;
    }

    void OnEnable()
    {
        controller.enabled = false;
        posisiAwal = transform.position;
    }

    void OnDisable()
    {
        controller.enabled = true;
        anim.SetBool("halfCover", false);
        shoot.enabled = false;
    }

    void Update()
    {
        Vector3 playerCenter = transform.position;
        Vector3 boxSize = Vector3.one * 2f;
        Collider[] colliders = Physics.OverlapBox(playerCenter, boxSize);

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.layer == LayerMask.NameToLayer("coverAtas"))
            {
                anim.SetBool("halfCover", true);
                if (Input.GetKey(KeyCode.Space))
                {
                    controller.enabled = true;
                    shoot.enabled = true;
                    anim.SetBool("halfCover", false);
                }
                else
                {
                    controller.enabled = false;
                    shoot.enabled = false;
                    anim.SetBool("halfCover", true);
                }
            }
            
            if (Input.GetKey(KeyCode.Space))
            {
                controller.enabled = true;
                shoot.enabled = true;
                if (posisiSekarang < maxMove)
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
                }
            }
            else if (moving)
            {
                moving = false;
                controller.enabled = false;
            }

            if (!moving && posisiSekarang > 0.0f)
            {
                controller.enabled = false;
                shoot.enabled = false;
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
}
