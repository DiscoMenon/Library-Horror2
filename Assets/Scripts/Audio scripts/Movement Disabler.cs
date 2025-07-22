using UnityEngine;
using System.Collections;

public class MovementDisabler : MonoBehaviour
{
    public MonoBehaviour movementScript;
    public AudioSource breathing;

    void Start()
    {
        StartCoroutine(EnableMovementAfterDelay(22f));
    }

    IEnumerator EnableMovementAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        movementScript.enabled = true;
        breathing.enabled = true;

    }
}
