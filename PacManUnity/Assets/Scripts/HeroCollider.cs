using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollider : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pac")
        {
            GameController.Instance.Score++;
            Destroy(other.gameObject);
        }else if (other.gameObject.tag == "Monster")
        {
            GameController.Instance.GameOver();
            GetComponent<Animator>().SetBool("IsDead", true);
            GetComponent<HeroControl>().enabled = false;
        }
    }
}
