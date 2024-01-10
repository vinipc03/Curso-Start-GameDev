﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{

    [SerializeField] private AudioClip bmgMusic;

    private AudioManager audioM;
    // Start is called before the first frame update
    void Start()
    {
        audioM = FindObjectOfType<AudioManager>();

        audioM.PlayBGM(bmgMusic);
    }

}
