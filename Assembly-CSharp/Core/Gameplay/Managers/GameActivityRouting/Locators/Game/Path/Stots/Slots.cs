using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Stots
{
	// Token: 0x020011E9 RID: 4585
	[Token(Token = "0x20011E9")]
	public class Slots : AbstractPathNode
	{
		// Token: 0x06006CED RID: 27885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CED")]
		[Address(RVA = "0xB7D9", Offset = "0xB7D9", VA = "0xB7D9", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEE")]
		[Address(RVA = "0xB7DA", Offset = "0xB7DA", VA = "0xB7DA", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0xB7DB", Offset = "0xB7DB", VA = "0xB7DB")]
		public Slots()
		{
		}
	}
}
