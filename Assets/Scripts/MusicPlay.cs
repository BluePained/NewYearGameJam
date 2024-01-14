using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlay : MonoBehaviour
{
    [SerializeField] private Image musicButtonImage;
    [SerializeField] private Sprite[] image; 
    [SerializeField] private GameObject musicButton;
    [SerializeField] private AudioSource music;
    
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(musicButton);

    }
    void Start()
    {
        musicButtonImage.sprite = image[0];

    }

    public void MuteOrNotMute()
    {
        if (music.mute)
        {
            music.mute = false;
            musicButtonImage.sprite = image[0];

        }
        else
        {
            music.mute = true;
            musicButtonImage.sprite = image[1];
        }
    }
}
