using System;
using System.Collections.Generic;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class ClanCombatEvents : TeamCombatEvents
	{
		// Token: 0x060040D3 RID: 16595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x8F8A", Offset = "0x8F8A", VA = "0x8F8A")]
		public ClanCombatEvents()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Clans_Combat_ClanCombatEvents___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57764 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    DAT_ram_00a57764 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 8);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Clans_Combat_Model_GameOverData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param1_00[10] + 0x14) + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  uVar1 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param1_00[0xb] + 0x14) + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar2,uVar1,0);
		  piVar3 = *(int **)(*(int *)(param1 + 0x58) + 8);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1_00[10] + 0x14),0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  piVar3 = *(int **)(*(int *)(param1 + 0x5c) + 8);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1_00[0xb] + 0x14),0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  Gameplay_UserInfo_View_CultView2__get_CultDic
		            (*(undefined4 *)(*(int *)(param1 + 0x58) + 0x10),*(undefined4 *)(param1_00[10] + 0x20),0
		            );
		  Gameplay_UserInfo_View_CultView2__get_CultDic
		            (*(undefined4 *)(*(int *)(param1 + 0x5c) + 0x10),*(undefined4 *)(param1_00[0xb] + 0x20),
		             0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xc);
		  uVar1 = Gameplay_Combat_Model_CombatPlayer__set_User(param1_00[10],0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0xc);
		  uVar1 = Gameplay_Combat_Model_CombatPlayer__set_User(param1_00[0xb],0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged(uVar2,uVar1,0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__get_IsPremiumExp
		            (*(undefined4 *)(*(int *)(param1 + 0x58) + 0xc),
		             (uint)*(byte *)(*(int *)(param1_00[10] + 0x14) + 0x74),0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__get_IsPremiumExp
		            (*(undefined4 *)(*(int *)(param1 + 0x5c) + 0xc),
		             (uint)*(byte *)(*(int *)(param1_00[0xb] + 0x14) + 0x74),0);
		  iVar4 = param1_00[6];
		  if (iVar4 == param1_00[10]) {
		    AssetContent_GameAssetViewRawImage__get_AssetPath(*(undefined4 *)(param1 + 0x50),1.0,0.2,0);
		    iVar4 = param1_00[6];
		  }
		  if (iVar4 == param1_00[0xb]) {
		    AssetContent_GameAssetViewRawImage__get_AssetPath(*(undefined4 *)(param1 + 0x54),1.0,0.2,0);
		  }
		  uVar1 = Gameplay_Combat_View_CombatGameOverView__OnDestroy(param1,param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x70")]
		public Action<List<CombatPlayer>> PlayersMoved;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x74")]
		public Action Joint;
	}
}
