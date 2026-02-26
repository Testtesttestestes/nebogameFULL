using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Shop
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	public class ShopEvents : AbstractMVCEvents
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x71CD", Offset = "0x71CD", VA = "0x71CD")]
		public ShopEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Events_ShopEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a63acb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_CompetitionModel__CompetitionEvents___ctor__);
		    DAT_ram_00a63acb = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param4,param5,
		             Method_MVC_AbstractController_CompetitionModel__CompetitionEvents___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_Shop_ShopEvents___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x94);
		  if (iVar1 == 0) {
		    iVar1 = Core_Data_ArtifactData__get_IsTemporaryWithExpiredLifetime
		                      (*(undefined4 *)(param1 + 0x98),0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x14")]
		public Action OnItemsUpdatedEvent;
	}
}
