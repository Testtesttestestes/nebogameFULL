using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F9 RID: 2553
	[Token(Token = "0x20009F9")]
	public class ClanListElementArgs<TListElement> : SelectableListElementArgs<TListElement>
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD7")]
		public ClanListElementArgs()
		{
		}

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0x0")]
		public ClanData ClanData;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0x0")]
		public int Position;
	}
}
