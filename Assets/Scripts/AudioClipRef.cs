using UnityEngine;

public class AudioClipRef : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip = null;

    public AudioClip AudioClip => _audioClip;
}
