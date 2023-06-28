using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimCrosshairHitScan : MonoBehaviour
{
    public GameObject Explosion;
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
    public Vector3 FinalAim { private set; get; }
    [SerializeField] private LayerMask stuffYouCanAimAt;

    private void Update()
    {
        mousePos = Input.mousePosition;
        reticleScreen.transform.position = mousePos;
        Ray AimRay = camera.ScreenPointToRay(mousePos);

        Vector3 temp = AimRay.origin + AimRay.direction * distance;
        identifier.transform.position = temp;

        // RaycastHit hit;
        // if (Physics.Raycast(AimRay, out hit, distance, stuffYouCanAimAt))
        // {
        //     identifier.transform.position = hit.point;
        //     FinalAim = (hit.point - character.transform.position).normalized;
        // }
        // else
        // {
        //     FinalAim = (temp - character.transform.position).normalized;
        // }
        FinalAim = (temp - character.transform.position).normalized;
        //Debug.DrawRay(AimRay.origin, AimRay.direction * distance, Color.green);
        //Debug.DrawLine(character.transform.position, temp, Color.green);
        //Debug.DrawRay(character.transform.position, FinalAim.normalized * distance, Color.red);

        //Firing
        fireTimer += Time.deltaTime;
        if (fireTimer > fireRate && Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(AimRay, out hit, distance, stuffYouCanAimAt))
            {
                Enemy e = hit.collider.GetComponent<Enemy>();
                e?.TakeDamage();
                Instantiate(Explosion, hit.point, Quaternion.identity);
            }

            BulletDud g = Instantiate(bullet, character.transform.position, Quaternion.identity).GetComponent<BulletDud>();
            g.CurrentPoint = identifier.transform.position;
            g.transform.forward = FinalAim;
            fireTimer = 0;
        }
    }
}
