using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource SFXSource;
    public AudioClip[] audioClip;

    public void PlaySFX(int ix)
    {
        if (SFXSource.isPlaying) SFXSource.Stop();
        SFXSource.PlayOneShot(audioClip[ix]);

    }
}