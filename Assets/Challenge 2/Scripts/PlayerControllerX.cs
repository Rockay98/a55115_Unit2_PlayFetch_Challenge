using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTimer = 0.8f;
    private bool onCooldown = false;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !onCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            onCooldown = true;
            Invoke("releaseCooldown", cooldownTimer);
        }
    }

    void releaseCooldown() {
      onCooldown = false;
    }
}
