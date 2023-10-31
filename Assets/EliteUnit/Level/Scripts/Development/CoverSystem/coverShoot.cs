using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coverShoot : MonoBehaviour
{
    public float jarakTembak = 100f;
    public LayerMask enemyLayer;
    public Camera FPSCamera;
    public Vector2 efekRecoil = new Vector2(0.1f, 0.1f);
    public float recoilSpeed = 2f;
    public float recoverySpeed = 2f;
    public float fireRate = 15f;
    public float waktuReload = 1f;
    public int maxAmmo = 10;
    public bool reloading = false;

    private int currentAmmo = -1;
    private Vector3 normalCamera;
    private Vector3 posisiCamera;
    private Vector2 awalRecoil = Vector2.zero; 
    private float nextFire = 0f;

    void Start()
    {
        normalCamera = FPSCamera.transform.localPosition;
        posisiCamera = FPSCamera.transform.localPosition;
        currentAmmo = maxAmmo;
    }

    void OnDisable()
    {
        FPSCamera.transform.localPosition = normalCamera;
    }

    void Update()
    {
        if (reloading)
        {
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(reload());
            return;
        }

        if (Input.GetButton("Fire1") && Time.time >= nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            recoil();
            shoot();
        }

        Vector2 currentRecoil = Vector2.Lerp(awalRecoil, Vector2.zero, Time.deltaTime * recoilSpeed);
        FPSCamera.transform.localPosition = posisiCamera + new Vector3(currentRecoil.x, currentRecoil.y, 0);
        awalRecoil = currentRecoil;
        FPSCamera.transform.localPosition = Vector3.Lerp(FPSCamera.transform.localPosition, posisiCamera, Time.deltaTime * recoverySpeed);
    }

    void recoil()
    {
        awalRecoil += new Vector2(Random.Range(-efekRecoil.x, efekRecoil.x), Random.Range(-efekRecoil.y, efekRecoil.y));
    }

    void shoot()
    {
        currentAmmo--;

        Ray ray = FPSCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, jarakTembak, enemyLayer))
        {
            Debug.Log("Musuh Terkena!");
        }
    }

    IEnumerator reload()
    {
        reloading = true;
        yield return new WaitForSeconds(waktuReload);
        currentAmmo = maxAmmo;
        reloading = false;
    }
}
