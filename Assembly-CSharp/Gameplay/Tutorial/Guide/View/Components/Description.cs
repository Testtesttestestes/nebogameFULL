using System;
using AssetContent;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	public class Description : MonoBehaviourWithStates<AprLayout>
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x6C83", Offset = "0x6C83", VA = "0x6C83")]
		private void Start()
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B3")]
		public GuideConfig GuideConfig
		{
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x6C84", Offset = "0x6C84", VA = "0x6C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x6C85", Offset = "0x6C85", VA = "0x6C85")]
			set
			{
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x6C86", Offset = "0x6C86", VA = "0x6C86")]
		private void HandleConfigChanged()
		{
		/* --- GHIDRA: HandleConfigChanged ---
		void Gameplay_Tutorial_Guide_View_Components_Description__HandleConfigChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Tutorial_Guide_View_Components_Description__set_GuideConfig(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x6C87", Offset = "0x6C87", VA = "0x6C87")]
		public void OnChanged()
		{
		/* --- GHIDRA: OnChanged ---
		void Gameplay_Tutorial_Guide_View_Components_Description__OnChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5846f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_AprLayout___ctor__);
		    DAT_ram_00a5846f = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_AprLayout___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x6C88", Offset = "0x6C88", VA = "0x6C88")]
		public Description()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Components_Description___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58470 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58470 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
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

		}

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI[] _descriptions;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameAssetViewRawImage[] _aprs;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x24")]
		private GuideConfig _guideConfig;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideConfig ---
		void Gameplay_Tutorial_Guide_View_Components_Description__get_GuideConfig
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x24)) {
		    *(int *)(param1 + 0x24) = param2;
		    Gameplay_Tutorial_Guide_View_Components_Description__set_GuideConfig(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_GuideConfig ---
		void Gameplay_Tutorial_Guide_View_Components_Description__set_GuideConfig
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  int iVar11;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a5846e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ContentStringMessage___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_AprLayout__set_CurrentState__);
		    DAT_ram_00a5846e = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) != 0) {
		    iVar3 = *(int *)(param1 + 0x1c);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      iVar4 = 0;
		      do {
		        piVar6 = *(int **)(iVar3 + iVar4 * 4 + 0x10);
		        iVar5 = System_Linq_Enumerable__Count_object_
		                          (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x10) + 0x28),
		                           Method_System_Linq_Enumerable_First_ContentStringMessage___);
		        iVar11 = *piVar6;
		        (**(code **)((ulonglong)*(uint *)(iVar11 + 0x2d0) * 4))
		                  (piVar6,*(undefined4 *)(iVar5 + 0x10),*(undefined4 *)(iVar11 + 0x2d4));
		        iVar4 = iVar4 + 1;
		      } while (iVar4 < *(int *)(iVar3 + 0xc));
		    }
		    iVar3 = *(int *)(param1 + 0x20);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        param1_00 = *(undefined4 *)(iVar3 + iVar7 * 4 + 0x10);
		        uVar10 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                           (param1_00,0);
		        iVar4 = *(int *)(param1 + 0x24);
		        if (DAT_ram_00a58495 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___)
		          ;
		          Mono_Security_ASN1__get_Item(&StringLiteral_28759);
		          DAT_ram_00a58495 = '\x01';
		        }
		        uVar9 = StringLiteral_28759;
		        iVar5 = *(int *)(iVar4 + 0x14);
		        if (iVar5 == 0) {
		          iVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                            (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20),0);
		          if (iVar5 == 0) {
		            uVar9 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20);
		          }
		          iVar5 = func_ii_5995(uVar9,Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		          *(int *)(iVar4 + 0x14) = iVar5;
		        }
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar10,(uint)(*(int *)(iVar5 + 0x10) != 0),0);
		        iVar4 = *(int *)(param1 + 0x24);
		        if (DAT_ram_00a58495 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___)
		          ;
		          Mono_Security_ASN1__get_Item(&StringLiteral_28759);
		          DAT_ram_00a58495 = '\x01';
		        }
		        uVar10 = StringLiteral_28759;
		        iVar5 = *(int *)(iVar4 + 0x14);
		        if (iVar5 == 0) {
		          iVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                            (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20),0);
		          if (iVar5 == 0) {
		            uVar10 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20);
		          }
		          iVar5 = func_ii_5995(uVar10,Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		          *(int *)(iVar4 + 0x14) = iVar5;
		        }
		        if (*(int *)(iVar5 + 0x10) != 0) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar4 = *piVar6;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		                puVar2 = (uint *)(piVar8[1] * 8 + iVar4 + 0x178);
		                goto code_r0x80ef0702;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ef0702:
		          uVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		          uVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar10,0);
		          iVar4 = *(int *)(param1 + 0x24);
		          if (DAT_ram_00a58495 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		            Mono_Security_ASN1__get_Item(&StringLiteral_28759);
		            DAT_ram_00a58495 = '\x01';
		          }
		          uVar9 = StringLiteral_28759;
		          iVar5 = *(int *)(iVar4 + 0x14);
		          if (iVar5 == 0) {
		            iVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                              (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20),0);
		            if (iVar5 == 0) {
		              uVar9 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x20);
		            }
		            iVar5 = func_ii_5995(uVar9,Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		            *(int *)(iVar4 + 0x14) = iVar5;
		          }
		          uVar10 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                             (uVar10,*(undefined4 *)(iVar5 + 0x10),0);
		          uVar10 = Core_Extensions_Dict_AprDicExt__GetAnimation1024AssetId(uVar10,0);
		          Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar10,0);
		        }
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < *(int *)(iVar3 + 0xc));
		    }
		    iVar7 = *(int *)(param1 + 0x24);
		    if (DAT_ram_00a58495 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		      Mono_Security_ASN1__get_Item(&StringLiteral_28759);
		      DAT_ram_00a58495 = '\x01';
		    }
		    uVar10 = StringLiteral_28759;
		    iVar3 = *(int *)(iVar7 + 0x14);
		    if (iVar3 == 0) {
		      iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x20),0);
		      if (iVar3 == 0) {
		        uVar10 = *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x20);
		      }
		      iVar3 = func_ii_5995(uVar10,Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		      *(int *)(iVar7 + 0x14) = iVar3;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,*(undefined4 *)(iVar3 + 0x14),
		               Method_UI_MonoBehaviourWithStates_AprLayout__set_CurrentState__);
		  }
		  return;
		}
		*/

}
