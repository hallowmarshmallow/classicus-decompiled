using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaffMenuController : MonoBehaviour
{
	private sealed class _003CCoRegisterButtons_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StaffMenuController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoRegisterButtons_003Ed__28(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public GameObject StaffMenuObject;

	public GameObject StaffOptionMenuObject;

	public PassiveButton BackdropButton;

	public PassiveButton AnonymousButton;

	public TextMeshPro AnonymousText;

	public PassiveButton NoMuzikButton;

	public TextMeshPro NoMuzikText;

	public AudioClip StaffIntroClip;

	public AudioClip StaffLoopClip;

	public float StaffSequenceVolume;

	public float StaffFadeInDuration;

	private const string PersistentRootName = "StaffMenuPersistent";

	private static StaffMenuController persistentInstance;

	private static bool adoptNextInstance;

	private bool isPersistent;

	private bool dormant;

	private Camera anchorCamera;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void DiscardSceneCopy()
	{
	}

	private void PromoteToPersistent()
	{
	}

	private void LateUpdate()
	{
	}

	private static Camera ResolveAnchorCamera()
	{
		return null;
	}

	private void HandleSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void QueueButtonRegistration()
	{
	}

	private IEnumerator CoRegisterButtons()
	{
		return null;
	}

	private void RegisterButtons()
	{
	}

	private void ResolveNoMuzikButton()
	{
	}

	private static Transform FindChildDeep(Transform root, string name)
	{
		return null;
	}

	public void RefreshStaffMenuVisibility()
	{
	}

	private static bool IsStaffMenuScene()
	{
		return false;
	}

	private void StartStaffMusic()
	{
	}

	public void CloseStaffOptionMenu()
	{
	}

	private void OnAnonymousClicked()
	{
	}

	private void RefreshAnonymousLabel()
	{
	}

	private void OnNoMuzikClicked()
	{
	}

	private void RestartDefaultMusic()
	{
	}

	private void RefreshNoMuzikLabel()
	{
	}
}
