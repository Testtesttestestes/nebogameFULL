using System;
using System.Runtime.CompilerServices;
using Core.Money;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanTreasuryTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class ClanTreasuryViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanTreasuryView>, IHideableMediator
	{
		// Token: 0x06003F8F RID: 16271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x8E4A", Offset = "0x8E4A", VA = "0x8E4A")]
		public ClanTreasuryViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller, Money deficientResources)
		{
		}

		// Token: 0x17000CA5 RID: 3237
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA5")]
		public override ClanTreasuryView View
		{
			[Token(Token = "0x6003F90")]
			[Address(RVA = "0x8E4B", Offset = "0x8E4B", VA = "0x8E4B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x8E4C", Offset = "0x8E4C", VA = "0x8E4C")]
		private void ResetView()
		{
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x8E4D", Offset = "0x8E4D", VA = "0x8E4D")]
		private void SetupView()
		{
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x8E4E", Offset = "0x8E4E", VA = "0x8E4E")]
		private void UserBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x8E4F", Offset = "0x8E4F", VA = "0x8E4F")]
		private void SubmitToTreasuryButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x8E50", Offset = "0x8E50", VA = "0x8E50")]
		private void AddToTreasury(ResourceSet inputResources)
		{
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x8E51", Offset = "0x8E51", VA = "0x8E51")]
		private void ToEventsButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x8E52", Offset = "0x8E52", VA = "0x8E52")]
		private void UpdateWarStatus()
		{
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x8E53", Offset = "0x8E53", VA = "0x8E53")]
		private void RenderDeficientResources()
		{
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x8E54", Offset = "0x8E54", VA = "0x8E54", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA6")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F9A")]
			[Address(RVA = "0x8E55", Offset = "0x8E55", VA = "0x8E55", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x8E56", Offset = "0x8E56", VA = "0x8E56")]
		private void WarStateChangedEventHandler()
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x8E57", Offset = "0x8E57", VA = "0x8E57")]
		private void ClanTreasuryChangedEventHandler()
		{
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x8E58", Offset = "0x8E58", VA = "0x8E58")]
		private void CutInputResourcesByLimit(ResourceSet inputResources, ResourceSet balance, NullableResourceSet limits, double taxCoeff)
		{
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x8E59", Offset = "0x8E59", VA = "0x8E59")]
		private double GetTaxCoeff()
		{
			return 0.0;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x1B10", Offset = "0x1B10", VA = "0x1B10")]
		private DialogWindow ShowExceedingOperationDialogWindow(ResourceSet inputResources, ResourceSet balance, NullableResourceSet limits, double taxCoeff)
		{
			return null;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x8E5A", Offset = "0x8E5A", VA = "0x8E5A")]
		private DialogWindow ShowColossusWarningWindow(ResourceSet inputResources)
		{
			return null;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x8E5B", Offset = "0x8E5B", VA = "0x8E5B")]
		[CompilerGenerated]
		private bool <SubmitToTreasuryButtonClickedEventHandler>g__CheckIfGreaterThanFee|9_0(ref ClanTreasuryViewMediator.<>c__DisplayClass9_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x8E5C", Offset = "0x8E5C", VA = "0x8E5C")]
		[CompilerGenerated]
		private bool <SubmitToTreasuryButtonClickedEventHandler>g__CheckForColossusFragments|9_1(ref ClanTreasuryViewMediator.<>c__DisplayClass9_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x18")]
		private Money _deficientResources;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsModel _clanWarsModel;

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x20")]
		private ZigguratLevelDic _zigguratLevelDic;
	}
}
