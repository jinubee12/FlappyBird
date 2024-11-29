using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clips;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        OnIntroBGM();
    }

    public void OnIntroBGM()
    {
        audioSource.clip = clips[0]; // ��Ʈ�� BGM
        audioSource.Play();
    }

    public void OnMainBGM()
    {
        audioSource.clip = clips[1]; // ���� BGM
        audioSource.Play();
    }

    public void OnEventSound(int clipIndex)
    {
        audioSource.PlayOneShot(clips[clipIndex]); // 3 -> ���� ���� / 4 -> �浹 ����
    }
}
