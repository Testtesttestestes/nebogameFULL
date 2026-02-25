using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public abstract class BaseTitledListElement : MonoBehaviour
	{
		// Token: 0x06000D14 RID: 3348
		[Token(Token = "0x6000D14")]
		public abstract Type GetArgsType();

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x1DB9", Offset = "0x1DB9", VA = "0x1DB9")]
		public void Init(BaseTitledListElementArgs args)
		{
		}

		// Token: 0x06000D16 RID: 3350
		[Token(Token = "0x6000D16")]
		protected abstract void OnInit(BaseTitledListElementArgs args);

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x6009", Offset = "0x6009", VA = "0x6009")]
		protected BaseTitledListElement()
		{
		}
	}
}
