using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DA RID: 4570
	[Token(Token = "0x20011DA")]
	public class GuideSettings : AbstractPathNode
	{
		// Token: 0x06006CBB RID: 27835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0xB7A7", Offset = "0xB7A7", VA = "0xB7A7", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0xB7A8", Offset = "0xB7A8", VA = "0xB7A8", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0xB7A9", Offset = "0xB7A9", VA = "0xB7A9")]
		public GuideSettings()
		{
		}
	}
}
