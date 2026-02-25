using System;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	[Serializable]
	public class RankImages
	{
		// Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x87E9", Offset = "0x87E9", VA = "0x87E9")]
		public RankImages()
		{
		}

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x8")]
		public RankTypes Rank;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[FieldOffset(Offset = "0xC")]
		public Image Image;
	}
}
