using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] footsteps;

    public void Step()
    {
        int randomindex=Random.Range(0,footsteps.Length);
        AudioClip footstepclip=footsteps[randomindex];
        audioSource.PlayOneShot(footstepclip);
    }
}