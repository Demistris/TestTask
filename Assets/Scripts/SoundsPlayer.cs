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
        if (_audioClips.Count > 0)
        {
            _audioSource.clip = _audioClips[Random.Range(0, _audioClips.Count)];
            _audioSource.Play();
        }
    }

    public void ChangeAmountOfSounds(Toggle toggle)
    {
        if(toggle.isOn)
        {
            _audioClips.Add(toggle.GetComponent<AudioClipName>()._audioClip);
        }
        else
        {
            _audioClips.Remove(toggle.GetComponent<AudioClipName>()._audioClip);
        }
    }
}
