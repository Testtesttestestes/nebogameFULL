using System;
using Gameplay.ThemeDuelState.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Themeduel;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuelState.Control
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	public class ThemeDuelStateController : AbstractController<ThemeDuelStateModel, ThemeDuelStateEvents>
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x6EE7", Offset = "0x6EE7", VA = "0x6EE7")]
		public ThemeDuelStateController(ThemeDuelStateModel model, ThemeDuelStateEvents events)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x6EE8", Offset = "0x6EE8", VA = "0x6EE8", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x6EE9", Offset = "0x6EE9", VA = "0x6EE9", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x6EEA", Offset = "0x6EEA", VA = "0x6EEA")]
		private void RequestState()
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x6EEB", Offset = "0x6EEB", VA = "0x6EEB")]
		private void HandleGetThemeDuelStateService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x6EEC", Offset = "0x6EEC", VA = "0x6EEC")]
		private void HandleStateChangedEvent(ProtoThemeDuelStateChangedEvt evt)
		{
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x6EED", Offset = "0x6EED", VA = "0x6EED")]
		public void HandleBalanceChangedEvent(ProtoUserScoreChangedEvt evt)
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x6EEE", Offset = "0x6EEE", VA = "0x6EEE")]
		public void HandleEntryAttemptChangedEvent(ProtoUserEntryAttempsChangedEvt evt)
		{
		}

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThemeDuelService _themeDuelService;
	}
}
