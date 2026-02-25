using System;
using Core.Gameplay.Managers;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using ServicesNamespace;
using Utils;

namespace Gameplay.RegisterV2.Control
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public class RegisterController : AbstractController<RegisterModel, RegisterEvents>, IRegistration
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x72C3", Offset = "0x72C3", VA = "0x72C3")]
		public RegisterController(RegisterModel model, RegisterEvents events)
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x72C4", Offset = "0x72C4", VA = "0x72C4", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x72C5", Offset = "0x72C5", VA = "0x72C5")]
		private void PrepareData()
		{
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x72C6", Offset = "0x72C6", VA = "0x72C6")]
		private void OnNickGenerated(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002168")]
		[Address(RVA = "0x72C7", Offset = "0x72C7", VA = "0x72C7")]
		private void RequestPossibleNicks(string nick, Action<OpToken<IMessage, object>> callback)
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002169")]
		[Address(RVA = "0x72C8", Offset = "0x72C8", VA = "0x72C8")]
		public void GenerateNick()
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216A")]
		[Address(RVA = "0x72C9", Offset = "0x72C9", VA = "0x72C9")]
		public void SetNick(string nick)
		{
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216B")]
		[Address(RVA = "0x72CA", Offset = "0x72CA", VA = "0x72CA")]
		public void Register()
		{
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x600216C")]
		[Address(RVA = "0x72CB", Offset = "0x72CB", VA = "0x72CB")]
		private bool TryRequestRegisterProcessing(string nick, uint aprId)
		{
			return default(bool);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216D")]
		[Address(RVA = "0x72CC", Offset = "0x72CC", VA = "0x72CC")]
		private void OnRegisterResult(LoggedManager.RegisterCallbackInvoker invoker, RegisterCmd.Types.Ans msg)
		{
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x72CD", Offset = "0x72CD", VA = "0x72CD", Slot = "13")]
		public void HandleRegisterResult(RegisterCmd.Types.Result result)
		{
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600216F")]
		[Address(RVA = "0x72CE", Offset = "0x72CE", VA = "0x72CE")]
		private void HandleInvalidNickError(RegisterCmd.Types.Result result)
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002170")]
		[Address(RVA = "0x72CF", Offset = "0x72CF", VA = "0x72CF", Slot = "14")]
		public void Complete()
		{
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x72D0", Offset = "0x72D0", VA = "0x72D0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x18")]
		private Auth2Service _authService;
	}
}
