using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ColorDragElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image mainImage;

    private Material mainMaterial;
    /// <summary>
    /// ��������, ����������� � �������
    /// </summary>
    public Material MainMaterial
    {
        get { return mainMaterial; }
        set
        {
            if (value != null)
            {
                mainMaterial = value;
                if (mainMaterial != null)
                {
                    mainImage.color = mainMaterial.color;
                }
            }
        }
    }

    private Transform defaultParentTransform;
    /// <summary>
    /// ��������� �������, � �������� ����������� ������
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
    /// ��������� �������, � �������� ������������� ������ �� ����� �����
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
    /// ����� ������� ������ ������������� �������
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
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //�o�������� ������� � ������� �������
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(SiblingIndex);

        //�o����� ��� � ���
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //������� ��� � ������ �������� � ���������� �������
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == "ForRepainting")
                hit.collider.gameObject.GetComponent<Renderer>().material = mainMaterial;
        }
    }
}
