using System;
using Core.Data;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using UI.Rewards.Renderers;

namespace Gameplay.ArtifactDrop.Control
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public class ArtifactDropViewMediator : AbstractViewMediator<ArtifactDropModel, ArtifactDropEvents, ArtifactDropController, ArtifactRewardRender>
	{
		// Token: 0x06004FDA RID: 20442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x9DF3", Offset = "0x9DF3", VA = "0x9DF3")]
		public ArtifactDropViewMediator(ArtifactDropModel model, ArtifactDropEvents events, ArtifactDropController controller)
		{
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x9DF4", Offset = "0x9DF4", VA = "0x9DF4", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x17001029")]
		public DropTypes DropType
		{
			[Token(Token = "0x6004FDC")]
			[Address(RVA = "0x9DF5", Offset = "0x9DF5", VA = "0x9DF5")]
			get
			{
				return DropTypes.UnknownDropType;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102A")]
		public override ArtifactRewardRender View
		{
			[Token(Token = "0x6004FDD")]
			[Address(RVA = "0x9DF6", Offset = "0x9DF6", VA = "0x9DF6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x9DF7", Offset = "0x9DF7", VA = "0x9DF7")]
		private void HandleViewChanged()
		{
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDF")]
		[Address(RVA = "0x9DF8", Offset = "0x9DF8", VA = "0x9DF8")]
		private void HandleOnDropResetEvent(DropTypes dropType)
		{
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x9DF9", Offset = "0x9DF9", VA = "0x9DF9")]
		private void HandleOnArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifactData)
		{
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x9DFA", Offset = "0x9DFA", VA = "0x9DFA")]
		private void HandleOnReadyDropEvent(ArtifactDropModel.ArtifactDrop drop)
		{
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x9DFB", Offset = "0x9DFB", VA = "0x9DFB")]
		private void HandleClickSellAllBtn()
		{
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x9DFC", Offset = "0x9DFC", VA = "0x9DFC")]
		private void HandleClickGetAllBtn()
		{
		}
	}
}
