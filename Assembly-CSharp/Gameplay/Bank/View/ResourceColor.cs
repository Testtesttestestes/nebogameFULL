using System;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3E RID: 3134
	[Token(Token = "0x2000C3E")]
	[Serializable]
	public class ResourceColor
	{
		// Token: 0x06004C5D RID: 19549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x9A9E", Offset = "0x9A9E", VA = "0x9A9E")]
		public ResourceColor()
		{
		}

		// Token: 0x040029AB RID: 10667
		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x8")]
		public Protocol.Consts.Resources ResourceId;

		// Token: 0x040029AC RID: 10668
		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0xC")]
		public Color Color;
	}
}
