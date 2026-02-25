using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6E RID: 2670
	[Token(Token = "0x2000A6E")]
	public class ClanResumesController : AbstractController<ClanResumesModel, ClanResumesEvents>
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA2")]
		public ClanInfoController ClanInfoController
		{
			[Token(Token = "0x6003F68")]
			[Address(RVA = "0x8E23", Offset = "0x8E23", VA = "0x8E23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F69")]
			[Address(RVA = "0x8E24", Offset = "0x8E24", VA = "0x8E24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x8E25", Offset = "0x8E25", VA = "0x8E25")]
		public ClanResumesController(ClanResumesModel model, ClanResumesEvents events, ClanInfoController clanInfoController)
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x8E26", Offset = "0x8E26", VA = "0x8E26")]
		public void GetJoinRequests(UserRatingTypes ratingType, RatingPeriods period, uint lastRatingValue, ulong lastUserId)
		{
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x8E27", Offset = "0x8E27", VA = "0x8E27")]
		private void GetJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x8E28", Offset = "0x8E28", VA = "0x8E28")]
		public void GetFirstJoinRequests(UserRatingTypes ratingType, RatingPeriods period)
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x8E29", Offset = "0x8E29", VA = "0x8E29")]
		private void GetFirstJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x8E2A", Offset = "0x8E2A", VA = "0x8E2A")]
		public void DeclineJoinRequest(ulong userId)
		{
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x8E2B", Offset = "0x8E2B", VA = "0x8E2B")]
		private void DeclineJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x8E2C", Offset = "0x8E2C", VA = "0x8E2C")]
		public void AcceptJoinRequest(UserData user)
		{
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x8E2D", Offset = "0x8E2D", VA = "0x8E2D")]
		private void AcceptJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x8E2E", Offset = "0x8E2E", VA = "0x8E2E")]
		private DialogWindow ShowMembersExceededDiaogWindow()
		{
			return null;
		}

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x18")]
		private ClansService _clansService;
	}
}
