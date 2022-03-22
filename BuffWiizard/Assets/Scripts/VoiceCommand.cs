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
    // public GameObject enemy;

    public projectileBehaviour ProjectilePrefab;
    public Transform LaunchOffSet;

    public void Start()
    {
        actions.Add("fireball", fireball);
        actions.Add("lightning", lightning);
        actions.Add("punch", flex);
        actions.Add("kick", headbutt);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    public void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    

    public void fireball()
    {
        //Debug.Log("FIREBALL!!!");
        Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
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

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(ProjectilePrefab, LaunchOffSet.position, transform.rotation);
        }
    }*/
}
