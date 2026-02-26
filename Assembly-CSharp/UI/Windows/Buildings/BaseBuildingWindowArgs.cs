using System;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public abstract class BaseBuildingWindowArgs : BaseIsleBuildingWindowArgs<UserIsle>
	{
		// Token: 0x06000FFF RID: 4095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x620A", Offset = "0x620A", VA = "0x620A")]
		protected BaseBuildingWindowArgs(UserIsle isle, uint buildingTypeId)
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_BaseBuildingWindowArgs___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58a8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseIsleBuildingWindowArgs_ClanIsle___ctor__);
		    DAT_ram_00a58a8d = '\x01';
		  }
		  Core_GameResources_BaseGameResourcesFabric_object__object___get_TotalResourceCount
		            (param1,param2,param3,
		             Method_UI_Windows_Buildings_BaseIsleBuildingWindowArgs_ClanIsle___ctor__);
		  return;
		}
		*/

		}
	}
}
