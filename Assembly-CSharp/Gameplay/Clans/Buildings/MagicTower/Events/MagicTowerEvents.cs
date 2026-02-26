using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.MagicTower.Events
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class MagicTowerEvents : AbstractMVCEvents
	{
		// Token: 0x06004236 RID: 16950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004236")]
		[Address(RVA = "0x90EA", Offset = "0x90EA", VA = "0x90EA")]
		public MagicTowerEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_Events_MagicTowerEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57811 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MagicTowerService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57811 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MagicTowerService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x14")]
		public Action TowerInfoRequestedEvent;

		// Token: 0x0400248E RID: 9358
		[Token(Token = "0x400248E")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> SpellStateChanged;

		// Token: 0x0400248F RID: 9359
		[Token(Token = "0x400248F")]
		[FieldOffset(Offset = "0x1C")]
		public Action<uint> SpellUpdated;
	}
}
