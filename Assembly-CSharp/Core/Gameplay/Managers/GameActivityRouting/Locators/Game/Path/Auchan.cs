using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CB RID: 4555
	[Token(Token = "0x20011CB")]
	public class Auchan : AbstractPathNode
	{
		// Token: 0x06006C8A RID: 27786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8A")]
		[Address(RVA = "0xB776", Offset = "0xB776", VA = "0xB776", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8B")]
		[Address(RVA = "0xB777", Offset = "0xB777", VA = "0xB777", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8C")]
		[Address(RVA = "0xB778", Offset = "0xB778", VA = "0xB778")]
		public Auchan()
		{
		}
	}
}
