using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimCrosshair : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.125f;
    private float fireTimer = 0.125f;
    private Vector2 mousePos;
    [SerializeField] Camera camera;
    [SerializeField] private GameObject identifier;
    [SerializeField] private GameObject reticleScreen;
    public Ray AimRay { private set; get; }
    [SerializeField] private GameObject character;

    [SerializeField] private GameObject bullet;
    [SerializeField] private float distance = 10f;
    Vector3 FinalAim = Vector3.zero;

    private void Update()
    {
        mousePos = Input.mousePosition;
        reticleScreen.transform.position = mousePos;
        Ray AimRay = camera.ScreenPointToRay(mousePos);
        
        //RaycastHit hit;
        //if(Physics.Raycast(AimRay, out hit, distance))
        //{
        //
        //}


        Vector3 temp = AimRay.origin + AimRay.direction * distance;
        identifier.transform.position = temp;
        
        Debug.DrawRay(AimRay.origin, AimRay.direction * distance, Color.green);
        Debug.DrawLine(character.transform.position, temp, Color.green);
        var wabungus = (temp - character.transform.position).normalized;
        Debug.DrawRay(character.transform.position, wabungus.normalized * distance, Color.red);
        //Firing
        fireTimer += Time.deltaTime;
        if(fireTimer > fireRate && Input.GetMouseButton(0))
        {
            var g = Instantiate(bullet, character.transform.position, Quaternion.identity);
            g.transform.forward = wabungus;
            fireTimer = 0;
        }
    }
}
