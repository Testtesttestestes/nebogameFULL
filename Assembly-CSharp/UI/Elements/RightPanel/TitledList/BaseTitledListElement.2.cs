using System;
using Il2CppDummyDll;

namespace UI.Elements.RightPanel.TitledList
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	public abstract class BaseTitledListElement<T> : BaseTitledListElement where T : BaseTitledListElementArgs
	{
		// Token: 0x06000D18 RID: 3352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D18")]
		public override Type GetArgsType()
		{
			return null;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D19")]
		protected override void OnInit(BaseTitledListElementArgs args)
		{
		}

		// Token: 0x06000D1A RID: 3354
		[Token(Token = "0x6000D1A")]
		protected abstract void OnInit(T args);

		// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1B")]
		protected BaseTitledListElement()
		{
		}
	}
}
