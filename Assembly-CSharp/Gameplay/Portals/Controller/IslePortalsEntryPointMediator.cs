using System;
using Gameplay.Isles.User;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	public class IslePortalsEntryPointMediator : AbstractViewMediator<PortalsModel, PortalsEvents, PortalsController, PortalsEntryPointView>
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x7554", Offset = "0x7554", VA = "0x7554")]
		public IslePortalsEntryPointMediator(PortalsModel model, PortalsEvents events, PortalsController controller, UserIsle isle)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CE")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002404")]
			[Address(RVA = "0x7555", Offset = "0x7555", VA = "0x7555", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CF")]
		public override PortalsEntryPointView View
		{
			[Token(Token = "0x6002405")]
			[Address(RVA = "0x7556", Offset = "0x7556", VA = "0x7556", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x7557", Offset = "0x7557", VA = "0x7557")]
		private void ResetView()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x7558", Offset = "0x7558", VA = "0x7558")]
		private void SetupView()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x7559", Offset = "0x7559", VA = "0x7559")]
		private void PortalStateChangedHandler()
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x755A", Offset = "0x755A", VA = "0x755A")]
		private void OnPortalClick()
		{
		}

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x18")]
		private readonly UserIsle _isle;
	}
}
