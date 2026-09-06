using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsMinigame : Minigame
{
	private sealed class _003CCoAnimateOpen_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoAnimateOpen_003Ed__17(int _003C_003E1__state)
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

	private sealed class _003CCoDestroySelf_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoDestroySelf_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CCoOpenDrawer_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoOpenDrawer_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CCoSlideBook_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSlideBook_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CCoSlideFolder_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecordsMinigame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoSlideFolder_003Ed__24(int _003C_003E1__state)
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

	public GameObject FoldersContent;

	public SpriteRenderer[] Folders;

	public GameObject DrawerContent;

	public Transform Drawer;

	public SpriteRenderer DrawerFolder;

	public GameObject ShelfContent;

	public SpriteRenderer[] Books;

	public Sprite[] BookCovers;

	private SpriteRenderer targetBook;

	public AudioClip recordFilePlace;

	public AudioClip recordBookPlace;

	public AudioClip grabDocument;

	public AudioClip drawerOpen;

	public AudioClip drawerClose;

	public Transform bookInputPrompt;

	public ControllerButtonBehaviourComplex slideFolderHotkey;

	public override void Begin(PlayerTask task)
	{
	}

	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	public void PlaceBook()
	{
	}

	private IEnumerator CoSlideBook()
	{
		return null;
	}

	public void FileDocument()
	{
	}

	private bool MarkConsoleFinished()
	{
		return false;
	}

	private IEnumerator CoOpenDrawer()
	{
		return null;
	}

	private IEnumerator CoSlideFolder()
	{
		return null;
	}

	public void GrabFolder(SpriteRenderer folder)
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private IEnumerator _003C_003En__1()
	{
		return null;
	}
}
