using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Reset : MonoBehaviour
{
    public XRGrabInteractable kinematicObject;
    public XRGrabInteractable instantaneousObject;
    public XRGrabInteractable velocityObject;

    public GameObject kinematicObjectPrefab;
    public GameObject instantaneousObjectPrefab;
    public GameObject velocityObjectPrefab;

    private Vector3 kinematicObjectInitialPosition;
    private Quaternion kinematicObjectInitialRotation;
    private Vector3 instantaneousObjectInitialPosition;
    private Quaternion instantaneousObjectInitialRotation;
    private Vector3 velocityObjectInitialPosition;
    private Quaternion velocityObjectInitialRotation;

    // Start is called before the first frame update
    void Start()
    {
        kinematicObjectInitialPosition = kinematicObject.transform.position;
        kinematicObjectInitialRotation = kinematicObject.transform.rotation;
        instantaneousObjectInitialPosition = instantaneousObject.transform.position;
        instantaneousObjectInitialRotation = instantaneousObject.transform.rotation;
        velocityObjectInitialPosition = velocityObject.transform.position;
        velocityObjectInitialRotation = velocityObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetObjects()
    {
        Destroy(kinematicObject.gameObject);
        Destroy(instantaneousObject.gameObject);
        Destroy(velocityObject.gameObject);

        kinematicObject = Instantiate(kinematicObjectPrefab, kinematicObjectInitialPosition, kinematicObjectInitialRotation).GetComponent<XRGrabInteractable>();
        instantaneousObject = Instantiate(instantaneousObjectPrefab, instantaneousObjectInitialPosition, instantaneousObjectInitialRotation).GetComponent<XRGrabInteractable>();
        velocityObject = Instantiate(velocityObjectPrefab, velocityObjectInitialPosition, velocityObjectInitialRotation).GetComponent<XRGrabInteractable>();
    }
}
