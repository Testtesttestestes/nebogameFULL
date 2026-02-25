using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Gameplay.Clans.Office.View.ClanOverviewTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	public class ClanOverviewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanOverview>, IHideableMediator
	{
		// Token: 0x06003F59 RID: 16217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x8E14", Offset = "0x8E14", VA = "0x8E14")]
		public ClanOverviewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		}

		// Token: 0x17000CA0 RID: 3232
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA0")]
		public override ClanOverview View
		{
			[Token(Token = "0x6003F5A")]
			[Address(RVA = "0x8E15", Offset = "0x8E15", VA = "0x8E15", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x8E16", Offset = "0x8E16", VA = "0x8E16")]
		private void Init()
		{
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x8E17", Offset = "0x8E17", VA = "0x8E17")]
		private void ZigguratButtonClickedEventHandler()
		{
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x8E18", Offset = "0x8E18", VA = "0x8E18")]
		private void NameInputChangedEventHandler(string name)
		{
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x8E19", Offset = "0x8E19", VA = "0x8E19")]
		private void DescriptionInputChangedEventHandler(string description)
		{
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x8E1A", Offset = "0x8E1A", VA = "0x8E1A")]
		private void ResetView()
		{
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x8E1B", Offset = "0x8E1B", VA = "0x8E1B")]
		private void FractionClanClickedEventHandler(ClanTypeListElement element)
		{
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x8E1C", Offset = "0x8E1C", VA = "0x8E1C")]
		private void UpdateCostButton()
		{
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x8E1D", Offset = "0x8E1D", VA = "0x8E1D")]
		private void ChangeClanButtonClickedEventHandler()
		{
		}

		// Token: 0x17000CA1 RID: 3233
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA1")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0x8E1E", Offset = "0x8E1E", VA = "0x8E1E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x8E1F", Offset = "0x8E1F", VA = "0x8E1F")]
		private void ClanTreasuryRequestedEventHandler()
		{
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x8E20", Offset = "0x8E20", VA = "0x8E20")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x8E21", Offset = "0x8E21", VA = "0x8E21")]
		private void ValidateChangeButton()
		{
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x8E22", Offset = "0x8E22", VA = "0x8E22", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x18")]
		private ResourceSet _changeClanPrice;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x1C")]
		private ResourceSet _changeToFractionClanPrice;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x20")]
		private bool _fractionSelected;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x21")]
		private bool _nameChanged;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x22")]
		private bool _descriptionChanged;
	}
}
