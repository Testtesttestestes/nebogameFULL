using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public class ExtraSlotsView : MonoBehaviour
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700044E")]
		public Transform Stub
		{
			[Token(Token = "0x6001864")]
			[Address(RVA = "0x6A04", Offset = "0x6A04", VA = "0x6A04")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700044F")]
		public EquipmentExtraSlotView[] Slots
		{
			[Token(Token = "0x6001865")]
			[Address(RVA = "0x6A05", Offset = "0x6A05", VA = "0x6A05")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x6A06", Offset = "0x6A06", VA = "0x6A06")]
		public void SetVisibleSlots(bool value)
		{
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x6A07", Offset = "0x6A07", VA = "0x6A07")]
		public ExtraSlotsView()
		{
		}

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _stub;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _slotsContainer;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EquipmentExtraSlotView[] _slots;
	}
}
