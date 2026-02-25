using System;
using Gameplay.Inventory.Model;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC1 RID: 2753
	[Token(Token = "0x2000AC1")]
	[Serializable]
	public class GolemEquipmentSlotConfig : BaseEquipmentSlotConfig<GolemEquipmentSlotIds>
	{
		// Token: 0x06004269 RID: 17001 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x911D", Offset = "0x911D", VA = "0x911D", Slot = "6")]
		public override int GetSlotId()
		{
			return 0;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x911E", Offset = "0x911E", VA = "0x911E")]
		public GolemEquipmentSlotConfig()
		{
		}
	}
}
