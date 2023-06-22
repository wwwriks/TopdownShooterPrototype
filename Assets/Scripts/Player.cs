using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int Health = 10;
    private bool _invincible = false;

    public void TakeDamage()
    {
        if (_invincible) return;
        Health--;
        if (Health <= 0) SceneManager.LoadScene("End");
    }
}
