using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E6 RID: 4582
	[Token(Token = "0x20011E6")]
	public class TreeBuilding : AbstractPathNode
	{
		// Token: 0x06006CE3 RID: 27875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE3")]
		[Address(RVA = "0xB7CF", Offset = "0xB7CF", VA = "0xB7CF", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x6006CE4")]
		[Address(RVA = "0xB7D0", Offset = "0xB7D0", VA = "0xB7D0", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE5")]
		[Address(RVA = "0xB7D1", Offset = "0xB7D1", VA = "0xB7D1", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0xB7D2", Offset = "0xB7D2", VA = "0xB7D2")]
		public TreeBuilding()
		{
		}
	}
}
