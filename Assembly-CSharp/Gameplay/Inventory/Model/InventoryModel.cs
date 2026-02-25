using System;
using System.Collections.Generic;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UI.Toast;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006A5 RID: 1701
	[Token(Token = "0x20006A5")]
	public class InventoryModel : InventoryBaseModel
	{
		// Token: 0x06002935 RID: 10549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x7A3D", Offset = "0x7A3D", VA = "0x7A3D")]
		public InventoryModel(Antiq.Types.EffectsDic.Types.EffectID effectId, ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007D8")]
		public override UserData OwnerUser
		{
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x7A3E", Offset = "0x7A3E", VA = "0x7A3E", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x7A3F", Offset = "0x7A3F", VA = "0x7A3F", Slot = "8")]
		public override bool CanFitTwoHandedWeapon(out int occupiedSlots)
		{
			return default(bool);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x7A40", Offset = "0x7A40", VA = "0x7A40", Slot = "9")]
		protected override long GetExtraSlotsCount()
		{
			return 0L;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x7A41", Offset = "0x7A41", VA = "0x7A41")]
		public ArtifactData[] GetArtifactsToRepairForHorde(int hordeLength)
		{
			return null;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x7A42", Offset = "0x7A42", VA = "0x7A42")]
		public ArtifactData[] GetArtifactsToTakeoffForHorde(int hordeLen)
		{
			return null;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x7A43", Offset = "0x7A43", VA = "0x7A43", Slot = "12")]
		public override IList<ArtifactData> GetComparableItems()
		{
			return null;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x7A44", Offset = "0x7A44", VA = "0x7A44", Slot = "11")]
		public override ResourceSet GetSlotPrice(uint slotCount)
		{
			return null;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x7A45", Offset = "0x7A45", VA = "0x7A45", Slot = "13")]
		public override bool IsArtifactCanBeEquipped(ArtifactData artifact)
		{
			return default(bool);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x7A46", Offset = "0x7A46", VA = "0x7A46", Slot = "10")]
		protected override bool IsEquipmentSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x58")]
		private readonly Antiq.Types.EffectsDic.Types.EffectID _effectId;
	}
}
