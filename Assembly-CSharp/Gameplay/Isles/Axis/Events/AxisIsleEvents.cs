using System;
using Gameplay.Isles.Base.Events;
using Il2CppDummyDll;

namespace Gameplay.Isles.Axis.Events
{
	// Token: 0x02000D08 RID: 3336
	[Token(Token = "0x2000D08")]
	public class AxisIsleEvents : BaseIsleEvents
	{
		// Token: 0x06005169 RID: 20841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005169")]
		[Address(RVA = "0x9F48", Offset = "0x9F48", VA = "0x9F48")]
		public AxisIsleEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Axis_Events_AxisIsleEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58d04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_AxisIsleModel__AxisIsleEvents___ctor__
		              );
		    DAT_ram_00a58d04 = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_AxisIsleModel__AxisIsleEvents___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
