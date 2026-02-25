using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	public class EquipmentExtraSlotView : EquipmentSlotView
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x6A02", Offset = "0x6A02", VA = "0x6A02")]
		public void SetAvail(bool value)
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x6A03", Offset = "0x6A03", VA = "0x6A03")]
		public EquipmentExtraSlotView()
		{
		}

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform[] _toShowWhenAvail;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _toHideWhenAvail;
	}
}
