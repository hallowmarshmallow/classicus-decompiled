using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterSurveilanceMinigame : Minigame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ShipRoom, bool> _003C_003E9__17_0;

		internal bool _003CBegin_003Eb__17_0(ShipRoom i)
		{
			return false;
		}
	}

	private sealed class _003CCoAnimateClose_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateClose_003Ed__25(int _003C_003E1__state)
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

	private sealed class _003CCoAnimateOpen_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		private float _003Ctimer3_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__24(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDestroySelf_003Ed__26(int _003C_003E1__state)
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

	public Material GlitchMaterial;

	private bool isStatic;

	private List<RenderTexture> temp;

	public Transform LobbyButton;

	public Camera leftCamera;

	public Camera rightCamera;

	private readonly List<Material> instancedMaterials;

	private Material fillQuadMaterialInstance;

	public override void Begin(PlayerTask task)
	{
	}

	private void FreezeCamera(Camera camera, RenderTexture boundTexture)
	{
	}

	private Material GetViewportMaterial(int index)
	{
		return null;
	}

	public void SelectView(int camId)
	{
	}

	public void ViewLeft(int camId)
	{
	}

	public void ViewRight(int camId)
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

	public new void OnDestroy()
	{
	}
}
