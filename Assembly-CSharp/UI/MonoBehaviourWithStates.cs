using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class MonoBehaviourWithStates<T> : MonoBehaviour where T : Enum, new()
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010B")]
		protected MonoBehaviourWithStates<T>.Config[] Configs
		{
			[Token(Token = "0x600085E")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000CB RID: 203
		// (add) Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CB")]
		public event MonoBehaviourWithStates<T>.ClientStateChangedDelegate CurrentStateChangedEvent
		{
			[Token(Token = "0x600085F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public T CurrentState
		{
			[Token(Token = "0x6000861")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			set
			{
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		protected virtual void HandleCurrentStateChanged(T fromState, T toState)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		public MonoBehaviourWithStates()
		{
		}

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private MonoBehaviourWithStates<T>.Config[] _gameObjectsByStates;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		private T _currentState;

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		[Serializable]
		public class Config
		{
			// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000865")]
			public Config()
			{
			}

			// Token: 0x040002FD RID: 765
			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x0")]
			public GameObject GameObject;

			// Token: 0x040002FE RID: 766
			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x0")]
			public T[] VisibleStates;
		}

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000867 RID: 2151
		[Token(Token = "0x2000101")]
		public delegate void ClientStateChangedDelegate(T fromState, T toState);
	}
}
