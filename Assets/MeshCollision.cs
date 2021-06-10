using UnityEngine;

public class MeshCollision : MonoBehaviour {
    GameObject[] surface;
    Rigidbody surfaceRB;
    FixedJoint joint;
    void Start() {
        surface = GameObject.FindGameObjectsWithTag("ground");
        for (int i = 0; i < surface.Length; i++) {
            surfaceRB = surface[i].GetComponent<Rigidbody>();
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "ground") {
            joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = surfaceRB;
            joint.breakForce = 0.1f;
        }
    }
}