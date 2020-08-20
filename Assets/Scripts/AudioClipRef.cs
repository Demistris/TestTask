using UnityEngine;

public class AudioClipRef : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;

    public AudioClip AudioClip => _audioClip;
}
