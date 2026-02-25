using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	public abstract class ArtifactActionBaseViewMediator<M, E, C> : AbstractViewMediator<M, E, C, ArtifactActionPopupWindow>, IViewMediator<ArtifactActionPopupWindow>, IViewMediator where M : InventoryBaseModel where E : InventoryBaseEvents where C : InventoryBaseController<M, E>
	{
		// Token: 0x06002953 RID: 10579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002953")]
		public ArtifactActionBaseViewMediator(M model, E events, C controller)
		{
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D9")]
		private protected ArtifactData ArtifactData
		{
			[Token(Token = "0x6002954")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6002955")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007DA")]
		protected ResourceSet RepairFullPrice
		{
			[Token(Token = "0x6002956")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007DB")]
		protected ResourceSet RepairBattlePrice
		{
			[Token(Token = "0x6002957")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007DC")]
		protected ResourceSet RepairPrice
		{
			[Token(Token = "0x6002958")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007DD")]
		public override ArtifactActionPopupWindow View
		{
			[Token(Token = "0x6002959")]
			set
			{
			}
		}

		// Token: 0x170007DE RID: 2014
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007DE")]
		public override E Events
		{
			[Token(Token = "0x600295A")]
			set
			{
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295B")]
		private void Init()
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295C")]
		private void DataChangedEventHandler()
		{
		}

		// Token: 0x0600295D RID: 10589
		[Token(Token = "0x600295D")]
		protected abstract void DrawPrice();

		// Token: 0x0600295E RID: 10590
		[Token(Token = "0x600295E")]
		protected abstract void InitRepairCostButton();

		// Token: 0x0600295F RID: 10591
		[Token(Token = "0x600295F")]
		protected abstract void InitReforgeCostButton();

		// Token: 0x06002960 RID: 10592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002960")]
		private void ResolveActionType(ArtifactActionPopupWindow.ActionType actionType)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002961")]
		private void HandleReforgeActionType()
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002962")]
		private void HandleRepairActionType()
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002963")]
		private void ReforgeButtonClickedEventHandler()
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002964")]
		private void RepairButtonClickedEventHandler()
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002965")]
		private void InventoryChangedEventHandler()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002966")]
		private void ArtifactChangedEventHandler()
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002967")]
		private void HandleArtifactChanged(ArtifactData data)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002968")]
		private void UpdateDurabilityInfo()
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002969")]
		protected void UseBattleAccountDiscount(double coeff, string key)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296A")]
		protected void UseActionDiscount(double coeff, string key)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296B")]
		protected void UseBattlePriceReforge()
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296C")]
		protected void UseCommonPriceReforge()
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296D")]
		protected void UseBattlePriceRepair()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296E")]
		protected void UseCommonPriceRepair()
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x600296F")]
		protected bool TryGetReforgeDiscountCoeff(out double coeff)
		{
			return default(bool);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6002970")]
		protected bool TryGetRepairDiscountCoeff(out double coeff)
		{
			return default(bool);
		}

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x0")]
		protected ResourceSet _currentPrice;
	}
}
