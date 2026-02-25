using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E5 RID: 4581
	[Token(Token = "0x20011E5")]
	public class Tournaments : AbstractPathNode
	{
		// Token: 0x06006CE0 RID: 27872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE0")]
		[Address(RVA = "0xB7CC", Offset = "0xB7CC", VA = "0xB7CC", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE1")]
		[Address(RVA = "0xB7CD", Offset = "0xB7CD", VA = "0xB7CD", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE2")]
		[Address(RVA = "0xB7CE", Offset = "0xB7CE", VA = "0xB7CE")]
		public Tournaments()
		{
		}
	}
}
