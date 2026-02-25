using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D0 RID: 4560
	[Token(Token = "0x20011D0")]
	public class CaveBuilding : AbstractPathNode
	{
		// Token: 0x06006C99 RID: 27801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C99")]
		[Address(RVA = "0xB785", Offset = "0xB785", VA = "0xB785", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0xB786", Offset = "0xB786", VA = "0xB786", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0xB787", Offset = "0xB787", VA = "0xB787", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0xB788", Offset = "0xB788", VA = "0xB788")]
		public CaveBuilding()
		{
		}
	}
}
