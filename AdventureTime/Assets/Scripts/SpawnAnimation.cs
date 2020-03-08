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
    bool end;
    public Animator anim;
    public AudioSource sound;

    void Start() {
        pp.profile.TryGetSettings(out color);
        player.enabled = false;
        spawnParticle1.SetActive(true);
        spawnParticle2.SetActive(false);
        anim.SetTrigger("Start");
    }

    public void Update() {
        if (starter) {
            color.postExposure.value = Mathf.PingPong(Time.time * 1.7f, 6f);
            StartCoroutine(StarterBool());
        }

        if (end) {
            this.gameObject.SetActive(false);
        }
    }

    public void ParticleFall(){
        spawnParticle2.SetActive(true);
    }

    public void PlaySound() {
        sound.Play();
    }

    public void lightShine() {
        starter = true;
    }

    IEnumerator StarterBool() {
        yield return new WaitForSeconds(1.25f);
        spawnParticle1.SetActive(false);
        spawnParticle2.SetActive(false);
        player.enabled = true;
        yield return new WaitForSeconds(2.9f);
        starter = false;
        color.postExposure.value = 1.2f;
        yield return new WaitForSeconds(1f);
        end = true;
    }
}
