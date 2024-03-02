using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sfx;

    public AudioClip bgm;
    public AudioClip coinSfx;

    private void Start()
    {
        music.clip = bgm;
        music.Play();
    }

    public void playSfx(AudioClip clip)
    {
        sfx.PlayOneShot(clip);
    }
}
