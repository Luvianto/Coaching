using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer musicMixer;
    [SerializeField] private Slider musicSlider;

    public void SetMusic()
    {
        float volume = musicSlider.value;
        musicMixer.SetFloat("music",Mathf.Log10(volume)*20);
    }
}
