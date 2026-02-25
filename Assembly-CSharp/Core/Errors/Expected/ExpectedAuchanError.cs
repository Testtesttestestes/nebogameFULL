using System;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x02001041 RID: 4161
	[Token(Token = "0x2001041")]
	public class ExpectedAuchanError : ExpectedDefaultError
	{
		// Token: 0x060061FC RID: 25084 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0xAE27", Offset = "0xAE27", VA = "0xAE27", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0xAE28", Offset = "0xAE28", VA = "0xAE28")]
		private void ShowNoTradeAccountDialogWindow(ExpectedAuchanError.ErrorArgs args)
		{
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0xAE29", Offset = "0xAE29", VA = "0xAE29")]
		public DialogWindow ShowActionIsOverWindow()
		{
			return null;
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0xAE2A", Offset = "0xAE2A", VA = "0xAE2A")]
		public ExpectedAuchanError()
		{
		}

		// Token: 0x02001042 RID: 4162
		[Token(Token = "0x2001042")]
		internal class ErrorArgs
		{
			// Token: 0x06006200 RID: 25088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006200")]
			[Address(RVA = "0xAE2B", Offset = "0xAE2B", VA = "0xAE2B")]
			public ErrorArgs(UserData user, AccountsManager accountsManager, ArtifactData artifactData)
			{
			}

			// Token: 0x040034CF RID: 13519
			[Token(Token = "0x40034CF")]
			[FieldOffset(Offset = "0x8")]
			public readonly UserData User;

			// Token: 0x040034D0 RID: 13520
			[Token(Token = "0x40034D0")]
			[FieldOffset(Offset = "0xC")]
			public readonly AccountsManager AccountsManager;

			// Token: 0x040034D1 RID: 13521
			[Token(Token = "0x40034D1")]
			[FieldOffset(Offset = "0x10")]
			public readonly ArtifactData ArtifactData;
		}
	}
}
