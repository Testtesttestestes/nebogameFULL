using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	[Serializable]
	public abstract class BaseEquipmentSlotConfig<TSlotIds> : IEquipmentSlotConfig where TSlotIds : Enum
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700044B")]
		public TSlotIds EquipmentSlotId
		{
			[Token(Token = "0x600184F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700044C")]
		public EquipmentSlotView Slot
		{
			[Token(Token = "0x6001850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001851 RID: 6225
		[Token(Token = "0x6001851")]
		public abstract int GetSlotId();

		// Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001852")]
		protected BaseEquipmentSlotConfig()
		{
		}

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TSlotIds _equipmentSlotId;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private EquipmentSlotView _slot;
	}
}
