using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class ClanWarsOfficeController : AbstractController<ClanWarsOfficeModel, ClanWarsOfficeEvents>
	{
		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004056 RID: 16470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB3")]
		public ClanWarsController ClanWarsController
		{
			[Token(Token = "0x6004055")]
			[Address(RVA = "0x8F0F", Offset = "0x8F0F", VA = "0x8F0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004056")]
			[Address(RVA = "0x8F10", Offset = "0x8F10", VA = "0x8F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004058 RID: 16472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB4")]
		public ClanInfoController ClanInfoController
		{
			[Token(Token = "0x6004057")]
			[Address(RVA = "0x8F11", Offset = "0x8F11", VA = "0x8F11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004058")]
			[Address(RVA = "0x8F12", Offset = "0x8F12", VA = "0x8F12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x8F13", Offset = "0x8F13", VA = "0x8F13")]
		public ClanWarsOfficeController(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsController clanWarsController, ClanInfoController clanInfoController)
		{
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x8F14", Offset = "0x8F14", VA = "0x8F14", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x8F15", Offset = "0x8F15", VA = "0x8F15", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x8F16", Offset = "0x8F16", VA = "0x8F16")]
		private void InitEventHandler()
		{
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x8F17", Offset = "0x8F17", VA = "0x8F17")]
		private void Init()
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x8F18", Offset = "0x8F18", VA = "0x8F18")]
		public void GetSeasonBankDistribution()
		{
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x8F19", Offset = "0x8F19", VA = "0x8F19")]
		private void GetSeasonBankDistributionResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x8F1A", Offset = "0x8F1A", VA = "0x8F1A")]
		public void RequestPolitics(uint leagueId, ulong previousClanId, uint lastHonorRating, string title, bool readyForWar, bool onlyBlitz, uint linesCount)
		{
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004061")]
		[Address(RVA = "0x8F1B", Offset = "0x8F1B", VA = "0x8F1B")]
		private void RequestPoliticsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x8F1C", Offset = "0x8F1C", VA = "0x8F1C")]
		public void RequestFirstPolitics(uint leagueId, string title, bool readyForWar, bool onlyBlitz, uint linesCount)
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x8F1D", Offset = "0x8F1D", VA = "0x8F1D")]
		private void RequestFirstPoliticsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x8F1E", Offset = "0x8F1E", VA = "0x8F1E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsService _clanWarsService;
	}
}
