using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaa : MonoBehaviour
{
    // Start is called before the first frame update
  private AudioSource audioSource;

    void Start()
    {
        // Lấy reference đến component Audio Source
        audioSource = GetComponent<AudioSource>();

        // Tắt tự động phát khi Awake
        audioSource.playOnAwake = false;

        // Gọi hàm PlayDelayedSound sau một khoảng thời gian
        Invoke("PlayDelayedSound", 1.0f);
    }

    void PlayDelayedSound()
    {
        // Phát âm thanh
        audioSource.Play();
    }
}
