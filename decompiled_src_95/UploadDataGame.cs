using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PowerTools;
using TMPro;
using UnityEngine;

public class UploadDataGame : Minigame
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public Color gray;

		public MeshRenderer rend2;

		public MeshRenderer rend1;

		internal void _003CPulseText_003Eb__0(float t)
		{
		}

		internal void _003CPulseText_003Eb__1(float t)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public Vector3 pos;

		public UploadDataGame _003C_003E4__this;

		internal void _003CDoRun_003Eb__0(float t)
		{
		}

		internal void _003CDoRun_003Eb__1(float t)
		{
		}
	}

	private sealed class _003CDoPercent_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadDataGame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoPercent_003Ed__28(int _003C_003E1__state)
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

	private sealed class _003CDoRun_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadDataGame _003C_003E4__this;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoRun_003Ed__30(int _003C_003E1__state)
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

	private sealed class _003CDoText_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadDataGame _003C_003E4__this;

		private StringBuilder _003Ctxt_003E5__2;

		private int _003Cbaselen_003E5__3;

		private int _003Cmax_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoText_003Ed__29(int _003C_003E1__state)
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

	private sealed class _003CPulseText_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadDataGame _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPulseText_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CTransition_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UploadDataGame _003C_003E4__this;

		private float _003Ctarget_003E5__2;

		private float _003Ct_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTransition_003Ed__26(int _003C_003E1__state)
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

	public SpriteAnim LeftFolder;

	public SpriteAnim RightFolder;

	public AnimationClip FolderOpen;

	public AnimationClip FolderClose;

	public SpriteRenderer Runner;

	public HorizontalGauge Gauge;

	public TextRenderer PercentText;

	public TextRenderer EstimatedText;

	public TextRenderer SourceText;

	public TextRenderer TargetText;

	public TMP_Text SourceTextTMP;

	public TMP_Text TargetTextTMP;

	public TMP_Text PercentTextTMP;

	public TMP_Text EstimatedTextTMP;

	public SpriteRenderer Button;

	public TMP_Text ButtonLabel;

	public Sprite DownloadImage;

	public GameObject Status;

	public GameObject Tower;

	private int count;

	private float timer;

	public const float RandomChunks = 5f;

	public const float ConstantTime = 3f;

	private bool running;

	public override void Begin(PlayerTask task)
	{
	}

	public void Click()
	{
	}

	private IEnumerator Transition()
	{
		return null;
	}

	private IEnumerator PulseText()
	{
		return null;
	}

	private IEnumerator DoPercent()
	{
		return null;
	}

	private IEnumerator DoText()
	{
		return null;
	}

	private IEnumerator DoRun()
	{
		return null;
	}
}
