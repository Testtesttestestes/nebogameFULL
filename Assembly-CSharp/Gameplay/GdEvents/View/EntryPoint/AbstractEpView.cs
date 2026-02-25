using System;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.GdEvents.View.EntryPoint
{
	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	public abstract class AbstractEpView : MonoBehaviour
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000889")]
		public MonoPointerClickHandler ClickHandler
		{
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0x7D05", Offset = "0x7D05", VA = "0x7D05")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x7D06", Offset = "0x7D06", VA = "0x7D06")]
		protected AbstractEpView()
		{
		}

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;
	}
}
