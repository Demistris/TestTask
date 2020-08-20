using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private readonly List<AudioClip> _audioClips = new List<AudioClip>();

    public void PlayRandomSound()
    {
        if (_audioClips.Count < 0)
        {
            return;
        }

        _audioSource.PlayOneShot(_audioClips[Random.Range(0, _audioClips.Count)]);
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
            _audioClips.Add(clip.AudioClip);
        }
        else
        {
            _audioClips.Remove(clip.AudioClip);
        }
    }
}
