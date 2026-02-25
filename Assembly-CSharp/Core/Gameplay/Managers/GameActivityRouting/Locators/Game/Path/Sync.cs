using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E4 RID: 4580
	[Token(Token = "0x20011E4")]
	public class Sync : AbstractPathNode
	{
		// Token: 0x06006CDD RID: 27869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0xB7C9", Offset = "0xB7C9", VA = "0xB7C9", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDE")]
		[Address(RVA = "0xB7CA", Offset = "0xB7CA", VA = "0xB7CA", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0xB7CB", Offset = "0xB7CB", VA = "0xB7CB")]
		public Sync()
		{
		}
	}
}
