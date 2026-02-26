using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller
{
	// Token: 0x0200120E RID: 4622
	[Token(Token = "0x200120E")]
	public class EnergyRegenAdPlacementController : AbstractAdPlacementController<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementEvents>
	{
		// Token: 0x06006DA7 RID: 28071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0xB867", Offset = "0xB867", VA = "0xB867")]
		public EnergyRegenAdPlacementController(EnergyRegenAdPlacementModel model, EnergyRegenAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Controller_EnergyRegenAdPlacementController___ctor
		          (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  uint uVar5;
		  float fVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *param1_00;
		  int *param1_01;
		  uint uVar9;
		  int iVar10;
		  undefined1 local_5;
		  undefined1 local_4;
		  undefined1 local_3;
		  undefined1 local_2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5a78c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22942);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26426);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24725);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22946);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24706);
		    DAT_ram_00a5a78c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8126ac6b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4);
		code_r0x8126ac6b:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar3 + 0x10);
		  uVar2 = 0;
		  iVar10 = *param1_00;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x140);
		        goto code_r0x8126ad0c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126ad0c:
		  iVar10 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  iVar10 = *(int *)(*(int *)(iVar10 + 0x14) + 0x1c);
		  if (iVar10 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar10 = *(int *)(iVar10 + 0xc);
		    if (iVar10 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      fVar6 = func_ii_7103(iVar10,0);
		      uVar2 = (uint)(0.0 < fVar6);
		    }
		  }
		  bVar1 = param2 == iVar3;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x8126adbd;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8126adbd:
		  uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  iVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar7,StringLiteral_22946,0);
		  if (iVar3 == 0) {
		    uVar9 = 1;
		  }
		  else {
		    iVar10 = *param1_00;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8 + 4) * 8 + iVar10 + 0x160);
		          goto code_r0x8126ae4f;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8126ae4f:
		    uVar9 = 0;
		    uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    iVar10 = *param1_00;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8 + 4) * 8 + iVar10 + 0x140);
		          goto code_r0x8126aed5;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126aed5:
		    uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    uVar8 = func_ii_7112(uVar8,0);
		    uVar9 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                      (uVar7,iVar3,uVar8,0);
		  }
		  if ((uVar2 & uVar9 & bVar1 & uVar5) == 0) {
		    iVar3 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    *(undefined4 *)(iVar3 + 0x10) = StringLiteral_7314;
		    local_1 = (undefined1)uVar5;
		    uVar7 = func_ii_1081(DAT_ram_00a66944,&local_1);
		    uVar7 = func_ii_4419(StringLiteral_24706,uVar7,0);
		    *(undefined4 *)(iVar3 + 0x14) = uVar7;
		    local_2 = bVar1;
		    uVar7 = func_ii_1081(DAT_ram_00a66944,&local_2);
		    uVar7 = func_ii_4419(StringLiteral_24725,uVar7,0);
		    *(undefined4 *)(iVar3 + 0x18) = uVar7;
		    local_3 = (undefined1)uVar9;
		    uVar7 = func_ii_1081(DAT_ram_00a66944,&local_3);
		    uVar7 = func_ii_4419(StringLiteral_26426,uVar7,0);
		    *(undefined4 *)(iVar3 + 0x1c) = uVar7;
		    local_4 = (undefined1)uVar2;
		    uVar7 = func_ii_1081(DAT_ram_00a66944,&local_4);
		    local_5 = 0;
		    uVar8 = func_ii_1081(DAT_ram_00a66944,&local_5);
		    uVar7 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_22942,uVar7,uVar8,0);
		    *(undefined4 *)(iVar3 + 0x20) = uVar7;
		    uVar7 = System_Single__ToString(iVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar7,0);
		    uVar7 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar7,0,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		  }
		  else {
		    uVar2 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x268);
		          goto code_r0x8126b0a1;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x8126b0a1:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    uVar7 = *(undefined4 *)(iVar3 + 0x10);
		    iVar10 = *param1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar10 + 0x104));
		    uVar7 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController__DestroyAllProviders
		                      (uVar7,*(undefined4 *)(iVar3 + 0xc),iVar10);
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0xB868", Offset = "0xB868", VA = "0xB868")]
		public WaitForCallBack<bool> IsAdAvailable(Resources resourceId)
		{
		/* --- GHIDRA: IsAdAvailable ---
		void Core_Gameplay_Managers_Ad_Placements_EnergyRegen_Controller_EnergyRegenAdPlacementController__IsAdAvailable
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a78d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a78d = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

			return null;
		}
	}
}
