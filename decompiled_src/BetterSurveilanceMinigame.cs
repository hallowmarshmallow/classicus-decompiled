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

		static _003C_003Ec()
		{
			throw null;
		}

		public _003C_003Ec()
		{
			throw null;
		}

		internal bool _003CBegin_003Eb__17_0(ShipRoom i)
		{
			throw null;
		}
	}

	private sealed class _003CCoAnimateClose_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		private float _003Ctimer2_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoAnimateClose_003Ed__25(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoAnimateOpen_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		private float _003Ctimer3_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoAnimateOpen_003Ed__24(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private sealed class _003CCoDestroySelf_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BetterSurveilanceMinigame _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public _003CCoDestroySelf_003Ed__26(int _003C_003E1__state)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			throw null;
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
		throw null;
	}

	private void FreezeCamera(Camera camera, RenderTexture boundTexture)
	{
		throw null;
	}

	private Material GetViewportMaterial(int index)
	{
		throw null;
	}

	public void SelectView(int camId)
	{
		throw null;
	}

	public void ViewLeft(int camId)
	{
		throw null;
	}

	public void ViewRight(int camId)
	{
		throw null;
	}

	public void Update()
	{
		throw null;
	}

	protected override IEnumerator CoAnimateOpen()
	{
		throw null;
	}

	private IEnumerator CoAnimateClose()
	{
		throw null;
	}

	protected override IEnumerator CoDestroySelf()
	{
		throw null;
	}

	public override void Close()
	{
		throw null;
	}

	public new void OnDestroy()
	{
		throw null;
	}

	public BetterSurveilanceMinigame()
	{
		throw null;
	}
}
