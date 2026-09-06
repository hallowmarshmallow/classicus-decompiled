using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlanetSurveillanceMinigame : Minigame
{
	private sealed class _003CCoAnimateClose_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlanetSurveillanceMinigame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateClose_003Ed__22(int _003C_003E1__state)
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

	private sealed class _003CCoAnimateOpen_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlanetSurveillanceMinigame _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlanetSurveillanceMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDestroySelf_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CPulseStatic_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlanetSurveillanceMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPulseStatic_003Ed__20(int _003C_003E1__state)
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

	public Camera Camera;

	public GameObject Viewables;

	public MeshRenderer ViewPort;

	public TextMeshPro LocationName;

	public TextMeshPro SabText;

	private RenderTexture texture;

	public MeshRenderer FillQuad;

	public Material DefaultMaterial;

	public Material StaticMaterial;

	private bool isStatic;

	private SurvCamera[] survCameras;

	public Transform DotParent;

	private SpriteRenderer[] Dots;

	public Sprite DotEnabled;

	public Sprite DotDisabled;

	private int currentCamera;

	public AudioClip ChangeSound;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
	}

	public void NextCamera(int direction)
	{
	}

	private IEnumerator PulseStatic()
	{
		return null;
	}

	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	private IEnumerator CoAnimateClose()
	{
		return null;
	}

	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	public override void Close()
	{
	}

	public override void OnDestroy()
	{
	}
}
