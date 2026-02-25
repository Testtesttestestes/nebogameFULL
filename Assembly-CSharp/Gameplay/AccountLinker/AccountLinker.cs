using System;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;

namespace Gameplay.AccountLinker
{
	// Token: 0x02000DF2 RID: 3570
	[Token(Token = "0x2000DF2")]
	public class AccountLinker : AccountLinkerController
	{
		// Token: 0x06005727 RID: 22311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005727")]
		[Address(RVA = "0xA4A2", Offset = "0xA4A2", VA = "0xA4A2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005728")]
		[Address(RVA = "0xA4A3", Offset = "0xA4A3", VA = "0xA4A3")]
		public AccountLinker(AccountLinkerModel model, AccountLinkerEvents events)
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005729")]
		[Address(RVA = "0xA4A4", Offset = "0xA4A4", VA = "0xA4A4", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572A")]
		[Address(RVA = "0xA4A5", Offset = "0xA4A5", VA = "0xA4A5", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572B")]
		[Address(RVA = "0xA4A6", Offset = "0xA4A6", VA = "0xA4A6")]
		private void HandleSetUserSuccessEvent()
		{
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572C")]
		[Address(RVA = "0xA4A7", Offset = "0xA4A7", VA = "0xA4A7")]
		private void HandleStartResolveAdditionalUsersEvent()
		{
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572D")]
		[Address(RVA = "0xA4A8", Offset = "0xA4A8", VA = "0xA4A8")]
		private void ShowSelectUserWindow()
		{
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572E")]
		[Address(RVA = "0xA4A9", Offset = "0xA4A9", VA = "0xA4A9")]
		private void HandleOnCloseSelectUserWindow()
		{
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572F")]
		[Address(RVA = "0xA4AA", Offset = "0xA4AA", VA = "0xA4AA")]
		private void CloseSelectUserWindow()
		{
		}

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x24")]
		private SelectUserWindow _selectUserWindow;
	}
}
