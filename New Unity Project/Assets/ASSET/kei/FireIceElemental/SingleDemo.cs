using UnityEngine;
using System.Collections;

public class SingleDemo: MonoBehaviour {
	public Transform T;
	public float speed = 10.0f;
	
	public int curmat;
    public bool ATKFlg = false;
	bool spin;
	public bool Fire;
	
	Camera cam;

	public Animator anim;
	public float size = 1;
	public Material[] Mat;
	public Renderer mesh;
	public bool FX;
	public GameObject[] FX01;
	public GameObject[] FX02;
	public GameObject[] DieAnim;
	public GameObject Elemental;
    
    Bosson bosson;

    void Start () {
		cam = Camera.main;
		spin = false;
		transform.localScale = new Vector3(size,size,size);
		anim = GetComponentInChildren<Animator>();
		DeactivateDieMesh();
		CheckStartFX();

        bosson = GetComponent<Bosson>();

    }


    public void Spin(){
		spin = !spin;
		T.eulerAngles = Vector3.zero;
	}
	public void ChangeMat(){
		if(curmat == 0){
			curmat = 1;
			if(FX){
				for ( int i = 0; i < FX01.Length; i++){
					FX01[i].SetActive(false);
				}
				for ( int i = 0; i < FX02.Length; i++){
					FX02[i].SetActive(true);
				}
			}
		}else{
			curmat = 0;
			if(FX){
				for ( int i = 0; i < FX01.Length; i++){
					FX01[i].SetActive(true);
				}
				for ( int i = 0; i < FX02.Length; i++){
					FX02[i].SetActive(false);
				}
			}
		}
		mesh.material = Mat[curmat];
	}
		
		/// animation
	public void Idle(){

		CheckStatus();
		anim.Play("idle");
	}

	public void IdleActivate(){
		
		CheckStatus();
		anim.Play("idleActivate");
	}

	public void Walk(){
		CheckStatus();
		anim.Play("walk");
        ATKFlg = false;
    }
	public void Run(){
		CheckStatus();
		anim.Play("run");
	}
	public void Hit(){
		CheckStatus();
		anim.Play("hit");
	}
	public void Activate(){
		CheckStatus();
		anim.Play("activate");
        bosson.BossFlg = 3;
	}

	public void Atk01(){
		CheckStatus();
		anim.Play("attack01");
        Debug.Log("アタック");
        ATKFlg = true;
	}
	public void Atk02(){
		CheckStatus();
		anim.Play("attack02");
        ATKFlg = true;
    }
		
	public void die(){
		CheckStatus();
		anim.Play("die");
	}
	
	void Update(){
		
		if(Input.GetMouseButton(0)){
			T.eulerAngles = new Vector3(T.eulerAngles.x,T.eulerAngles.y + Input.GetAxis("Mouse X") * -2,T.eulerAngles.z);
		}
		
		if (spin == false){
			return;
		}
		T.eulerAngles = new Vector3(T.eulerAngles.x,T.eulerAngles.y + speed * Time.deltaTime,T.eulerAngles.z);
	}

	void CheckStatus(){
		
		if(Elemental.activeSelf == false){
			Elemental.SetActive(true);
			DeactivateDieMesh();
		}
	}

	void DeactivateDieMesh(){

		for(int i = 0 ; i < DieAnim.Length; i++){
			DieAnim[i].SetActive(false);
		}
	}

	void CheckStartFX(){
			if(curmat == 0){
				if(FX){
					for ( int i = 0; i < FX01.Length; i++){
						FX01[i].SetActive(true);
					}
					for ( int i = 0; i < FX02.Length; i++){
						FX02[i].SetActive(false);
					}
				}
			}else{
				if(FX){
					for ( int i = 0; i < FX01.Length; i++){
						FX01[i].SetActive(false);
					}
					for ( int i = 0; i < FX02.Length; i++){
						FX02[i].SetActive(true);
					}
				}
			}
		mesh.material = Mat[curmat];
	}
}
