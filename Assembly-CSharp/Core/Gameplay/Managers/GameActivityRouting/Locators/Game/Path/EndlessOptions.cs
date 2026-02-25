using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D8 RID: 4568
	[Token(Token = "0x20011D8")]
	internal class EndlessOptions : AbstractPathNode
	{
		// Token: 0x06006CB4 RID: 27828 RVA: 0x00014088 File Offset: 0x00012288
		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0xB7A0", Offset = "0xB7A0", VA = "0xB7A0", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0xB7A1", Offset = "0xB7A1", VA = "0xB7A1", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0xB7A2", Offset = "0xB7A2", VA = "0xB7A2", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0xB7A3", Offset = "0xB7A3", VA = "0xB7A3")]
		public EndlessOptions()
		{
		}
	}
}
