using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class ClanTitle : MonoBehaviour
	{
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C04")]
		private TextMeshProUGUI Text
		{
			[Token(Token = "0x6003CE7")]
			[Address(RVA = "0x8BA7", Offset = "0x8BA7", VA = "0x8BA7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x8BA8", Offset = "0x8BA8", VA = "0x8BA8")]
		public void SetTitle(string title)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_Clans_Combat_View_ClanTitle__SetTitle(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a57776 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57776 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x14);
		  iVar1 = func_ii_4443(&local_4,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x8BA9", Offset = "0x8BA9", VA = "0x8BA9")]
		public ClanTitle()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_View_ClanTitle___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57777 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57777 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanTitle___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  longlong local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a57f08 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4319);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4331);
		    DAT_ram_00a57f08 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param2 + 0xc) + 0x1c);
		  Gameplay_Clans_Office_View_ClanTitle__get_Text
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(iVar5 + 0x18),&local_10);
		  iVar5 = Core_Extensions_ClanInfoExt__GetHonorRating(iVar5,0);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4319,1,0,1,0,0,0,0);
		  local_8 = (longlong)iVar5;
		  uVar3 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,uVar2,uVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar1 = *(uint *)(*(int *)(param2 + 8) + 0x1c);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4331,1,0,1,0,0,0,0);
		  local_10 = (ulonglong)uVar1 - (longlong)iVar5;
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,uVar4,uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI _text;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Text ---
		void Gameplay_Clans_Office_View_ClanTitle__get_Text(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57f07 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4205);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_144);
		    DAT_ram_00a57f07 = '\x01';
		  }
		  if (DAT_ram_00a57f06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57f06 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		  if (iVar1 == 0) {
		    uVar3 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		  }
		  else {
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		  }
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4205,1,0,1,0,0,0,0);
		  uVar2 = System_Int32__ToString(uVar2,StringLiteral_144,param2,StringLiteral_527,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetCount ---
		void Gameplay_Clans_Combat_View_ClanTitle__SetCount(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  local_8 = 0;
		  iVar1 = Gameplay_World_Model_ClanData__TryGetFractionCultDic(param2,&local_4,0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(local_4,0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar3,uVar2,0);
		  }
		  iVar1 = Gameplay_World_Model_ClanData__ClearTreasuryFlag(param2,&local_8,0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    uVar2 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(local_8,0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar3,uVar2,0);
		  }
		  return;
		}
		*/

}
