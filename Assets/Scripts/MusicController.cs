using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button playPauseButton;
    public Button stopButton;
    public Slider volumeSlider;
    public Slider speedSlider;


    private bool isPlaying = false;

    void Start()
    {
        // Setup Button Events
        playPauseButton.onClick.AddListener(TogglePlayPause);
        stopButton.onClick.AddListener(StopMusic);
        // Setup Slider Events
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
        speedSlider.onValueChanged.AddListener(UpdateSpeed);


    }

    void TogglePlayPause()
    {
        if (!isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
        else
        {
            audioSource.Pause();
            isPlaying = false;
        }

        
    }

    void StopMusic()
    {
        audioSource.Stop();
        isPlaying = false;
       
    }

    void UpdateVolume(float value)
    {
        audioSource.volume = value;

    }

    void UpdateSpeed(float value)
    {
        audioSource.pitch = value;

    }
}
