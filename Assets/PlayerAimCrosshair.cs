using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimCrosshair : MonoBehaviour
{
    private Vector2 mousePos;

    [SerializeField] Camera camera;
    [SerializeField] private GameObject thing1;
    public Ray AimRay { private set; get; }

    private void Update()
    {
        mousePos = Input.mousePosition;
        thing1.transform.position = mousePos;
        Ray AimRay = camera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        //Physics.Raycast(camRay, out hit, 15f);
        Debug.DrawRay(AimRay.origin, AimRay.direction * 10, Color.green);
    }
}
