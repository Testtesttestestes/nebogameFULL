using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D2E RID: 3374
	[Token(Token = "0x2000D2E")]
	public class BackClanIsleViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, BackClanIsleView>
	{
		// Token: 0x06005287 RID: 21127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005287")]
		[Address(RVA = "0xA05D", Offset = "0xA05D", VA = "0xA05D")]
		public BackClanIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010D4 RID: 4308
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D4")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005288")]
			[Address(RVA = "0xA05E", Offset = "0xA05E", VA = "0xA05E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (set) Token: 0x06005289 RID: 21129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D5")]
		public override BackClanIsleView View
		{
			[Token(Token = "0x6005289")]
			[Address(RVA = "0xA05F", Offset = "0xA05F", VA = "0xA05F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528A")]
		[Address(RVA = "0xA060", Offset = "0xA060", VA = "0xA060")]
		private void RenderIsle()
		{
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528B")]
		[Address(RVA = "0xA061", Offset = "0xA061", VA = "0xA061")]
		private void ViewOnClickEvent()
		{
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528C")]
		[Address(RVA = "0xA062", Offset = "0xA062", VA = "0xA062")]
		private void HandleDisposeEvent()
		{
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528D")]
		[Address(RVA = "0xA063", Offset = "0xA063", VA = "0xA063")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528E")]
		[Address(RVA = "0xA064", Offset = "0xA064", VA = "0xA064", Slot = "14")]
		public override void Dispose()
		{
		}
	}
}
