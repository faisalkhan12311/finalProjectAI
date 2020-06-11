using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setVolume(float volume)
    {
        Debug.Log(volume);
        //setting up volume option which will change main mixer volume level
        audioMixer.SetFloat("VolumeParameter", volume);
    }
}
