using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer Mixer;
    [SerializeField] private Slider musicSlider, sfxSlider;

    private void Start()
    {
        loadMusic();
    }
    public void SetMusic()
    {
        float volume = musicSlider.value;
        Mixer.SetFloat("music",Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSfx()
    {
        float volume = sfxSlider.value;
        Mixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    public void loadMusic()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusic();
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        SetSfx();
    }
}
