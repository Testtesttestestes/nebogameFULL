using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E8 RID: 4584
	[Token(Token = "0x20011E8")]
	public class VortexInfo : AbstractPathNode
	{
		// Token: 0x06006CEA RID: 27882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEA")]
		[Address(RVA = "0xB7D6", Offset = "0xB7D6", VA = "0xB7D6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEB")]
		[Address(RVA = "0xB7D7", Offset = "0xB7D7", VA = "0xB7D7", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEC")]
		[Address(RVA = "0xB7D8", Offset = "0xB7D8", VA = "0xB7D8")]
		public VortexInfo()
		{
		}
	}
}
