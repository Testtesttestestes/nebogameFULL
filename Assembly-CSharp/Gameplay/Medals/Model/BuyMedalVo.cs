using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Gameplay.Medals.Model
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	public class BuyMedalVo
	{
		// Token: 0x06002541 RID: 9537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x768A", Offset = "0x768A", VA = "0x768A")]
		public BuyMedalVo(uint medalId, UniTaskCompletionSource<bool> completionSource)
		{
		}

		// Token: 0x04001467 RID: 5223
		[Token(Token = "0x4001467")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint MedalId;

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0xC")]
		public readonly UniTaskCompletionSource<bool> CompletionSource;
	}
}
