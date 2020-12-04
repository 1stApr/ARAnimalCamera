using UnityEngine;
using System.Collections;
using System.IO;

public class UILeopard : MonoBehaviour
{
	public float scalingSpeed = 0.03f;
	public float rotationSpeed = 70.0f;
	public float translationSpeed = 5.0f;
	//	public GameObject ModelLeopard;
	bool repeatScaleUp = false;
	bool repeatScaleDown = false;
	bool repeatRotateLeft = false;
	bool repeatRotateRight = false;
	bool repeatPositionUp = false;
	bool repeatPositionDown = false;
	bool repeatPositionLeft = false;
	bool repeatPositionRight = false;

	void Update()
	{
		if (repeatScaleUp)
		{
			SUp();
		}

		if (repeatScaleDown)
		{
			SDown();
		}

		if (repeatRotateRight)
		{
			RRight();
		}

		if (repeatRotateLeft)
		{
			RLeft();
		}

		if (repeatPositionUp)
		{
			PUp();
		}

		if (repeatPositionDown)
		{
			PDown();
		}

		if (repeatPositionLeft)
		{
			PLeft();
		}

		if (repeatPositionRight)
		{
			PRight();
		}

	}
	public void CloseAppButton()
	{
		Application.Quit();
	}
	void RRight()
	{
		GameObject.FindWithTag("ModelLeopard").transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
	}
	void RLeft()
	{
		GameObject.FindWithTag("ModelLeopard").transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
	}
	void SDown()
	{
		GameObject.FindWithTag("ModelLeopard").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
	}
	void PUp()
	{
		GameObject.FindWithTag("ModelLeopard").transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
	}
	void PDown()
	{

		GameObject.FindWithTag("ModelLeopard").transform.Translate(0, 0, translationSpeed * Time.deltaTime);
	}
	void PRight()
	{
		GameObject.FindWithTag("ModelLeopard").transform.Translate(-translationSpeed * Time.deltaTime, 0, 0);
	}
	void PLeft()
	{
		GameObject.FindWithTag("ModelLeopard").transform.Translate(translationSpeed * Time.deltaTime, 0, 0);
	}
	void SUp()
	{
		GameObject.FindWithTag("ModelLeopard").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
	}

	public void RRightRepeat()
	{
		repeatRotateRight = true;
	}
	public void RRightOff()
	{
		repeatRotateRight = false;
		Debug.Log("Off");
	}

	public void RLeftRepeat()
	{
		repeatRotateLeft = true;
	}
	public void RLeftOff()
	{
		repeatRotateLeft = false;
		Debug.Log("Off");
	}

	public void SUpRepeat()
	{
		repeatScaleUp = true;
		Debug.Log("Up");
	}
	public void SUpOff()
	{
		repeatScaleUp = false;
		Debug.Log("Off");
	}

	public void SDownRepeat()
	{
		repeatScaleDown = true;
		Debug.Log("Down");
	}
	public void SDownOff()
	{
		repeatScaleDown = false;
		Debug.Log("Off");
	}

	public void PDownRepeat()
	{
		repeatPositionDown = true;
	}
	public void PDownOff()
	{
		repeatPositionDown = false;
		Debug.Log("Off");
	}

	public void PUpRepeat()
	{
		repeatPositionUp = true;
	}
	public void PUpOff()
	{
		repeatPositionUp = false;
		Debug.Log("Off");
	}

	public void PLeftRepeat()
	{
		repeatPositionLeft = true;
	}
	public void PLeftOff()
	{
		repeatPositionLeft = false;
		Debug.Log("Off");
	}

	public void PRightRepeat()
	{
		repeatPositionRight = true;
	}
	public void PRightOff()
	{
		repeatPositionRight = false;
		Debug.Log("Off");
	}

}
