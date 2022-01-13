using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public SoundClips[] audioClipArray;

    [System.Serializable]
    public class SoundClips
    {
        public Sounds sound;
        public AudioClip audioClip;
    }

    public void PlaySound(Sounds sound)
    {
        GameObject soundObj = new GameObject("Sound");
        AudioSource audioSource = soundObj.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetSounds(sound));
        Destroy(soundObj, 2);
    }

    private AudioClip GetSounds(Sounds sounds)
    {
        foreach(SoundClips audio in audioClipArray)
        {
            if(audio.sound == sounds)
            {
                return audio.audioClip;
            }
        }
        return null;
    }

    public enum Sounds
    {
        Collect_Healthy,
        Collect_Unhealthy,
        ObjectSpawn,
        LoseSound,
        BGM_Level_1,
        BGM_Level_2,
        BGM_GameWin,
        BGM_GameLose,
    }
}
