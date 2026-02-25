using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Toast;

namespace Gameplay.Clans.Buildings.Golem.Model
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	public class GolemInventoryModel : InventoryBaseModel
	{
		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2D")]
		public UserData GolemUserData
		{
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x9167", Offset = "0x9167", VA = "0x9167")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x9168", Offset = "0x9168", VA = "0x9168")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2E")]
		public override UserData OwnerUser
		{
			[Token(Token = "0x60042B5")]
			[Address(RVA = "0x9169", Offset = "0x9169", VA = "0x9169", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x916A", Offset = "0x916A", VA = "0x916A")]
		public GolemInventoryModel(IGame game, ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user, UserData golemUserData)
		{
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x916B", Offset = "0x916B", VA = "0x916B", Slot = "9")]
		protected override long GetExtraSlotsCount()
		{
			return 0L;
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x916C", Offset = "0x916C", VA = "0x916C", Slot = "11")]
		public override ResourceSet GetSlotPrice(uint slotCount)
		{
			return null;
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x916D", Offset = "0x916D", VA = "0x916D", Slot = "13")]
		public override bool IsArtifactCanBeEquipped(ArtifactData artifact)
		{
			return default(bool);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x916E", Offset = "0x916E", VA = "0x916E", Slot = "6")]
		protected override void HandleBagSlot(int slotId, ArtifactData artifactData)
		{
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x916F", Offset = "0x916F", VA = "0x916F", Slot = "10")]
		protected override bool IsEquipmentSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x9170", Offset = "0x9170", VA = "0x9170", Slot = "12")]
		public override IList<ArtifactData> GetComparableItems()
		{
			return null;
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x9171", Offset = "0x9171", VA = "0x9171", Slot = "8")]
		public override bool CanFitTwoHandedWeapon(out int occupiedSlots)
		{
			return default(bool);
		}
	}
}
