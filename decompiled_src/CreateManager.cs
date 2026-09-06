using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	private struct _003CCreatePressed_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CreateManager _003C_003E4__this;

		private LoaderSystem.Load _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			throw null;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw null;
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private SelectManager _selectManager;

	private TMP_InputField _nameInput;

	private GameObject _createBtn;

	private Image _heroImage;

	private TMP_Text _classText;

	private Animator _interfaceAnimator;

	private int _selectedHeroIndex;

	private ScriptableHero _selectedHero;

	private void Awake()
	{
		throw null;
	}

	public void IterateCreationHeroIndex(int amount)
	{
		throw null;
	}

	private void SetCreationHero()
	{
		throw null;
	}

	public void OnHeroNameInputChanged(string text)
	{
		throw null;
	}

	public void CreatePressed()
	{
		throw null;
	}

	public void BackToSelect()
	{
		throw null;
	}

	public CreateManager()
	{
		throw null;
	}
}
