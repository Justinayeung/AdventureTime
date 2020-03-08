using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SpawnAnimation : MonoBehaviour
{
    public GameObject spawnParticle1;
    public GameObject spawnParticle2;
    public SkinnedMeshRenderer player;
    public PostProcessVolume pp;
    ColorGrading color;
    bool starter;
    public Animator anim;
    public AudioSource sound;
    float t = 0.0f;
    float max = 6.5f;
    float min = 1.2f;

    void Start() {
        pp.profile.TryGetSettings(out color);
        player.enabled = false;
        spawnParticle1.SetActive(true);
        spawnParticle2.SetActive(false);
        anim.SetTrigger("Start");
    }

    public void Update() {
        Debug.Log(t);
        if (starter) {
            color.postExposure.value = Mathf.Lerp(min, max, t);
            StartCoroutine(StarterBool());
            t += 0.5f * Time.deltaTime;

            if (t > 1.3f) {
                float temp = max;
                max = min;
                min = temp;
                t = 0.0f;
            }
        }

        if (StaticClass.end) {
            this.gameObject.SetActive(false);
        }
    }

    public void ParticleFall(){ //Called in animation
        spawnParticle2.SetActive(true);
    }

    public void PlaySound() { //Called in animation
        sound.Play();
    }

    public void lightShine() { //Called in animation
        starter = true;
    }

    IEnumerator StarterBool() {
        yield return new WaitForSeconds(1.6f);
        spawnParticle1.SetActive(false);
        spawnParticle2.SetActive(false);
        player.enabled = true;
        yield return new WaitForSeconds(2.9f);
        starter = false;
        color.postExposure.value = 1.2f;
        yield return new WaitForSeconds(1f);
        StaticClass.end = true;
    }
}
