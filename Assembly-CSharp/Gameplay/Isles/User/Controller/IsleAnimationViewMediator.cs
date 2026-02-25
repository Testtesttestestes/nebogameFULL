using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D35 RID: 3381
	[Token(Token = "0x2000D35")]
	public class IsleAnimationViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleAnimationsView>
	{
		// Token: 0x060052AE RID: 21166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AE")]
		[Address(RVA = "0xA084", Offset = "0xA084", VA = "0xA084")]
		public IsleAnimationViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010DA RID: 4314
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DA")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052AF")]
			[Address(RVA = "0xA085", Offset = "0xA085", VA = "0xA085", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B0")]
		[Address(RVA = "0xA086", Offset = "0xA086", VA = "0xA086")]
		private void AnimationStartedEvent(uint animationId)
		{
		}
	}
}
