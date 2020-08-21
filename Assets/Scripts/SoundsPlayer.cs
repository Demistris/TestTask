using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource = null;
    [SerializeField] private List<AudioClipRef> _audioClips = new List<AudioClipRef>();

    public void PlayRandomSound()
    {
        if (_audioClips.Count <= 0)
        {
            return;
        }

        _audioSource.PlayOneShot(_audioClips[Random.Range(0, _audioClips.Count)].AudioClip);
    }

    public void ChangeAmountOfSounds(Toggle toggle)
    {
        AudioClipRef clip = toggle.GetComponent<AudioClipRef>();

        if(clip == null)
        {
            Debug.LogWarning("AudioClip not found.");
            return;
        }

        if (toggle.isOn)
        {
            _audioClips.Add(clip);
        }
        else
        {
            _audioClips.Remove(clip);
        }
    }
}
