using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D3 RID: 4563
	[Token(Token = "0x20011D3")]
	public class Collections : AbstractPathNode
	{
		// Token: 0x06006CA5 RID: 27813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0xB791", Offset = "0xB791", VA = "0xB791", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0xB792", Offset = "0xB792", VA = "0xB792", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA7")]
		[Address(RVA = "0xB793", Offset = "0xB793", VA = "0xB793")]
		public Collections()
		{
		}
	}
}
