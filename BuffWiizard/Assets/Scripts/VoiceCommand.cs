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

    public void Start()
    {
        actions.Add("fireball", fireball);
        actions.Add("lightning", lightning);
        actions.Add("flex", flex);
        actions.Add("headbutt", headbutt);
        actions.Add("Yes", Yes);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    public void Yes()
    {
        Debug.Log("YES!YES!!YES!!!");
    }

    public void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    public void fireball()
    {
        Debug.Log("FIREBALL!!!");
    }

    public void lightning()
    {
        Debug.Log("LIGHTNING BOLT!");
    }

    public void flex()
    {
        Debug.Log("OH YEEAAAH!!");
    }

    public void headbutt()
    {
        Debug.Log("HEADBUTT!!");
    }
}
