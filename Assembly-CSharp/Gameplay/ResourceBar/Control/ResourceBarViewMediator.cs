using System;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Gameplay.ResourceBar.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.ResourceBar.Control
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	public class ResourceBarViewMediator : AbstractCozyViewMediator<ResourceBarModel, ResourceBarEvents, ResourceBarController, ResourceBarView>
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x7249", Offset = "0x7249", VA = "0x7249")]
		public ResourceBarViewMediator(ResourceBarModel model, ResourceBarEvents events, ResourceBarController controller)
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x724A", Offset = "0x724A", VA = "0x724A", Slot = "21")]
		protected override void ResetEvents(ResourceBarEvents events)
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x724B", Offset = "0x724B", VA = "0x724B", Slot = "22")]
		protected override void SetupEvents(ResourceBarEvents events)
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x724C", Offset = "0x724C", VA = "0x724C", Slot = "23")]
		protected override void ResetView(ResourceBarView view)
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x724D", Offset = "0x724D", VA = "0x724D", Slot = "24")]
		protected override void SetupView(ResourceBarView view)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x724E", Offset = "0x724E", VA = "0x724E")]
		private void HandlePopupStateChangedEvent(int visiblefullscreenwndcount)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x724F", Offset = "0x724F", VA = "0x724F")]
		private void HandleGameObjectIsEnableChangedEvent(bool value)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x7250", Offset = "0x7250", VA = "0x7250")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x7251", Offset = "0x7251", VA = "0x7251")]
		private void ViewOnClickOnResourceViewEvent(Resources resourceId)
		{
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x7252", Offset = "0x7252", VA = "0x7252")]
		private void ViewOnOnDisable()
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x7253", Offset = "0x7253", VA = "0x7253")]
		private void ViewOnOnEnable()
		{
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x7254", Offset = "0x7254", VA = "0x7254")]
		private void DisplayBalance()
		{
		}
	}
}
