using System;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.ResourceBar.Control
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	public class ResourceBarController : AbstractController<ResourceBarModel, ResourceBarEvents>
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x7244", Offset = "0x7244", VA = "0x7244")]
		public ResourceBarController(ResourceBarModel model, ResourceBarEvents events)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x7245", Offset = "0x7245", VA = "0x7245", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x7246", Offset = "0x7246", VA = "0x7246", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x7247", Offset = "0x7247", VA = "0x7247")]
		private void PopupControllerOnOnChangeStateEvent(int visibleFullscreenWndCount)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x7248", Offset = "0x7248", VA = "0x7248")]
		private void UserOnOnUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}
	}
}
