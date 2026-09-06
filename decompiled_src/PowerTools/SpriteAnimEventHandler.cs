using UnityEngine;

namespace PowerTools;

public class SpriteAnimEventHandler : MonoBehaviour
{
	public static class EventParser
	{
		public static readonly char MESSAGE_DELIMITER;

		public static readonly string MESSAGE_NOPARAM;

		public static readonly string MESSAGE_INT;

		public static readonly string MESSAGE_FLOAT;

		public static readonly string MESSAGE_STRING;

		public static readonly string MESSAGE_OBJECT_FUNCNAME;

		public static readonly string MESSAGE_OBJECT_DATA;

		public static int ParseInt(ref string messageString)
		{
			throw null;
		}

		public static float ParseFloat(ref string messageString)
		{
			throw null;
		}

		public static string ParseString(ref string messageString)
		{
			throw null;
		}

		static EventParser()
		{
			throw null;
		}
	}

	private string m_eventWithObjectMessage;

	private object m_eventWithObjectData;

	private void _Anim(string function)
	{
		throw null;
	}

	private void _AnimInt(string messageString)
	{
		throw null;
	}

	private void _AnimFloat(string messageString)
	{
		throw null;
	}

	private void _AnimString(string messageString)
	{
		throw null;
	}

	private void _AnimObjectFunc(string funcName)
	{
		throw null;
	}

	private void _AnimObjectData(Object data)
	{
		throw null;
	}

	public SpriteAnimEventHandler()
	{
		throw null;
	}
}
