using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.FrontPageTab
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public class FrontPageView : MonoBehaviour
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C6")]
		public BacktimeViewUGUI SeasonBacktime
		{
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x644F", Offset = "0x644F", VA = "0x644F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C7")]
		public TextMeshProUGUI SeasonStatusText
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x6450", Offset = "0x6450", VA = "0x6450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C8")]
		public Button CreateClanButton
		{
			[Token(Token = "0x6001257")]
			[Address(RVA = "0x6451", Offset = "0x6451", VA = "0x6451")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C9")]
		public Button ToWorldAxisButton
		{
			[Token(Token = "0x6001258")]
			[Address(RVA = "0x6452", Offset = "0x6452", VA = "0x6452")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x6453", Offset = "0x6453", VA = "0x6453")]
		public FrontPageView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_FrontPageTab_FrontPageView___ctor
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  double param2_00;
		  double param2_01;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58bc6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_int___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17781);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26115);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17782);
		    DAT_ram_00a58bc6 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = Core_Extensions_Dict_CollectionsDicExt__GetDescription(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = Core_Extensions_Dict_ColossusDicExt__GetTitle(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80f841c7;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,4);
		code_r0x80f841c7:
		  uVar8 = 0;
		  uVar1 = CONCAT44(in_register_20000014,puVar3[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param2_00 = func_ii_6906(uVar5,5,0);
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80f84251;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,2);
		code_r0x80f84251:
		  uVar1 = CONCAT44(uVar2,puVar3[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param2_01 = func_ii_6906(uVar5,5,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17782,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  iVar7 = *param3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f8431e;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,0);
		code_r0x80f8431e:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param3,CONCAT44(uVar2,puVar3[1]));
		  iVar7 = System_Linq_Enumerable__FirstOrDefault_KeyValuePair_object__object__
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_int___);
		  uVar2 = Gameplay_WorldAxis_ColossusInfo_View_ColossusDescription__Init
		                    (puVar3,(double)iVar7,puVar3);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26115,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar6,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17781,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar5 = Gameplay_WorldAxis_ColossusInfo_View_ColossusDescription__Init(iVar6,param2_00,iVar6);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_19795,uVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar6,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17781,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar5 = Gameplay_WorldAxis_ColossusInfo_View_ColossusDescription__Init(iVar6,param2_01,iVar6);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_19795,uVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_18;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar6,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BacktimeViewUGUI _seasonBacktime;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatusText;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _toWorldAxisButton;
	}
}
