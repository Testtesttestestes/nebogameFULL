using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public class UserEquipmentView : BaseEquipmentView<UserEquipmentSlotConfig>
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000450")]
		public ExtraSlotsView ExtraSlots
		{
			[Token(Token = "0x600186A")]
			[Address(RVA = "0x6A0A", Offset = "0x6A0A", VA = "0x6A0A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x6A0B", Offset = "0x6A0B", VA = "0x6A0B")]
		public UserEquipmentView()
		{
		}

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ExtraSlotsView _extraSlots;
	}
}
