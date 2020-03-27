using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class coinscripts : MonoBehaviour
{
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        // lætur peninginn snúast í hringi
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.GetComponent<FirstPersonController>().points++;
            Destroy(gameObject);
        }
        gameManager.CompleteLevel();
    }
}
