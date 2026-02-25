using System;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model.ClanWars;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public class ClanWarsHistoryController : AbstractController<ClanWarsHistoryModel, ClanWarsHistoryEvents>
	{
		// Token: 0x06004039 RID: 16441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x8EF3", Offset = "0x8EF3", VA = "0x8EF3")]
		public ClanWarsHistoryController(ClanWarsHistoryModel model, ClanWarsHistoryEvents events)
		{
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403A")]
		[Address(RVA = "0x8EF4", Offset = "0x8EF4", VA = "0x8EF4", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x8EF5", Offset = "0x8EF5", VA = "0x8EF5", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x8EF6", Offset = "0x8EF6", VA = "0x8EF6")]
		private void ClanWarDeclaredEventHandler()
		{
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x8EF7", Offset = "0x8EF7", VA = "0x8EF7")]
		public void RequestWarsHistory(uint linesCount, uint previousWarId)
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x8EF8", Offset = "0x8EF8", VA = "0x8EF8")]
		private void GetWarsHistoryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x8EF9", Offset = "0x8EF9", VA = "0x8EF9")]
		public void RequestFirstWarsHistory(uint linesCount)
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x8EFA", Offset = "0x8EFA", VA = "0x8EFA")]
		private void GetFirstWarsHistoryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsService _clanWarsService;
	}
}
