using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	public class MedalInfoViewMediator : AbstractViewMediator<MedalsModel, MedalsEvents, MedalsController, MedalInfoWindow>
	{
		// Token: 0x0600257C RID: 9596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x76C1", Offset = "0x76C1", VA = "0x76C1")]
		public MedalInfoViewMediator(MedalsModel model, MedalsEvents events, MedalsController controller)
		{
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700070F")]
		private string DurationPrefix
		{
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x76C2", Offset = "0x76C2", VA = "0x76C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000710")]
		public override MedalInfoWindow View
		{
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x76C3", Offset = "0x76C3", VA = "0x76C3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x76C4", Offset = "0x76C4", VA = "0x76C4")]
		private void Init()
		{
		}

		// Token: 0x17000711 RID: 1809
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000711")]
		public override MedalsEvents Events
		{
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x76C5", Offset = "0x76C5", VA = "0x76C5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x76C6", Offset = "0x76C6", VA = "0x76C6")]
		private void MedalChangedEventHandler(MedalData medalData, uint medalId)
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x76C7", Offset = "0x76C7", VA = "0x76C7")]
		private void ValidateAchievedMedals(MedalData medalData, uint medalId)
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x76C8", Offset = "0x76C8", VA = "0x76C8")]
		private void BuyButtonClickedEventHandler()
		{
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x76C9", Offset = "0x76C9", VA = "0x76C9")]
		private bool TryShowBuyMedalConfirmation()
		{
			return default(bool);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x76CA", Offset = "0x76CA", VA = "0x76CA")]
		private void HandleBuyMedalConfirmation(MedalData data)
		{
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x76CB", Offset = "0x76CB", VA = "0x76CB")]
		private void MedalSelectedEventHandler(MedalViewSelectable medalView)
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x76CC", Offset = "0x76CC", VA = "0x76CC")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x76CD", Offset = "0x76CD", VA = "0x76CD")]
		private void RenderCurrentMedal()
		{
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x76CE", Offset = "0x76CE", VA = "0x76CE")]
		private void HandleSale(MedalDicWrapper medal)
		{
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x76CF", Offset = "0x76CF", VA = "0x76CF")]
		private string GetFullDescription()
		{
			return null;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x76D0", Offset = "0x76D0", VA = "0x76D0")]
		private void HandlePrice(MedalDicWrapper medal)
		{
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x76D1", Offset = "0x76D1", VA = "0x76D1")]
		private void HandleDurationView()
		{
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x76D2", Offset = "0x76D2", VA = "0x76D2")]
		private void HandleCollectionView(MedalDicWrapper medal)
		{
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x76D3", Offset = "0x76D3", VA = "0x76D3")]
		private void SelectMedalByRank(uint rankId)
		{
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x76D4", Offset = "0x76D4", VA = "0x76D4")]
		private string FormatDuration(float rawValue)
		{
			return null;
		}

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x18")]
		private List<MedalViewSelectable> _medalViews;

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x1C")]
		private uint _selectedRank;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x20")]
		private MedalData _medalData;

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x24")]
		private string _durationPrefix;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x28")]
		private double _priceCoeff;

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x30")]
		private bool _saleEnabled;
	}
}
