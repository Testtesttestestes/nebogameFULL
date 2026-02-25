using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	public class ImageWithStates<T> : MonoBehaviour where T : Enum
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AB")]
		public T CurrentState
		{
			[Token(Token = "0x6000CD6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CD7")]
			set
			{
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD8")]
		protected virtual void HandleCurrentStateChanged(T fromState, T toState)
		{
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD9")]
		public ImageWithStates()
		{
		}

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image _image;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ImageWithStates<T>.Config[] _sprites;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x0")]
		private T _currentState;

		// Token: 0x020001F2 RID: 498
		[Token(Token = "0x20001F2")]
		[Serializable]
		private class Config
		{
			// Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CDA")]
			public Config()
			{
			}

			// Token: 0x0400064B RID: 1611
			[Token(Token = "0x400064B")]
			[FieldOffset(Offset = "0x0")]
			public Sprite Sprite;

			// Token: 0x0400064C RID: 1612
			[Token(Token = "0x400064C")]
			[FieldOffset(Offset = "0x0")]
			public T State;
		}
	}
}
