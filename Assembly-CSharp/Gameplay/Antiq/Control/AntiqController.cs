using System;
using Gameplay.Antiq.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	internal class AntiqController : AbstractController<AntiqModel, AntiqEvents>
	{
		// Token: 0x0600550D RID: 21773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550D")]
		[Address(RVA = "0xA2B1", Offset = "0xA2B1", VA = "0xA2B1")]
		public AntiqController(AntiqModel model, AntiqEvents events, MainService mainService)
		{
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550E")]
		[Address(RVA = "0xA2B2", Offset = "0xA2B2", VA = "0xA2B2")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550F")]
		[Address(RVA = "0xA2B3", Offset = "0xA2B3", VA = "0xA2B3", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005510")]
		[Address(RVA = "0xA2B4", Offset = "0xA2B4", VA = "0xA2B4")]
		private void CreateEntities()
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005511")]
		[Address(RVA = "0xA2B5", Offset = "0xA2B5", VA = "0xA2B5")]
		private void SetUserArtifacts(ProtoGetUserAnitiqArtifactsAns msg)
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005512")]
		[Address(RVA = "0xA2B6", Offset = "0xA2B6", VA = "0xA2B6")]
		private void RequestUpdateUserArtifacts()
		{
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005513")]
		[Address(RVA = "0xA2B7", Offset = "0xA2B7", VA = "0xA2B7")]
		private void HandleGetUserAntiqArtifactsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005514")]
		[Address(RVA = "0xA2B8", Offset = "0xA2B8", VA = "0xA2B8")]
		private void SetCurrentArtifact(ArtifactData artifact)
		{
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005515")]
		[Address(RVA = "0x1F40", Offset = "0x1F40", VA = "0x1F40")]
		public void SetCurrentGroup(GroupData group)
		{
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005516")]
		[Address(RVA = "0xA2B9", Offset = "0xA2B9", VA = "0xA2B9")]
		public void SelectGroupNext(GroupData group)
		{
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005517")]
		[Address(RVA = "0xA2BA", Offset = "0xA2BA", VA = "0xA2BA")]
		public void SelectGroupBack(GroupData group)
		{
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005518")]
		[Address(RVA = "0xA2BB", Offset = "0xA2BB", VA = "0xA2BB")]
		public void SelectArtifactNext(ArtifactData artifact)
		{
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005519")]
		[Address(RVA = "0xA2BC", Offset = "0xA2BC", VA = "0xA2BC")]
		public void SelectArtifactBack(ArtifactData artifact)
		{
		}

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x18")]
		private readonly MainService _mainService;
	}
}
