using System;
using Core.Data;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class AuchanController : AbstractController<AuchanModel, AuchanEvents>
	{
		// Token: 0x06004E92 RID: 20114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x9CC3", Offset = "0x9CC3", VA = "0x9CC3")]
		public AuchanController(AuchanService service, AuchanModel model, AuchanEvents events)
		{
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x9CC4", Offset = "0x9CC4", VA = "0x9CC4", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x9CC5", Offset = "0x9CC5", VA = "0x9CC5")]
		public bool TryStartBuyAndEquip(ArtifactData item)
		{
			return default(bool);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x9CC6", Offset = "0x9CC6", VA = "0x9CC6")]
		public bool TryStartBuy(ArtifactData item)
		{
			return default(bool);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x9CC7", Offset = "0x9CC7", VA = "0x9CC7")]
		private bool TryStartBuy(ArtifactData item, uint? slotId)
		{
			return default(bool);
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x9CC8", Offset = "0x9CC8", VA = "0x9CC8")]
		private void BuyAuchanItemHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E98")]
		[Address(RVA = "0x9CC9", Offset = "0x9CC9", VA = "0x9CC9")]
		private void GetAuchanItemsInfo()
		{
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x9CCA", Offset = "0x9CCA", VA = "0x9CCA")]
		private void GetAuchanItemsInfoSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x9CCB", Offset = "0x9CCB", VA = "0x9CCB")]
		private void ValidateInit()
		{
		}

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x18")]
		private readonly AuchanService _service;
	}
}
