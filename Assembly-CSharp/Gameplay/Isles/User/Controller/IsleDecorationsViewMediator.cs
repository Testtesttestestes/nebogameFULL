using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D37 RID: 3383
	[Token(Token = "0x2000D37")]
	public class IsleDecorationsViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleDecorationsView>
	{
		// Token: 0x060052BD RID: 21181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BD")]
		[Address(RVA = "0xA093", Offset = "0xA093", VA = "0xA093")]
		public IsleDecorationsViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010DD RID: 4317
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DD")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052BE")]
			[Address(RVA = "0xA094", Offset = "0xA094", VA = "0xA094", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BF")]
		[Address(RVA = "0xA095", Offset = "0xA095", VA = "0xA095")]
		private void DecorationRemovedEvent(uint decorationId)
		{
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0xA096", Offset = "0xA096", VA = "0xA096")]
		private void DecorationAddedEvent(uint decorationId)
		{
		}

		// Token: 0x170010DE RID: 4318
		// (set) Token: 0x060052C1 RID: 21185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DE")]
		public override IsleDecorationsView View
		{
			[Token(Token = "0x60052C1")]
			[Address(RVA = "0xA097", Offset = "0xA097", VA = "0xA097", Slot = "20")]
			set
			{
			}
		}
	}
}
