using UnityEngine;
public class ControlJugador : MonoBehaviour
{
 public float rapidezDesplazamiento = 10.0f;
 void Start()
 {
 Cursor.lockState = CursorLockMode.Locked;
 }
 void Update()
 {
 float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
 float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;
 movimientoAdelanteAtras *= Time.deltaTime;
 movimientoCostados *= Time.deltaTime;
 transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);
 if (Input.GetKeyDown("escape"))
 {
 Cursor.lockState = CursorLockMode.None;
 }
 }
}
using UnityEngine;
public class ControlJugador : MonoBehaviour
{
 private Rigidbody rb;
 public int rapidez;
 void Start()
 {
 rb = GetComponent<Rigidbody>();
 }
 private void FixedUpdate()
 {
 float movimientoHorizontal = Input.GetAxis("Horizontal");
 float movimientoVertical = Input.GetAxis("Vertical");
 Vector3 vectorMovimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
 rb.AddForce(vectorMovimiento * rapidez);
 }
}