using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchselect : MonoBehaviour
{
    public GameObject watch1;
    public GameObject watch2;
    public GameObject watch3;
    public GameObject watch1windows;
    public GameObject watch2windows;
    public GameObject watch3windows;
    Animation w1animation;
    Animation w2animation;
    Animation w3animation;
    // Start is called before the first frame update
    void Start()
    {
        w1animation = watch1windows.GetComponent<Animation>();
        w2animation = watch2windows.GetComponent<Animation>();
        w3animation = watch3windows.GetComponent<Animation>();
    }
    public void watchoneclicked()
    {
        watch1.SetActive(true);
        watch2.SetActive(false);
        watch3.SetActive(false);

        w1animation["w1animation"].speed = 1;
        w1animation.Play();
    }
    public void watchtwoclicked()
    {
        watch1.SetActive(false);
        watch2.SetActive(true);
        watch3.SetActive(false);
        w2animation["w2animation"].speed = 1;
        w2animation.Play();

    }
    public void watchthreeclicked()
    {
        watch1.SetActive(false);
        watch2.SetActive(false);
        watch3.SetActive(true);

        w3animation["w3animation"].speed = 1;
        w2animation.Play();
    }



}
