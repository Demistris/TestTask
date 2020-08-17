using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsPlayer : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _audioClips;
    [SerializeField] private AudioSource _audioSource;

    public void PlayRandomSound()
    {
        _audioSource.clip = _audioClips[Random.Range(0, _audioClips.Count)];
        _audioSource.Play();
    }

    public void ChangeAmountOfSounds(Toggle toggle, AudioClip audioClip)
    {
        if(toggle.isOn)
        {
            _audioClips.Add(audioClip);
        }
        else
        {
            _audioClips.Remove(audioClip);
        }
    }
}
