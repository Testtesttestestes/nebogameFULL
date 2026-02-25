using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E3 RID: 4579
	[Token(Token = "0x20011E3")]
	public class SaveProgress : AbstractPathNode
	{
		// Token: 0x06006CDA RID: 27866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0xB7C6", Offset = "0xB7C6", VA = "0xB7C6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0xB7C7", Offset = "0xB7C7", VA = "0xB7C7", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0xB7C8", Offset = "0xB7C8", VA = "0xB7C8")]
		public SaveProgress()
		{
		}
	}
}
