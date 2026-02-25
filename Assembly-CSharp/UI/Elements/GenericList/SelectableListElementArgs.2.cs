using System;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	public class SelectableListElementArgs<TListElement> : SelectableListElementArgs
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		public SelectableListElementArgs()
		{
		}

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x0")]
		public Action<TListElement> ListElementClickedEventHandler;
	}
}
