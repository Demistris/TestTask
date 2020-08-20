using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowTextButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textToDisplay;
    [SerializeField] private Button _displayTextButton;
    [SerializeField] private float _textDuration = 3f;

    private float _timer;

    public void DisplayTexts()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        _displayTextButton.interactable = false;
        _textToDisplay.gameObject.SetActive(true);
        _timer = _textDuration;

        while (_timer > 0f)
        {
            _timer = Mathf.Max(0, _timer - Time.deltaTime);
            _textToDisplay.text = _timer.ToString("F");
            yield return null;
        }

        _textToDisplay.gameObject.SetActive(false);
        _displayTextButton.interactable = true;
    }
}