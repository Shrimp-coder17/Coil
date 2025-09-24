using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject preFabObj;
    private GameObject obj;
    private Recoil recoil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        recoil = GetComponent<Recoil>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            obj = Instantiate(preFabObj) as GameObject;
            obj.transform.localEulerAngles = transform.localEulerAngles;
            obj.transform.position = transform.position;
            recoil.ReactRecoil();
        }
    }
}
