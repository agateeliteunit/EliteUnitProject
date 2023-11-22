using System.Collections;
using UnityEngine;
using System.Threading.Tasks;
using Opsive.Shared.Input;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Character.Abilities;
using Opsive.UltimateCharacterController.Character.Abilities.Items;
using Opsive.UltimateCharacterController.Game;
using Opsive.Shared.Input.VirtualControls;

public class tes : MonoBehaviour
{
    private UltimateCharacterLocomotion characterController;
    private UltimateCharacterLocomotionHandler characterInput;
    private UnityInput unityInput;
    private FPSMovement fpsMovement;
    private coverController controller;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<UltimateCharacterLocomotion>();
        characterInput = GetComponent<UltimateCharacterLocomotionHandler>();
        unityInput = GetComponent<UnityInput>();
        fpsMovement = GetComponent<FPSMovement>();
        controller = GetComponent<coverController>();
    }

    void OnDisable()
    {
        characterController.enabled = false;
        characterInput.enabled = false;
        unityInput.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            characterController.enabled = false;
            characterInput.enabled = false;
            unityInput.enabled = false;
        }
        else
        {
            characterController.enabled = true;
            characterInput.enabled = true;
            unityInput.enabled = true;
        }
        characterController.enabled = true;
        characterInput.enabled = true;
        unityInput.enabled = true;
    }
}
