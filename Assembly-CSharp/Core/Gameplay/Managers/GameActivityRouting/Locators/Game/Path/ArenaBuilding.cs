using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CA RID: 4554
	[Token(Token = "0x20011CA")]
	public class ArenaBuilding : AbstractPathNode
	{
		// Token: 0x06006C86 RID: 27782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C86")]
		[Address(RVA = "0xB772", Offset = "0xB772", VA = "0xB772", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x00014058 File Offset: 0x00012258
		[Token(Token = "0x6006C87")]
		[Address(RVA = "0xB773", Offset = "0xB773", VA = "0xB773", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C88")]
		[Address(RVA = "0xB774", Offset = "0xB774", VA = "0xB774", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C89")]
		[Address(RVA = "0xB775", Offset = "0xB775", VA = "0xB775")]
		public ArenaBuilding()
		{
		}
	}
}
