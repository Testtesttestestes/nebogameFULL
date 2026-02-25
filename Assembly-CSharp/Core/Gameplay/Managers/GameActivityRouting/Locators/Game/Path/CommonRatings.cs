using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D4 RID: 4564
	[Token(Token = "0x20011D4")]
	public class CommonRatings : AbstractPathNode
	{
		// Token: 0x06006CA8 RID: 27816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA8")]
		[Address(RVA = "0xB794", Offset = "0xB794", VA = "0xB794", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA9")]
		[Address(RVA = "0xB795", Offset = "0xB795", VA = "0xB795", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAA")]
		[Address(RVA = "0xB796", Offset = "0xB796", VA = "0xB796")]
		public CommonRatings()
		{
		}
	}
}
