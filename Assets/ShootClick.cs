using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootClick : MonoBehaviour {
    [SerializeField] private GameObject _Body;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            GameObject _SoftBody = Instantiate(_Body, transform.position, transform.rotation);
            _SoftBody.GetComponentInChildren<Rigidbody>().AddForce(transform.forward * 0.1f);
            Destroy(_SoftBody, 15f);
        }
    }
}