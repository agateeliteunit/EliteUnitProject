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

    private bool isFPS;
    private bool isPlayerTeleporting;
    private Transform teleportDestination;
    private UltimateCharacterLocomotion characterController;
    private FPSMovement fpsMovement;
    private bool isScanning;
    private UnityInput unityInput;

    void Start()
    {
        tpsCamera.enabled = true;
        fpsCamera.enabled = false;
        characterController = GetComponent<UltimateCharacterLocomotion>();
        fpsMovement = GetComponent<FPSMovement>();
        fpsMovement.enabled = false;
        unityInput = GetComponent<UnityInput>();
    }

    void Update()
    {
        if (!isPlayerTeleporting)
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
                        ToggleFPSMode();
                    }
                }
            }
        }
    }

    async void ToggleFPSMode()
    {
        isFPS = !isFPS;
        tpsCamera.enabled = !isFPS;
        fpsCamera.enabled = isFPS;

        if (isFPS)
        {
            teleportDestination = FindCoverPosition();
            await TeleportPlayer(teleportDestination.position);
            if (isFPS && !isScanning)
            {
                isScanning = true;
                await ScanForWallsAsync();
            }
            unityInput.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            unityInput.enabled = true;
            characterController.enabled = true;
            fpsMovement.enabled = false;
        }
    }

    Transform FindCoverPosition()
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

    async Task TeleportPlayer(Vector3 destination)
    {
        characterController.enabled = false;
        transform.position = destination;
        await Task.Delay(100);
        isPlayerTeleporting = false;
    }

    async Task ScanForWallsAsync()
    {
        while (isScanning)
        {
            fpsCamera.enabled = false;
            transform.Rotate(Vector3.up, 200f * Time.deltaTime);
            Ray ray = new Ray(transform.position + Vector3.up, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1f) && hit.collider.CompareTag("Wall"))
            {
                isScanning = false;
                fpsCamera.enabled = true;
                fpsMovement.enabled = true;
                break;
            }

            await Task.Yield();
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position + Vector3.up, transform.forward * 2f);
    }
}
