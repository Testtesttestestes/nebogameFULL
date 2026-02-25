using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CF RID: 4559
	[Token(Token = "0x20011CF")]
	public class BossList : AbstractPathNode
	{
		// Token: 0x06006C96 RID: 27798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C96")]
		[Address(RVA = "0xB782", Offset = "0xB782", VA = "0xB782", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C97")]
		[Address(RVA = "0xB783", Offset = "0xB783", VA = "0xB783", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C98")]
		[Address(RVA = "0xB784", Offset = "0xB784", VA = "0xB784")]
		public BossList()
		{
		}
	}
}
