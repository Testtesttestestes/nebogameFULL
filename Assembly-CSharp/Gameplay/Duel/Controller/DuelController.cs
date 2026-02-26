using System;
using Core.Data.Skills;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Duel;
using ServicesNamespace;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	public class DuelController : AbstractController<DuelModel, Gameplay.Duel.Events.DuelEvents>
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003274")]
		[Address(RVA = "0x82C9", Offset = "0x82C9", VA = "0x82C9")]
		public DuelController(DuelModel model, Gameplay.Duel.Events.DuelEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Controller_DuelController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57be6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_DuelCombat_TypeInfo);
		    DAT_ram_00a57be6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = unnamed_function_1417(Gameplay_Duel_DuelCombat_TypeInfo);
		  if (DAT_ram_00a57bc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a57bc1 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (iVar1,param2_00,param3,param4,0,
		             Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(undefined1 *)(iVar1 + 0x28) = 0;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (iVar1,
		             Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__TryRun__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x82CA", Offset = "0x82CA", VA = "0x82CA")]
		public void StartCombatImmediately()
		{
		/* --- GHIDRA: StartCombatImmediately ---
		void Gameplay_Duel_Controller_DuelController__StartCombatImmediately
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  undefined4 uVar2;
		  float fVar3;
		  longlong lVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  undefined4 param4;
		  longlong lVar8;
		  undefined8 uVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a57be7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_DuelCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57be7 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar10 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x218);
		        goto code_r0x80e33d87;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80e33d87:
		  uVar9 = CONCAT44(in_register_20000004,piVar5);
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		  uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar10 = 0;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e33e0b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80e33e0b:
		  uVar9 = CONCAT44(uVar2,piVar5);
		  iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		  uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  if (iVar6 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x218);
		          goto code_r0x80e33eb3;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80e33eb3:
		    uVar9 = CONCAT44(uVar2,piVar5);
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		    uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar10 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e33f37;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80e33f37:
		    uVar9 = CONCAT44(uVar2,piVar5);
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		    uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(Gameplay_Duel_DuelCombat_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar5 + 0xb8)) &&
		         (*(int *)(*(int *)(*piVar5 + 100) +
		                   (uint)*(byte *)(Gameplay_Duel_DuelCombat_TypeInfo + 0xb8) * 4 + -4) ==
		          Gameplay_Duel_DuelCombat_TypeInfo)) {
		        if (DAT_ram_00a57bbf == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		                    );
		          DAT_ram_00a57bbf = '\x01';
		        }
		        if ((piVar5[5] != 0) && (fVar3 = func_ii_7103(piVar5[5],0), 0.0 < fVar3)) {
		          return;
		        }
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar10 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x218);
		          goto code_r0x80e3404f;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80e3404f:
		    uVar9 = CONCAT44(uVar2,piVar5);
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		    uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar10 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0xd8);
		          goto code_r0x80e340d1;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_ICombatManager_TypeInfo,3);
		code_r0x80e340d1:
		    uVar9 = CONCAT44(uVar2,piVar5);
		    (**(code **)((ulonglong)*puVar1 * 4))(uVar9,puVar1[1]);
		    uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar7 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__LoadScene(uVar7,2,0);
		  }
		  lVar8 = *(longlong *)(param2 + 0x18);
		  uVar9 = CONCAT44(uVar2,param1);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar9,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar6 + 0x10) + 8),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar6 + 8);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(undefined4 *)(iVar6 + 8);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  uVar9 = *(undefined8 *)(param2 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = Utils_StringUtils___cctor(uVar9,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar3,0);
		  iVar6 = unnamed_function_1417(Gameplay_Duel_DuelCombat_TypeInfo);
		  if (DAT_ram_00a57bc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a57bc1 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (iVar6,uVar7,param3_00,param4,uVar2,
		             Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(bool *)(iVar6 + 0x28) = lVar8 == lVar4;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (iVar6,
		             Method_Gameplay_Combat_AbstractCombat_CombatModel__CombatEvents__DuelCombatController__DuelCombatViewMediator__OneOnOneCombatView__TryRun__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003276")]
		[Address(RVA = "0x82CB", Offset = "0x82CB", VA = "0x82CB")]
		private void StartListeningForCombatStart(DuelStateInfo state)
		{
		/* --- GHIDRA: StartListeningForCombatStart ---
		void Gameplay_Duel_Controller_DuelController__StartListeningForCombatStart
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57be8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_GetDuelInfoResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57be8 = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__ServerEventHandler
		                        (*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_GetDuelInfoResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003277")]
		[Address(RVA = "0x82CC", Offset = "0x82CC", VA = "0x82CC")]
		public void GetDuelsInfo(ulong opponentId)
		{
		/* --- GHIDRA: GetDuelsInfo ---
		void Gameplay_Duel_Controller_DuelController__GetDuelsInfo(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a57be9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoGetDuelsInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDuelsInfoAns_Types_DuelInfo__get_Item__
		              );
		    DAT_ram_00a57be9 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Duel_ProtoGetDuelsInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Duel_ProtoGetDuelsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (param1_00[3],0,
		                     Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDuelsInfoAns_Types_DuelInfo__get_Item__
		                    );
		  if (DAT_ram_00a57bd8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Model_DuelModel_DuelData_TypeInfo);
		    DAT_ram_00a57bd8 = '\x01';
		  }
		  iVar3 = unnamed_function_1417(Gameplay_Duel_Model_DuelModel_DuelData_TypeInfo);
		  *(int *)(iVar3 + 0xc) = iVar2;
		  uVar4 = Core_Extensions_Dict_DictExt__GetHordeMonstersByMainMonsterIdSorted
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar2 + 0xc),0);
		  *(undefined4 *)(iVar3 + 8) = uVar4;
		  *(int *)(iVar1 + 0x18) = iVar3;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003278")]
		[Address(RVA = "0x82CD", Offset = "0x82CD", VA = "0x82CD")]
		private void GetDuelInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDuelInfoResultHandler ---
		void Gameplay_Duel_Controller_DuelController__GetDuelInfoResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_GetUserInfoResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bea = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__GetDuelsInfo(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_GetUserInfoResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003279")]
		[Address(RVA = "0x82CE", Offset = "0x82CE", VA = "0x82CE")]
		public void GetUserInfo(params ulong[] userIds)
		{
		/* --- GHIDRA: GetUserInfo ---
		void Gameplay_Duel_Controller_DuelController__GetUserInfo(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  longlong lVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 param1_00;
		  longlong lVar9;
		  int *piVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57beb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_DuelUserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoGetUserInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_DuelUserInfo__GetEnumerator__);
		    DAT_ram_00a57beb = '\x01';
		  }
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Duel_ProtoGetUserInfoAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Duel_ProtoGetUserInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar7[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_DuelUserInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar1 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e34548;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e347c3:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e347cb;
		    }
		code_r0x80e34548:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar1,piVar7,puVar1[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e347c3;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80e34814;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		        if (System_Collections_Generic_IEnumerator_DuelUserInfo__TypeInfo == *piVar10) {
		          puVar1 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e3462e;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_DuelUserInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e34742:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e347cb;
		    }
		code_r0x80e3462e:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar1,piVar7,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e34742;
		    lVar9 = *(longlong *)(iVar8 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e347cb;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar6 = unnamed_function_184054
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                       *(undefined4 *)(iVar2 + 8),0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e347cb;
		    }
		    uVar3 = *(undefined4 *)(*param1 + 0x104);
		    param1_00 = *(undefined4 *)(*param1 + 0x100);
		    if (lVar9 == lVar6) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(param1_00,param1,uVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e347cb;
		      }
		      piVar7 = (int *)(iVar2 + 0x10);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(param1_00,param1,uVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) break;
		      piVar7 = (int *)(iVar2 + 0x14);
		    }
		    *(int *)(*piVar7 + 0x10) = iVar8;
		  } while( true );
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e347cb:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar8 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e34814:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar11 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80e3488c;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e3488c:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327A")]
		[Address(RVA = "0x82CF", Offset = "0x82CF", VA = "0x82CF")]
		private void GetUserInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserInfoResultHandler ---
		void Gameplay_Duel_Controller_DuelController__GetUserInfoResultHandler
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_AttackUserResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bec = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__GetUserInfo
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_AttackUserResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327B")]
		[Address(RVA = "0x82D0", Offset = "0x82D0", VA = "0x82D0")]
		public void AttackUser(ulong opponentId, uint attackType)
		{
		/* --- GHIDRA: AttackUser ---
		void Gameplay_Duel_Controller_DuelController__AttackUser(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57bed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedAttackErrors__ExpectedRequirementsErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoAttackUserAns_TypeInfo);
		    DAT_ram_00a57bed = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Duel_ProtoAttackUserAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Duel_ProtoAttackUserAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                        );
		  Core_Errors_Expected_ExpectedRequirementsErrors___ctor(param1_00,param2_00,param3_00,0);
		  Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		            (param1_01[3],0,0,param1_00,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedAttackErrors__ExpectedRequirementsErrors___
		            );
		  if (0 < param1_01[4]) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Core_Extensions_Dict_DictExt__GetDuelTypeDic
		                      (*(undefined4 *)(iVar1 + 0xc),param1_01[4],0);
		    if (*(int *)(iVar1 + 0xc) != 0) {
		      Gameplay_Duel_View_AttackDeclinedDialogWindow__HandleContent(iVar1,iVar1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327C")]
		[Address(RVA = "0x82D1", Offset = "0x82D1", VA = "0x82D1")]
		private void AttackUserResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AttackUserResultHandler ---
		void Gameplay_Duel_Controller_DuelController__AttackUserResultHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_PayOffResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bee = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__Attack(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Duel_Controller_DuelController_PayOffResultHandler__,0
		            );
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x82D2", Offset = "0x82D2", VA = "0x82D2")]
		public void PayOff(ulong opponentId)
		{
		/* --- GHIDRA: PayOff ---
		void Gameplay_Duel_Controller_DuelController__PayOff(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57bef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedRequirementsErrors__ExpectedPayoffErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoPayOffAns_TypeInfo);
		    DAT_ram_00a57bef = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                        );
		  Core_Errors_Expected_ExpectedRequirementsErrors___ctor(param1_00,param2_00,param3_00,0);
		  if ((param1_01 != (int *)0x0) && (Protocol_Duel_ProtoPayOffAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Duel_ProtoPayOffAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		            (param1_01[3],0,param1_00,0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedRequirementsErrors__ExpectedPayoffErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x82D3", Offset = "0x82D3", VA = "0x82D3")]
		private void PayOffResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: PayOffResultHandler ---
		void Gameplay_Duel_Controller_DuelController__PayOffResultHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_GetDuelStateInfoResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bf0 = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__PayOff(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_GetDuelStateInfoResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x82D4", Offset = "0x82D4", VA = "0x82D4")]
		public void GetDuelStateInfo()
		{
		/* --- GHIDRA: GetDuelStateInfo ---
		void Gameplay_Duel_Controller_DuelController__GetDuelStateInfo
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57bf1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoGetDuelStateInfoAns_TypeInfo);
		    DAT_ram_00a57bf1 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Duel_ProtoGetDuelStateInfoAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Duel_ProtoGetDuelStateInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Duel_Controller_DuelController__UserStateFlagsChangedEventHandler
		            (param1,param1_00[3],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x82D5", Offset = "0x82D5", VA = "0x82D5")]
		private void GetDuelStateInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDuelStateInfoResultHandler ---
		void Gameplay_Duel_Controller_DuelController__GetDuelStateInfoResultHandler
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bf2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_PerformIntelligenceResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bf2 = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__GetDuelStateInfo
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_PerformIntelligenceResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x82D6", Offset = "0x82D6", VA = "0x82D6")]
		public void PerformIntelligence(ulong opponentId, uint intelligenceType)
		{
		/* --- GHIDRA: PerformIntelligence ---
		void Gameplay_Duel_Controller_DuelController__PerformIntelligence
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57bf3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_ProtoPerformIntelligenceAns_TypeInfo);
		    DAT_ram_00a57bf3 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003282")]
		[Address(RVA = "0x82D7", Offset = "0x82D7", VA = "0x82D7")]
		private void PerformIntelligenceResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: PerformIntelligenceResultHandler ---
		void Gameplay_Duel_Controller_DuelController__PerformIntelligenceResultHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57bf4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_UnsubscribeOpponentResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57bf4 = '\x01';
		  }
		  param1_00 = ServicesNamespace_DuelService__PerformIntelligence
		                        (*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Duel_Controller_DuelController_UnsubscribeOpponentResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x82D8", Offset = "0x82D8", VA = "0x82D8")]
		public void UnsubscribeOpponent(ulong opponentId)
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x82D9", Offset = "0x82D9", VA = "0x82D9")]
		private void UnsubscribeOpponentResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UnsubscribeOpponentResultHandler ---
		void Gameplay_Duel_Controller_DuelController__UnsubscribeOpponentResultHandler
		               (int param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57bf5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&bool___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_GetOpponentSkillsResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_GetPlayerSkillsResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57bf5 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(bool___TypeInfo,1);
		  uVar2 = ServicesNamespace_MainService__ServerEventHandler(*(undefined4 *)(param1 + 0x1c),param2,0)
		  ;
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar1,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Duel_Controller_DuelController_GetPlayerSkillsResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar2 = ServicesNamespace_MainService__ServerEventHandler(*(undefined4 *)(param1 + 0x1c),param3,0)
		  ;
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar1,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Duel_Controller_DuelController_GetOpponentSkillsResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x82DA", Offset = "0x82DA", VA = "0x82DA")]
		public void GetUserSkills(ulong playerId, ulong opponentId)
		{
		/* --- GHIDRA: GetUserSkills ---
		void Gameplay_Duel_Controller_DuelController__GetUserSkills
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a57bf6 == '\0') {
		    Mono_Security_ASN1__get_Item(&bool___TypeInfo);
		    DAT_ram_00a57bf6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x10);
		  uVar2 = Gameplay_Duel_Controller_DuelController__GetOpponentSkillsResultHandler
		                    (param1,param2,param1);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = bool___TypeInfo;
		  iVar1 = *(int *)(param2 + 0xc);
		  if ((iVar1 != 0) && (iVar3 = func_ii_1082(iVar1,bool___TypeInfo), iVar3 == 0)) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(char *)(iVar3 + 0x10) == '\0') {
		    *(char *)(iVar3 + 0x10) = '\x01';
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x82DB", Offset = "0x82DB", VA = "0x82DB")]
		private void GetPlayerSkillsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetPlayerSkillsResultHandler ---
		void Gameplay_Duel_Controller_DuelController__GetPlayerSkillsResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a57bf7 == '\0') {
		    Mono_Security_ASN1__get_Item(&bool___TypeInfo);
		    DAT_ram_00a57bf7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  uVar2 = Gameplay_Duel_Controller_DuelController__GetOpponentSkillsResultHandler
		                    (param1,param2,param1);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = bool___TypeInfo;
		  iVar1 = *(int *)(param2 + 0xc);
		  if ((iVar1 != 0) && (iVar3 = func_ii_1082(iVar1,bool___TypeInfo), iVar3 == 0)) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(char *)(iVar3 + 0x10) == '\0') {
		    *(char *)(iVar3 + 0x10) = '\x01';
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x82DC", Offset = "0x82DC", VA = "0x82DC")]
		private void GetOpponentSkillsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetOpponentSkillsResultHandler ---
		undefined4
		Gameplay_Duel_Controller_DuelController__GetOpponentSkillsResultHandler
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57bf8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserSkillsData_TypeInfo);
		    DAT_ram_00a57bf8 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoGetUserSkillsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = unnamed_function_1417(Core_Data_UserSkillsData_TypeInfo);
		  uVar1 = Core_Extensions_Dict_ProtoCastExt__ToUserInfo(param1_01,0);
		  Core_Data_UserSkillsData__get_RawData(param1_00,uVar1,0);
		  uVar1 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress
		                    (*(undefined4 *)(param1_00 + 0x18),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x82DD", Offset = "0x82DD", VA = "0x82DD")]
		private SkillCollection ConstructSkills(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ConstructSkills ---
		void Gameplay_Duel_Controller_DuelController__ConstructSkills
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param2 + 0x10) == '\0') {
		    *(char *)(param2 + 0x10) = '\x01';
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x82DE", Offset = "0x82DE", VA = "0x82DE")]
		private void HandleChecklist(bool[] checkList)
		{
		/* --- GHIDRA: HandleChecklist ---
		void Gameplay_Duel_Controller_DuelController__HandleChecklist
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Duel_Controller_DuelController__UserStateFlagsChangedEventHandler(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x82DF", Offset = "0x82DF", VA = "0x82DF")]
		private void NewDuelEventHandler(DuelStateInfo state)
		{
		/* --- GHIDRA: NewDuelEventHandler ---
		void Gameplay_Duel_Controller_DuelController__NewDuelEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x82E0", Offset = "0x82E0", VA = "0x82E0")]
		private void PaidOffEventHandler(ProtoDuelPaidOffEvt evt)
		{
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x82E1", Offset = "0x82E1", VA = "0x82E1")]
		private void UserStateFlagsChangedEventHandler(ProtoDuelUserStateChangedEvt evt)
		{
		/* --- GHIDRA: UserStateFlagsChangedEventHandler ---
		void Gameplay_Duel_Controller_DuelController__UserStateFlagsChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float param2_00;
		  uint *puVar4;
		  longlong lVar5;
		  int *param1_00;
		  undefined8 uVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a57bf9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57bf9 = '\x01';
		  }
		  uVar6 = CONCAT44(in_register_20000004,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (uVar6,*(undefined4 *)(*param1 + 0x114));
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    uVar6 = CONCAT44(uVar3,*(undefined4 *)(iVar2 + 0x20));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))(uVar6,*(undefined4 *)(iVar2 + 0x14));
		    uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  }
		  Gameplay_Duel_Controller_DuelController__StartCombatImmediately(param1,param2,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar3,param1),*(undefined4 *)(*param1 + 0x104));
		  uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,0.0,0);
		  uVar6 = *(undefined8 *)(param2 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar6,0);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,param2_00,0);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		  lVar7 = *(longlong *)(param2 + 0x18);
		  uVar6 = CONCAT44(uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar6,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 8),0);
		  if (lVar7 == lVar5) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + iVar2 + 0x228);
		          goto code_r0x80e34e19;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2d);
		code_r0x80e34e19:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar3,param1_00),puVar4[1]);
		    Core_Gameplay_Managers_DuelManager__ShowDuelWindow(uVar3,param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x82E2", Offset = "0x82E2", VA = "0x82E2")]
		private void HandleDuelState(DuelStateInfo state)
		{
		/* --- GHIDRA: HandleDuelState ---
		void Gameplay_Duel_Controller_DuelController__HandleDuelState
		               (undefined4 param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a57bfa == '\0') {
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a57bfa = '\x01';
		  }
		  Gameplay_Duel_Controller_DuelController__StartListeningForCombatStart(param1,param3,param1);
		  Gameplay_Duel_Controller_DuelController__UnsubscribeOpponentResultHandler
		            (param1,param2,param3,param1);
		  param2_00 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,2);
		  *(undefined8 *)(param2_00 + 0x18) = param3;
		  *(undefined8 *)(param2_00 + 0x10) = param2;
		  Gameplay_Duel_Controller_DuelController__GetDuelInfoResultHandler(param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x82E3", Offset = "0x82E3", VA = "0x82E3")]
		public void RequestNecessaryUserInfos(ulong playerId, ulong opponentId)
		{
		/* --- GHIDRA: RequestNecessaryUserInfos ---
		void Gameplay_Duel_Controller_DuelController__RequestNecessaryUserInfos
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57bfb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelUserStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DuelStateInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_NewDuelEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_PaidOffEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_UserStateFlagsChangedEventHandler__);
		    DAT_ram_00a57bfb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_DuelStateInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Duel_Controller_DuelController_NewDuelEventHandler__,0);
		  ServicesNamespace_DuelService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Duel_Controller_DuelController_PaidOffEventHandler__,0);
		  ServicesNamespace_DuelService__remove_NewDuelEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoDuelUserStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Duel_Controller_DuelController_UserStateFlagsChangedEventHandler__,0);
		  ServicesNamespace_DuelService__remove_PaidOffEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x82E4", Offset = "0x82E4", VA = "0x82E4")]
		private void SubscribeToEvents()
		{
		/* --- GHIDRA: SubscribeToEvents ---
		void Gameplay_Duel_Controller_DuelController__SubscribeToEvents(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDuelUserStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DuelStateInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_NewDuelEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_PaidOffEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelController_UserStateFlagsChangedEventHandler__);
		    DAT_ram_00a57bfc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_DuelStateInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Duel_Controller_DuelController_NewDuelEventHandler__,0);
		  ServicesNamespace_DuelService__add_NewDuelEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoDuelPaidOffEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Duel_Controller_DuelController_PaidOffEventHandler__,0);
		  ServicesNamespace_DuelService__add_PaidOffEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoDuelUserStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Duel_Controller_DuelController_UserStateFlagsChangedEventHandler__,0);
		  ServicesNamespace_DuelService__add_UserStateFlagsChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x82E5", Offset = "0x82E5", VA = "0x82E5")]
		private void UnsubscribeFromEvents()
		{
		/* --- GHIDRA: UnsubscribeFromEvents ---
		void Gameplay_Duel_Controller_DuelController__UnsubscribeFromEvents
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Duel_Controller_DuelController__RequestNecessaryUserInfos(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x82E6", Offset = "0x82E6", VA = "0x82E6", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Duel_Controller_DuelController__HandleRun(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Duel_Controller_DuelController__SubscribeToEvents(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x82E7", Offset = "0x82E7", VA = "0x82E7", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Duel_Controller_DuelController__HandleStop(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bfd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_DuelModel__DuelEvents__Dispose__);
		    DAT_ram_00a57bfd = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_DuelModel__DuelEvents__Dispose__);
		  *(undefined8 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x82E8", Offset = "0x82E8", VA = "0x82E8", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Duel_Controller_DuelController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57bfe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen___ctor__
		              );
		    DAT_ram_00a57bfe = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param5;
		  return;
		}
		*/

		}

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x18")]
		private DuelService _duelService;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x1C")]
		private MainService _mainService;
	}
}
