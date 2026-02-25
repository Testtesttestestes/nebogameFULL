using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Gameplay.World.Controller;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Consts;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	public class ClanOfficeController : AbstractController<ClanOfficeModel, ClanOfficeEvents>
	{
		// Token: 0x06003F40 RID: 16192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x8DFB", Offset = "0x8DFB", VA = "0x8DFB")]
		public ClanOfficeController(ClanOfficeModel model, ClanOfficeEvents events, IUserIslesWorldMovement userWorldMovement)
		{
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x8DFC", Offset = "0x8DFC", VA = "0x8DFC")]
		public void RequestFirstClanVacancies(ClanRatingTypes ratingTypes, RatingPeriods ratingPeriods, string name, bool onlyAvailable)
		{
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x8DFD", Offset = "0x8DFD", VA = "0x8DFD")]
		private void RequestFirstClanVacanciesResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x8DFE", Offset = "0x8DFE", VA = "0x8DFE")]
		public void RequestAdditionalClanVacancies(ClanRatingTypes ratingTypes, RatingPeriods ratingPeriods, uint pageNumber, string name, bool onlyAvailable)
		{
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x8DFF", Offset = "0x8DFF", VA = "0x8DFF")]
		private void RequestAdditionalClanVacanciesResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F45")]
		[Address(RVA = "0x8E00", Offset = "0x8E00", VA = "0x8E00")]
		private void ValidatePages(ProtoGetClanVacanciesListAns msg)
		{
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F46")]
		[Address(RVA = "0x8E01", Offset = "0x8E01", VA = "0x8E01")]
		private void HandleMaxPage(uint pageNumber)
		{
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x8E02", Offset = "0x8E02", VA = "0x8E02")]
		private void HandleMinPage(uint pageNumber)
		{
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x8E03", Offset = "0x8E03", VA = "0x8E03")]
		public void RequestJoinClan(ClanInRatingListElement.ClanInRatingListElementArgs args)
		{
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F49")]
		[Address(RVA = "0x8E04", Offset = "0x8E04", VA = "0x8E04")]
		private void RequestJoinClanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x8E05", Offset = "0x8E05", VA = "0x8E05")]
		public void CancelJoinRequest()
		{
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x8E06", Offset = "0x8E06", VA = "0x8E06")]
		private void CancelJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x8E07", Offset = "0x8E07", VA = "0x8E07")]
		public void CreateClan(string name, string description, ClanFlags flags)
		{
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x8E08", Offset = "0x8E08", VA = "0x8E08")]
		private void CreateClanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x18")]
		private ClansService _clansService;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x1C")]
		private IUserIslesWorldMovement _userWorldMovement;
	}
}
