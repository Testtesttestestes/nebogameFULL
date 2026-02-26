using System;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x2000411")]
	[Serializable]
	public class UserEquipmentSlotConfig : BaseEquipmentSlotConfig<EquipmentSlotIds>
	{
		// Token: 0x06001868 RID: 6248 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x6A08", Offset = "0x6A08", VA = "0x6A08", Slot = "6")]
		public override int GetSlotId()
		{
		/* --- GHIDRA: GetSlotId ---
		void Gameplay_UserInfo_View_Equipment_UserEquipmentSlotConfig__GetSlotId
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59901 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds___ctor__
		              );
		    DAT_ram_00a59901 = '\x01';
		  }
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x6A09", Offset = "0x6A09", VA = "0x6A09")]
		public UserEquipmentSlotConfig()
		{
		}
	}
}
