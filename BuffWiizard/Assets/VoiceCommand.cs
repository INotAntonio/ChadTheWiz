using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceCommand : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {
        actions.Add("fireball", fireball);
        actions.Add("lightning", lightning);
        actions.Add("flex", flex);
        actions.Add("headbutt", headbutt);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void fireball()
    {
        Debug.Log("FIREBALL!!!");
    }

    private void lightning()
    {
        Debug.Log("LIGHTNING BOLT!");
    }

    private void flex()
    {
        Debug.Log("OH YEEAAAH!!");
    }

    private void headbutt()
    {
        Debug.Log("HEADBUTT!!");
    }
}
