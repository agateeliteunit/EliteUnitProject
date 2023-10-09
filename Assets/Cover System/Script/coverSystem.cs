using System.Collections;
using UnityEngine;
using System.Threading.Tasks;
using Opsive.Shared.Input;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Character.Abilities.Items;
using Opsive.UltimateCharacterController.Game;
using Opsive.Shared.Input.VirtualControls;

public class coverSystem : MonoBehaviour
{
    public Camera tpsCamera;
    public Camera fpsCamera;
    private bool FPS;
    private bool teleporting;
    private Transform targetTeleport;
    private UltimateCharacterLocomotion characterController;
    private UltimateCharacterLocomotionHandler characterInput;
    private FPSMovement fpsMovement;
    private bool Scanning;
    private UnityInput unityInput;

    void Start()
    {
        tpsCamera.enabled = true;
        fpsCamera.enabled = false;
        characterController = GetComponent<UltimateCharacterLocomotion>();
        characterInput = GetComponent<UltimateCharacterLocomotionHandler>();
        fpsMovement = GetComponent<FPSMovement>();
        fpsMovement.enabled = false;
        unityInput = GetComponent<UnityInput>();
    }

    void Update()
    {
        if (!teleporting)
        {
            Vector3 playerCenter = transform.position;
            Vector3 boxSize = Vector3.one * 2f;
            Collider[] colliders = Physics.OverlapBox(playerCenter, boxSize);

            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag("posisiCover"))
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        FPSMode();
                    }
                }
            }
        }
    }

    async void FPSMode()
    {
        FPS = !FPS;
        tpsCamera.enabled = !FPS;
        fpsCamera.enabled = FPS;

        if (FPS)
        {
            targetTeleport = ScanPosisiCover();
            await Teleport(targetTeleport.position);
            if (FPS && !Scanning)
            {
                Scanning = true;
                await ScanWall();
            }
            unityInput.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            unityInput.enabled = true;
            characterController.enabled = true;
            characterInput.enabled = true;
            fpsMovement.enabled = false;
        }
    }

    Transform ScanPosisiCover()
    {
        foreach (var collider in Physics.OverlapBox(transform.position, Vector3.one * 2f))
        {
            if (collider.CompareTag("posisiCover"))
            {
                return collider.transform;
            }
        }
        return null;
    }

    async Task Teleport(Vector3 destination)
    {
        characterController.enabled = false;
        characterInput.enabled = false;
        transform.position = destination;
        await Task.Delay(100);
        teleporting = false;
    }

    async Task ScanWall()
    {
        while (Scanning)
        {
            fpsCamera.enabled = false;
            transform.Rotate(Vector3.up, 200f * Time.deltaTime);
            Ray ray = new Ray(transform.position + Vector3.up, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1f) && hit.collider.CompareTag("Wall"))
            {
                Scanning = false;
                fpsCamera.enabled = true;
                fpsMovement.enabled = true;
                break;
            }

            await Task.Yield();
        }
    }
}
