using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectDragElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]private Image mainImage;

    public void SpriteEditor(Sprite sprite)
    {
        if(sprite != null)
            mainImage.sprite = sprite;
    }

    public void ColorEditor(Color color)
    {
        if(color != null)
            mainImage.color = color;
    }

    private GameObject currentObject;
    private Collider objCollider;
    private Rigidbody objRigidbody;
    private MeshFilter objMeshFilter;

    private GameObject objectToSpawn;
    /// <summary>
    /// GameObject создаваемый драг элементом
    /// </summary>
    public GameObject ObjectToSpawn
    {
        get { return objectToSpawn; }
        set
        {
            if (value != null)
            {
                objectToSpawn = value;
            }
        }
    }

    private Transform defaultParentTransform;
    /// <summary>
    /// Трансформ объекта, к которому прикреплена кнопка
    /// </summary>
    public Transform DefaultParentTransform
    {
        get { return defaultParentTransform; }
        set
        {
            if (value != null)
            {
                defaultParentTransform = value;
            }
        }
    }

    private Transform dragParentTransform;
    /// <summary>
    /// Трансформ объекта, к которому прикрепляется кнопка во время драга
    /// </summary>
    public Transform DragParentTransform
    {
        get { return dragParentTransform; }
        set
        {
            if (value != null)
                dragParentTransform = value;
        }
    }

    private int siblingIndex;
    /// <summary>
    /// Номер индекса внутри родительского объекта
    /// </summary>
    public int SiblingIndex
    {
        get { return siblingIndex; }
        set
        {
            if (value > 0)
                siblingIndex = value;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(DragParentTransform);
        currentObject = Instantiate(objectToSpawn, new Vector3(0, 0, 0), Quaternion.identity);

        objRigidbody = currentObject.GetComponent<Rigidbody>();
        objRigidbody.isKinematic = true;

        objCollider = currentObject.GetComponent<Collider>();
        objCollider.enabled = false;

        objMeshFilter = currentObject.GetComponent<MeshFilter>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

        //сoздаем луч и хит
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //пускаем луч
        if (Physics.Raycast(ray, out hit))
        {
            currentObject.transform.position = hit.point + new Vector3(0, objMeshFilter.mesh.bounds.size.y * 0.5f, 0);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //вoзвращаем обратно в контент элемент
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(SiblingIndex);
        objRigidbody.isKinematic = false;
        objCollider.enabled = true;
    }
}
