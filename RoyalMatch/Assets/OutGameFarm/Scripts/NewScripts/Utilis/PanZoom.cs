using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanZoom : MonoBehaviour
{
    public static PanZoom current;
    
    	public bool disabled = true;
    
    	private Vector3 touchPos;
    
    	public float zoomMin = 2f;
    
    	public float zoomMax = 5f;
    
    	private bool multiTouch;
    
    	[SerializeField]
    	public float leftLimit;
    
    	[SerializeField]
    	public float rightLimit;
    
    	[SerializeField]
    	public float bottomLimit;
    
    	[SerializeField]
    	public float upperLimit;
    
    	private Camera cam;
    
    	private void Awake()
    	{
    		cam = GetComponent<Camera>();
    		current = this;
    	}
    
    	private void Update()
    	{
    		if (disabled)
    		{
    			return;
    		}
    		if (Input.GetMouseButtonDown(0))
    		{
    			if (EventSystem.current.IsPointerOverGameObject())
    			{
    				return;
    			}
    			touchPos = cam.ScreenToWorldPoint(Input.mousePosition);
    			multiTouch = false;
    		}
    		if (Input.touchCount == 2)
    		{
    			multiTouch = true;
    			Touch touch = Input.GetTouch(0);
    			Touch touch2 = Input.GetTouch(1);
    			if (EventSystem.current.IsPointerOverGameObject(touch.fingerId) || EventSystem.current.IsPointerOverGameObject(touch2.fingerId))
    			{
    				return;
    			}
    			Vector2 vector = touch.position - touch.deltaPosition;
    			Vector2 vector2 = touch2.position - touch2.deltaPosition;
    			float magnitude = (vector - vector2).magnitude;
    			float num = (touch.position - touch2.position).magnitude - magnitude;
    			zoom(num * 0.01f);
    		}
    		else if (Input.GetMouseButton(0) && !multiTouch)
    		{
    			if (EventSystem.current.IsPointerOverGameObject())
    			{
    				return;
    			}
    			Vector3 vector3 = touchPos - cam.ScreenToWorldPoint(Input.mousePosition);
    			cam.transform.position += vector3;
    		}
    		zoom(Input.GetAxis("Mouse ScrollWheel"));
    		base.transform.position = new Vector3(Mathf.Clamp(base.transform.position.x, leftLimit, rightLimit), Mathf.Clamp(base.transform.position.y, bottomLimit, upperLimit), base.transform.position.z);
    	}
    
    	private void zoom(float increment)
    	{
    		cam.orthographicSize = Mathf.Clamp(cam.orthographicSize - increment, zoomMin, zoomMax);
    	}
    
    	public void Focus(Vector3 position)
    	{
    		//LeanTween.move(to: new Vector3(position.x, position.y, base.transform.position.z), gameObject: base.gameObject, time: 0.2f);
    		base.transform.position = new Vector3(Mathf.Clamp(base.transform.position.x, leftLimit, rightLimit), Mathf.Clamp(base.transform.position.y, bottomLimit, upperLimit), base.transform.position.z);
    		touchPos = base.transform.position;
    	}
    
    	private void OnDrawGizmos()
    	{
    		Gizmos.color = Color.yellow;
    		Gizmos.DrawWireCube(new Vector3((rightLimit - Mathf.Abs(leftLimit)) / 2f, (upperLimit - Mathf.Abs(bottomLimit)) / 2f), new Vector3(rightLimit - leftLimit, upperLimit - bottomLimit));
    	}
}
