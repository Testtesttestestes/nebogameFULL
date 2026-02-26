using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Battles.Events
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class BattlesEvents : AbstractMVCEvents
	{
		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x9A43", Offset = "0x9A43", VA = "0x9A43")]
		public BattlesEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Battles_Events_BattlesEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a60976 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_BattlesModel__BattlesEvents___ctor__);
		    DAT_ram_00a60976 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_BattlesModel__BattlesEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002974 RID: 10612
		[Token(Token = "0x4002974")]
		[FieldOffset(Offset = "0x14")]
		public Action NotificationNumChangedEvent;
	}
}
