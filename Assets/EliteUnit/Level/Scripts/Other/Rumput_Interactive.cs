using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rumput_Interactive : MonoBehaviour
{
    public CapsuleCollider capsuleCollider; // Menambahkan variabel capsuleCollider

    void Start()
    {
        // Mendapatkan komponen CapsuleCollider dari objek ini
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
            Shader.SetGlobalVector("_Player", transform.position + Vector3.up * capsuleCollider.radius);
    }
}
