using System;
using Core.Data;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D2F RID: 3375
	[Token(Token = "0x2000D2F")]
	public class ColossusOnUserIsleViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, ColossusOnUserIsleView>
	{
		// Token: 0x0600528F RID: 21135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528F")]
		[Address(RVA = "0xA065", Offset = "0xA065", VA = "0xA065")]
		public ColossusOnUserIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010D6 RID: 4310
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D6")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005290")]
			[Address(RVA = "0xA066", Offset = "0xA066", VA = "0xA066", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (set) Token: 0x06005291 RID: 21137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D7")]
		public override ColossusOnUserIsleView View
		{
			[Token(Token = "0x6005291")]
			[Address(RVA = "0xA067", Offset = "0xA067", VA = "0xA067", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005292")]
		[Address(RVA = "0xA068", Offset = "0xA068", VA = "0xA068")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005293")]
		[Address(RVA = "0xA069", Offset = "0xA069", VA = "0xA069")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005294")]
		[Address(RVA = "0xA06A", Offset = "0xA06A", VA = "0xA06A")]
		private void RenderColossus()
		{
		}
	}
}
