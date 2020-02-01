using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [System.Serializable]
    public class Audio
    {
        public string tag;
        public AudioClip clip;
        public AudioSource link;
        public bool loop;
        public int volume;
        public bool pause=false;
    }
    public Audio[] audioArray;
    public static AudioManager Instance;
    private void Awake() {
        Instance = this;
    }
    void Start()
    {
        int i = 0;
        AudioSource[] audioSource = new AudioSource[audioArray.Length];
        foreach (Audio audio in audioArray)
        {
            gameObject.AddComponent(typeof(AudioSource));
            audioSource = gameObject.GetComponents<AudioSource>();
            audioSource[i].clip = audio.clip;
            audioSource[i].volume = audio.volume;
            audioSource[i].loop = audio.loop;
            audio.link = audioSource[i];
            i++;
        }
    }
    public void PlaySound(string name)
    {
        foreach(Audio audio in audioArray)
        {
            if(audio.tag==name)
            {
                audio.link.Play();
            }
        }
    }
    public void StopSound(string name)
    {
        foreach(Audio audio in audioArray)
        {
            if(audio.tag==name)
            {
                audio.link.Stop();
            }
        }
    }
    public void LoopSound(string name, bool b)
    {
        foreach(Audio audio in audioArray)
        {
            if(audio.tag==name)
            {
                audio.link.loop=b;
            }
        }
    }
    public void PauseUnPause(string name)
    {
        foreach(Audio audio in audioArray)
        {
            if(audio.tag==name)
            {
                CheckForPause(audio);
            }
            if("all"==name)
            {
                CheckForPause(audio);
            }
        }
    }
    private void CheckForPause(Audio audio)
    {
        if(!audio.pause)
        {
            audio.link.Pause();
            audio.pause=true;
        }
        else{
            audio.link.UnPause();
            audio.pause=false;
        }
    }
}

