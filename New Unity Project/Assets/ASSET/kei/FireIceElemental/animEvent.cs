using UnityEngine;
using System.Collections;

public class animEvent : MonoBehaviour {

	public GameObject[] DieAnim;
	public GameObject FireElemental;
	public GameObject[] Explosion;
	public Transform Istancer;

	SingleDemo Demo;

	void Start(){
		Demo = GetComponentInParent<SingleDemo>();
	}

	public void ExplosionEvent(){
		if(Demo.curmat == 0){
			GameObject G = (GameObject)Instantiate(Explosion[0], Istancer.position, Quaternion.identity);
			G.SetActive(true);
		}else{
			GameObject G = (GameObject)Instantiate(Explosion[1], Istancer.position, Quaternion.identity);
			G.SetActive(true);
		}
	}


	public void DieEvent(){

		if(Demo.curmat == 0){
			DieAnim[0].SetActive(true);
		}else{
			DieAnim[1].SetActive(true);
		}

		FireElemental.SetActive(false);

	}
}
