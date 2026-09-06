using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveillanceMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ShipRoom, bool> _003C_003E9__10_0;

		internal bool _003CBegin_003Eb__10_0(ShipRoom i)
		{
			return false;
		}
	}

	private sealed class _003CCoAnimateClose_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SurveillanceMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateClose_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CCoAnimateOpen_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SurveillanceMinigame _003C_003E4__this;

		private float _003Ctimer3_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__12(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SurveillanceMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDestroySelf_003Ed__14(int _003C_003E1__state)
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

	public Camera CameraPrefab;

	public GameObject Viewables;

	public MeshRenderer[] ViewPorts;

	public TextRenderer[] SabText;

	private ShipRoom[] FilteredRooms;

	private RenderTexture[] textures;

	public MeshRenderer FillQuad;

	public Material DefaultMaterial;

	public Material StaticMaterial;

	private bool isStatic;

	public override void Begin(PlayerTask task)
	{
	}

	public void Update()
	{
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
