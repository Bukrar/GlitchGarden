using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 0f;

    void Start()
    {
        VolumeSlider.value = PlayerPrefabController.GetMasterVolume();
        difficultySlider.value = PlayerPrefabController.GetDifficulty();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.SetVolume(VolumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No MusicPlayer");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefabController.SetMasterVolume(VolumeSlider.value);
        PlayerPrefabController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();

    }

    public void SetDefalut()
    {
        VolumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
