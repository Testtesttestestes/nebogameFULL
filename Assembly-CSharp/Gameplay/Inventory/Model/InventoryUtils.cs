using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Main;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006AA RID: 1706
	[Token(Token = "0x20006AA")]
	public class InventoryUtils
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x7A4E", Offset = "0x7A4E", VA = "0x7A4E")]
		public static IList<ProtoGetUserArtifactsAns.Types.UserArtifact> FillEmptySlots(IList<ProtoGetUserArtifactsAns.Types.UserArtifact> rawSlots, long slotsLimit)
		{
			return null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x7A4F", Offset = "0x7A4F", VA = "0x7A4F")]
		public static RepeatedField<UserArtifact> FillEmptySlots(RepeatedField<UserArtifact> rawSlots, long slotsLimit = 9223372036854775807L)
		{
			return null;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x7A50", Offset = "0x7A50", VA = "0x7A50")]
		public static bool IsChestSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x7A51", Offset = "0x7A51", VA = "0x7A51")]
		public static bool IsBagSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x7A52", Offset = "0x7A52", VA = "0x7A52")]
		public static bool IsEquipmentSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x7A53", Offset = "0x7A53", VA = "0x7A53")]
		public static bool IsGolemEquipmentSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x7A54", Offset = "0x7A54", VA = "0x7A54")]
		public InventoryUtils()
		{
		}
	}
}
