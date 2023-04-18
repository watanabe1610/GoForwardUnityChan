using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundController : MonoBehaviour
{ 
    /// <summary>
    ///   Cubeが接触時にならす音声を入れるための変数
    /// </summary>
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 接触時に音をならす関数
    /// </summary>
    /// <param name="other">接触した他のGameObject</param>
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("CubeTag") || other.gameObject.CompareTag("GroundTag"))
        {
            audio.Play();
        }
    }
        
}