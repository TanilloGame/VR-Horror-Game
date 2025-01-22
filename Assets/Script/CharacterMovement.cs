using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del personaje
    public float mouseSensitivity = 100f; // Sensibilidad del ratón
    public Transform cameraTransform; // Referencia al Transform de la cámara
    private CharacterController characterController;
    private float verticalRotation = 0f; // Para limitar la rotación vertical

    void Start()
    {
        // Obtiene el componente CharacterController para manejar el movimiento
        characterController = GetComponent<CharacterController>();

        if (characterController == null)
        {
            Debug.LogError("Este script necesita un componente CharacterController adjunto a la cápsula.");
        }

        // Bloquea el cursor en el centro de la pantalla
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Control del movimiento con teclado
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1f; // Adelante
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vertical = -1f; // Atrás
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1f; // Izquierda
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1f; // Derecha
        }

        // Mueve el personaje en función de la dirección de la cámara y entradas
        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        // Normaliza el movimiento si excede 1 para evitar velocidades inconsistentes
        if (moveDirection.magnitude > 1)
        {
            moveDirection.Normalize();
        }

        // Aplicar movimiento al CharacterController
        characterController.Move(moveDirection * speed * Time.deltaTime);

        // Control de la cámara con el ratón
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotación horizontal del personaje (gira sobre el eje Y)
        transform.Rotate(Vector3.up * mouseX);

        // Rotación vertical de la cámara (gira sobre el eje X)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // Limita la rotación vertical
        cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}