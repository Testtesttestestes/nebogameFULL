using System;
using System.Threading;
using Gameplay.Antiq.Model;
using Gameplay.Antiq.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x2000D9A")]
	internal class GroupListViewMediator : AbstractCozyViewMediator<AntiqModel, AntiqEvents, AntiqController, GroupListView>
	{
		// Token: 0x06005523 RID: 21795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005523")]
		[Address(RVA = "0xA2C6", Offset = "0xA2C6", VA = "0xA2C6", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x1E5E", Offset = "0x1E5E", VA = "0x1E5E")]
		public GroupListViewMediator(GroupListView view, AntiqModel model, AntiqEvents events, AntiqController controller)
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005525")]
		[Address(RVA = "0xA2C7", Offset = "0xA2C7", VA = "0xA2C7", Slot = "21")]
		protected override void ResetEvents(AntiqEvents events)
		{
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005526")]
		[Address(RVA = "0xA2C8", Offset = "0xA2C8", VA = "0xA2C8", Slot = "22")]
		protected override void SetupEvents(AntiqEvents events)
		{
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005527")]
		[Address(RVA = "0xA2C9", Offset = "0xA2C9", VA = "0xA2C9", Slot = "23")]
		protected override void ResetView(GroupListView view)
		{
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005528")]
		[Address(RVA = "0xA2CA", Offset = "0xA2CA", VA = "0xA2CA", Slot = "24")]
		protected override void SetupView(GroupListView view)
		{
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005529")]
		[Address(RVA = "0xA2CB", Offset = "0xA2CB", VA = "0xA2CB")]
		private void HandleListSelectEvent(GroupData data)
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552A")]
		[Address(RVA = "0xA2CC", Offset = "0xA2CC", VA = "0xA2CC")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552B")]
		[Address(RVA = "0xA2CD", Offset = "0xA2CD", VA = "0xA2CD")]
		private void HandleSearchInputChangedEvent(string value)
		{
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552C")]
		[Address(RVA = "0xA2CE", Offset = "0xA2CE", VA = "0xA2CE")]
		private void HandleToggleChangeEvent()
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552D")]
		[Address(RVA = "0xA2CF", Offset = "0xA2CF", VA = "0xA2CF")]
		private void HandleTabChangeEvent()
		{
		}

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x18")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}
}
