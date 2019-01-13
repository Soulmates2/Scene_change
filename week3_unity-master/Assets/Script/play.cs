using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("p", 1);
    }

    private void p()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audio.isPlaying)
        {
            Debug.Log("end");
            //점수창으로 가기
            Destroy(this);
        }
    }
}
