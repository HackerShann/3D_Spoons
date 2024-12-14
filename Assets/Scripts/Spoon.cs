using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{

    public AudioSource MySound;
    public GameObject WhoToClone;
    private bool FirstHit = false;

    private void OnCollisionEnter(Collision WhoDidIHit)
    {
        print(WhoDidIHit.relativeVelocity.magnitude);
        float HowHard = WhoDidIHit.relativeVelocity.magnitude / 6;
        MySound.volume = HowHard;
        MySound.pitch = HowHard / 2f;
        MySound.Play();

        if(FirstHit == false)
        {
            float NewX = Random.Range(-0.3f, 0.3f);
            float NewZ = Random.Range(-0.3f, 0.3f);

            GameObject myClone = Instantiate
                (WhoToClone,
                new Vector3(NewX, 4.0f, NewZ),
                Random.rotation);
            FirstHit = true;
        }// end if
    }//end of collision enter
}//end class
