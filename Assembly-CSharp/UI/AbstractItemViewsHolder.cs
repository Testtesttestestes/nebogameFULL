using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public abstract class AbstractItemViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x0600089C RID: 2204
		[Token(Token = "0x600089C")]
		public abstract void SetData(GenericListElementArgs args);

		// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x5C2D", Offset = "0x5C2D", VA = "0x5C2D")]
		protected AbstractItemViewsHolder()
		{
		}
	}
}
