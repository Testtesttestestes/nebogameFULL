using System;
using Core.Data.Balance;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ResourceBar.Events
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public class ResourceBarEvents : AbstractMVCEvents
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x7243", Offset = "0x7243", VA = "0x7243")]
		public ResourceBarEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ResourceBar_Events_ResourceBarEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58340 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ResourceBarModel__ResourceBarEvents___ctor__);
		    DAT_ram_00a58340 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ResourceBarModel__ResourceBarEvents___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x14")]
		public IBalanceSource.BalanceChangedDelegate BalanceChangedEvent;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x18")]
		public Action<int> PopupStateChangedEvent;
	}
}
