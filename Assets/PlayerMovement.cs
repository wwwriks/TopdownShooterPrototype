using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 input;
    private Vector2 moveDir = Vector2.zero;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float speedSmoothing = 1;
    private Vector3 velocity;
    [SerializeField] private Vector2 bounds;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private GameObject characterFace = null;
    [SerializeField] private PlayerAimCrosshair aim;
    [SerializeField] private Camera camera;
    [SerializeField] private Material mat;

    private void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        input.Normalize();
        transform.position = Vector3.SmoothDamp(transform.position, transform.position + input * speed, ref velocity, speedSmoothing);

        KeepInBounds();
        CharacterTurn();
    }

    private void CharacterTurn()
    {
        var rot = Quaternion.LookRotation(aim.FinalAim, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotationSpeed * Time.deltaTime);
    }

    private void KeepInBounds()
    {
        if(transform.position.x > bounds.x)
        {
            transform.position = new Vector3(bounds.x, transform.position.y, transform.position.z);
            velocity = new Vector3(0, velocity.y, velocity.z);
        }
        if(transform.position.x < -bounds.x)
        {
            transform.position = new Vector3(-bounds.x, transform.position.y, transform.position.z);
            velocity = new Vector3(0, velocity.y, velocity.z);
        }
        if(transform.position.y > bounds.y)
        {
            transform.position = new Vector3(transform.position.x, bounds.y, transform.position.z);
            velocity = new Vector3(velocity.x, 0, velocity.z);
        }
        if(transform.position.y < -bounds.y)
        {
            transform.position = new Vector3(transform.position.x, -bounds.y, transform.position.z);
            velocity = new Vector3(velocity.x, 0, velocity.z);
        }
    }
}
