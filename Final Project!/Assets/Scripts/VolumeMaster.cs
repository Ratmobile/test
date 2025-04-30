using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TextMeshProUGUI volumeText;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
        }

        LoadVolume();

        volumeSlider.onValueChanged.AddListener((v) =>
        {
            UpdateVolumeDisplay(v);
            ChangeVolume(v);
        });
    }

    private void UpdateVolumeDisplay(float volume)
    {
        volumeText.text = (volume * 100).ToString("0") + "%";
    }

    private void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    private void LoadVolume()
    {
        float savedVolume = PlayerPrefs.GetFloat("musicVolume");
        volumeSlider.value = savedVolume;
        UpdateVolumeDisplay(savedVolume);
        AudioListener.volume = savedVolume;
    }
}
