using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DD RID: 4573
	[Token(Token = "0x20011DD")]
	public class MagicSchoolBuilding : AbstractPathNode
	{
		// Token: 0x06006CC6 RID: 27846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0xB7B2", Offset = "0xB7B2", VA = "0xB7B2", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x000140A0 File Offset: 0x000122A0
		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0xB7B3", Offset = "0xB7B3", VA = "0xB7B3", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC8")]
		[Address(RVA = "0xB7B4", Offset = "0xB7B4", VA = "0xB7B4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC9")]
		[Address(RVA = "0xB7B5", Offset = "0xB7B5", VA = "0xB7B5")]
		public MagicSchoolBuilding()
		{
		}
	}
}
