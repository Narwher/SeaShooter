using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLost : MonoBehaviour
{

  void OnCollisionEnter(Collision dataFromCollision)
  {
        if (dataFromCollision.gameObject.name == "Trap")
        {
          MissionDemolition.ShotFired();
          AudioSource trapSound = GameObject.Find("TrapSound").GetComponent<AudioSource>();
          trapSound.Play(0);
          Object.Destroy(this.gameObject);
        }
  }
}
