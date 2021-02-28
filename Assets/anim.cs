using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator anime;
    public ExampleStreaming exampleStreaming;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (exampleStreaming.flag == "dance")
        {
            anime.Play("Slow_Rhythm_Dance_02");
        }
        if (exampleStreaming.flag == "stop")
        {
            anime.Play("Pose");
        }

        if (exampleStreaming.flag == "moonwalk")
        {
            anime.Play("Moonwalk_Dance_01");
        }

        if (exampleStreaming.flag == "joke")
        {
            anime.Play("female_talk_stand");
        }

        if (exampleStreaming.flag == "meditation")
        {
            anime.Play("male_act_meditate_start");
        }
    }
}