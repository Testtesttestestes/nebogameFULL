using System;
using Gameplay.Antiq.Model;
using Gameplay.Antiq.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x2000D9D")]
	internal class GroupReviewViewMediator : AbstractCozyViewMediator<AntiqModel, AntiqEvents, AntiqController, GroupReviewView>
	{
		// Token: 0x06005533 RID: 21811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005533")]
		[Address(RVA = "0xA2D4", Offset = "0xA2D4", VA = "0xA2D4")]
		public GroupReviewViewMediator(GroupReviewView view, AntiqModel model, AntiqEvents events, AntiqController controller)
		{
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005534")]
		[Address(RVA = "0xA2D5", Offset = "0xA2D5", VA = "0xA2D5", Slot = "21")]
		protected override void ResetEvents(AntiqEvents events)
		{
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005535")]
		[Address(RVA = "0xA2D6", Offset = "0xA2D6", VA = "0xA2D6", Slot = "22")]
		protected override void SetupEvents(AntiqEvents events)
		{
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005536")]
		[Address(RVA = "0xA2D7", Offset = "0xA2D7", VA = "0xA2D7", Slot = "23")]
		protected override void ResetView(GroupReviewView view)
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005537")]
		[Address(RVA = "0xA2D8", Offset = "0xA2D8", VA = "0xA2D8", Slot = "24")]
		protected override void SetupView(GroupReviewView view)
		{
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005538")]
		[Address(RVA = "0xA2D9", Offset = "0xA2D9", VA = "0xA2D9")]
		private void HandleCurrentGroupChangedEvent(GroupData data)
		{
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005539")]
		[Address(RVA = "0xA2DA", Offset = "0xA2DA", VA = "0xA2DA")]
		private void HandleCurrentArtifactChangedEvent(ArtifactData data)
		{
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553A")]
		[Address(RVA = "0xA2DB", Offset = "0xA2DB", VA = "0xA2DB")]
		private void HandleArtifactListNext()
		{
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553B")]
		[Address(RVA = "0xA2DC", Offset = "0xA2DC", VA = "0xA2DC")]
		private void HandleArtifactListBack()
		{
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553C")]
		[Address(RVA = "0xA2DD", Offset = "0xA2DD", VA = "0xA2DD")]
		private void HandleGroupListNext()
		{
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553D")]
		[Address(RVA = "0xA2DE", Offset = "0xA2DE", VA = "0xA2DE")]
		private void HandleGroupListBack()
		{
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553E")]
		[Address(RVA = "0xA2DF", Offset = "0xA2DF", VA = "0xA2DF")]
		private void DisplayGroup(GroupData data)
		{
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553F")]
		[Address(RVA = "0xA2E0", Offset = "0xA2E0", VA = "0xA2E0")]
		private void DisplayEffect(ArtifactData artifact)
		{
		}
	}
}
