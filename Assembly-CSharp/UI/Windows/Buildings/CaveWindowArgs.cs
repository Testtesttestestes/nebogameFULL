using System;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public class CaveWindowArgs : BaseBuildingWindowArgs
	{
		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x6242", Offset = "0x6242", VA = "0x6242")]
		public CaveWindowArgs(UserIsle isle, uint buildingTypeId)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_Buildings_CaveWindowArgs___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58aa7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a58aa7 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x3c) + 0x10) + 0x30) + 0x14);
		}
		*/

		}
	}
}
