using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MotorSesiKontrol : MonoBehaviour
{
    public AudioClip acma;
    public AudioClip calisma;
    public AudioClip kapama;
    public float d_hiz;
    public float mi_pit;
    public float pi_hiz;
    private AudioSource _source;
    bool mar�;
    float hiz;
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }
    void Update()
    {
        mar� = GetComponent<ArabaKontrol1>().mars;
        hiz = GetComponent<ArabaKontrol1>().speed;
        if(!mar� && _source.clip == calisma)
        {
            _source.clip = kapama;
            _source.Play();
        }
        if(mar� && (_source.clip == kapama || _source.clip == null))
        {
            _source.clip = acma;
            _source.Play();
            _source.pitch = 1;
        }
        if(mar� && !_source.isPlaying)
        {
            _source.clip = calisma;
            _source.Play();
        }
        if(_source.clip == calisma)
        {
            _source.pitch = Mathf.Lerp(_source.pitch, mi_pit + Mathf.Abs(hiz) / d_hiz, pi_hiz);
        }
    }
}
