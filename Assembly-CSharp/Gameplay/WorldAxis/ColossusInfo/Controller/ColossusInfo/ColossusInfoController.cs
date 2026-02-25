using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Dic;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	public class ColossusInfoController : AbstractController<ColossusInfoModel, ColossusInfoEvents>
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x64C2", Offset = "0x64C2", VA = "0x64C2")]
		public ColossusInfoController(ColossusInfoModel model, ColossusInfoEvents events)
		{
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x64C3", Offset = "0x64C3", VA = "0x64C3", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x64C4", Offset = "0x64C4", VA = "0x64C4", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x64C5", Offset = "0x64C5", VA = "0x64C5")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x64C6", Offset = "0x64C6", VA = "0x64C6")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x64C7", Offset = "0x64C7", VA = "0x64C7")]
		private void GetColossusRating()
		{
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x64C8", Offset = "0x64C8", VA = "0x64C8")]
		private void GetColossusRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x64C9", Offset = "0x64C9", VA = "0x64C9")]
		public bool TryRunCombat(ColossusDic colossus)
		{
			return default(bool);
		}

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x18")]
		private readonly ColossusService _colossusService;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClansService _clansService;
	}
}
