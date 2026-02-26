using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Combat;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Boss;
using ServicesNamespace;
using Utils;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA4 RID: 2980
	[Token(Token = "0x2000BA4")]
	public class BossController : AbstractController<BossModel, BossEvents>
	{
		// Token: 0x060048D1 RID: 18641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x9746", Offset = "0x9746", VA = "0x9746")]
		public BossController(BossModel model, BossEvents events)
		{
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x1B66", Offset = "0x1B66", VA = "0x1B66")]
		public BossInstance AddBoss(InstanceInfo instanceInfo)
		{
		/* --- GHIDRA: AddBoss ---
		void Gameplay_Boss_Controller_BossController__AddBoss(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float param2_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_01;
		  int iVar2;
		  undefined8 param1_00;
		  
		  if (DAT_ram_00a5787e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInfo_TypeInfo);
		    DAT_ram_00a5787e = '\x01';
		  }
		  *(int *)(param1 + 0x28) = param2;
		  if (*(int *)(param1 + 0x30) == 0) {
		    param4 = *(undefined4 *)(param1 + 0xc);
		    param3_00 = *(undefined4 *)(param2 + 0x1c);
		    param2_01 = *(undefined4 *)(param2 + 0x18);
		    uVar1 = unnamed_function_1417(Gameplay_Boss_Model_BossInfo_TypeInfo);
		    Gameplay_Boss_Model_BossInfo__set_CultSpells(uVar1,param2_01,param3_00,param4,param1);
		    *(undefined4 *)(param1 + 0x30) = uVar1;
		    param2 = *(int *)(param1 + 0x28);
		  }
		  iVar2 = *(int *)(param2 + 0x24);
		  if (DAT_ram_00a5787f == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5787f = '\x01';
		  }
		  *(int *)(param1 + 0x38) = iVar2;
		  param1_00 = *(undefined8 *)(iVar2 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_00,0);
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,param2_00,0);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x1B62", Offset = "0x1B62", VA = "0x1B62")]
		public void RemoveBoss(BossInstance instance)
		{
		/* --- GHIDRA: RemoveBoss ---
		int * Gameplay_Boss_Controller_BossController__RemoveBoss(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x9747", Offset = "0x9747", VA = "0x9747")]
		private void CaptainInvitesChangedEvent()
		{
		/* --- GHIDRA: CaptainInvitesChangedEvent ---
		void Gameplay_Boss_Controller_BossController__CaptainInvitesChangedEvent
		               (int *param1,undefined4 param2)
		
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

		// Token: 0x060048D5 RID: 18645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x9748", Offset = "0x9748", VA = "0x9748")]
		private void MyTeamsInfoChangedEvent()
		{
		/* --- GHIDRA: MyTeamsInfoChangedEvent ---
		void Gameplay_Boss_Controller_BossController__MyTeamsInfoChangedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a578af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceInfoEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterHealthEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CreateRequestEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnCreateRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnInstanceInfoEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackServerCancelationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossController_BossServiceOnMonsterHealthChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_CurrentIsleChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_HandleServiceReadyToListen__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578af = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_InstanceInfoEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnInstanceInfoEvent__,0);
		  ServicesNamespace_BossService__get_ServiceId(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MonsterHealthEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMonsterHealthChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_TeamInfoChangedEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_CreateRequestEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnCreateRequestEvent__,0);
		  ServicesNamespace_BossService__remove_ActiveTeamTimeoutEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MinionAttackEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackEvent__,0);
		  ServicesNamespace_BossService__remove_MercenaryTeamsChangedEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackServerCancelationEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_MinionAttackEvent(uVar5,uVar2,0);
		  uVar2 = ServicesNamespace_BossService__GetPossibleMercenaries(*(undefined4 *)(param1 + 0x18),0);
		  uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Boss_Controller_BossController_HandleServiceReadyToListen__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80df39b6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80df39b6:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar2,param1,Method_Gameplay_Boss_Controller_BossController_CurrentIsleChangedEvent__
		               ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ulong__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar2 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x9749", Offset = "0x9749", VA = "0x9749", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Boss_Controller_BossController__HandleRun
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x20) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x974A", Offset = "0x974A", VA = "0x974A")]
		private void CurrentIsleChangedEvent(ulong id)
		{
		/* --- GHIDRA: CurrentIsleChangedEvent ---
		void Gameplay_Boss_Controller_BossController__CurrentIsleChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x974B", Offset = "0x974B", VA = "0x974B")]
		private void HandleServiceReadyToListen(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceReadyToListen ---
		void Gameplay_Boss_Controller_BossController__HandleServiceReadyToListen
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a578b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceInfoEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterHealthEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CreateRequestEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MinionAttackEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnCreateRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnInstanceInfoEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackServerCancelationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossController_BossServiceOnMonsterHealthChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_CurrentIsleChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a578b0 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_InstanceInfoEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnInstanceInfoEvent__,0);
		  ServicesNamespace_BossService__add_InstanceInfoEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MonsterHealthEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMonsterHealthChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_MonsterHealthChangedEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_CreateRequestEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnCreateRequestEvent__,0);
		  ServicesNamespace_BossService__add_CreateRequestEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MinionAttackEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackEvent__,0);
		  ServicesNamespace_BossService__add_MinionAttackEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_MinionAttackServerCancelationEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_BossServiceOnMinionAttackServerCancelationEvent__
		             ,0);
		  ServicesNamespace_BossService__add_MinionAttackServerCancelationEvent(uVar5,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80df3cd5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80df3cd5:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  uVar5 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar2,param1,Method_Gameplay_Boss_Controller_BossController_CurrentIsleChangedEvent__
		               ,0);
		  iVar6 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ulong__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar2 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D9")]
		[Address(RVA = "0x974C", Offset = "0x974C", VA = "0x974C", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Boss_Controller_BossController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_BossModel__BossEvents__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossInstance__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossInstance__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossInstance__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInstance__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossInstance__TypeInfo);
		    DAT_ram_00a578b1 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Values__);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BossInstance__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (param1_00,uVar2,Method_System_Collections_Generic_List_BossInstance___ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param1_00,
		             Method_System_Collections_Generic_List_BossInstance__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossInstance__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df3ee1;
		    }
		    if (iVar3 == 0) goto code_r0x80df3f37;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39a,param1,local_8._4_4_,
		               auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80df3ee1:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80df3f37:
		      DAT_ram_009d3e38 = 0;
		      MVC_AbstractController_object__object____ctor
		                (param1,Method_MVC_AbstractController_BossModel__BossEvents__Dispose__);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39b,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DA")]
		[Address(RVA = "0x974D", Offset = "0x974D", VA = "0x974D", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Boss_Controller_BossController__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a578b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_HandleServiceGetInstanceList__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578b2 = '\x01';
		  }
		  param1_00 = ServicesNamespace_BossService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Boss_Controller_BossController_HandleServiceGetInstanceList__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x974E", Offset = "0x974E", VA = "0x974E")]
		public void GetInstanceList()
		{
		/* --- GHIDRA: GetInstanceList ---
		void Gameplay_Boss_Controller_BossController__GetInstanceList
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 uVar1;
		  longlong lVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *param1_00;
		  int iVar8;
		  longlong lVar9;
		  uint uVar10;
		  undefined4 local_4;
		  
		  uVar1 = param2;
		  if (DAT_ram_00a578b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_BeginBattleServiceHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_BossInstance__long__int__ICombat___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_BossInstance__long__int__ICombat__TypeInfo);
		    DAT_ram_00a578b3 = '\x01';
		  }
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  local_4 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar10 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *param1_00;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x1e0);
		        goto code_r0x80df1851;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df1851:
		  uVar1 = CONCAT44(uVar6,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar1);
		  uVar6 = 0;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  lVar9 = *(longlong *)(iVar8 + 0x18);
		  if (0 < lVar9) {
		    if (DAT_ram_00a5788d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		      DAT_ram_00a5788d = '\x01';
		    }
		    lVar2 = lVar9;
		    iVar5 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                      (*(undefined4 *)(iVar8 + 0xc),lVar9,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		    uVar7 = (undefined4)((ulonglong)lVar2 >> 0x20);
		    uVar6 = 0;
		    if (iVar5 != 0) {
		      uVar6 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                        (*(undefined4 *)(iVar8 + 0xc),lVar9,
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                        );
		      uVar7 = (undefined4)((ulonglong)lVar9 >> 0x20);
		    }
		  }
		  iVar8 = Core_Gameplay_Managers_BossManager__ShowBossMinionWindow(uVar4,uVar6,0,&local_4,0);
		  if (iVar8 != 0) {
		    uVar6 = 0;
		    iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x104)));
		    lVar9 = *(longlong *)(iVar8 + 0x18);
		    if (0 < lVar9) {
		      if (DAT_ram_00a5788d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		        DAT_ram_00a5788d = '\x01';
		      }
		      iVar5 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                        (*(undefined4 *)(iVar8 + 0xc),lVar9,
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                        );
		      uVar6 = 0;
		      if (iVar5 != 0) {
		        uVar6 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                          (*(undefined4 *)(iVar8 + 0xc),lVar9,
		                           Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                          );
		      }
		    }
		    uVar7 = local_4;
		    uVar4 = unnamed_function_1417(System_Tuple_BossInstance__long__int__ICombat__TypeInfo);
		    System_Tuple_int__int__int__bool___get_Item4
		              (uVar4,uVar6,param2,param3,uVar7,
		               Method_System_Tuple_BossInstance__long__int__ICombat___ctor__);
		    uVar6 = ServicesNamespace_BossService__GetTeamRewards(param1[6],param2,param3,0);
		    uVar7 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar7,param1,
		               Method_Gameplay_Boss_Controller_BossController_BeginBattleServiceHandler__,0);
		    uVar6 = ServicesNamespace_MainService__GetUserStats
		                      (uVar6,uVar7,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar6,uVar4,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x974F", Offset = "0x974F", VA = "0x974F")]
		public void BeginBattle(long optionId, int variantId)
		{
		/* --- GHIDRA: BeginBattle ---
		void Gameplay_Boss_Controller_BossController__BeginBattle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_HandleServiceMinionJumpToCombat__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578b4 = '\x01';
		  }
		  uVar1 = ServicesNamespace_BossService__MinionAttackCancel(*(undefined4 *)(param1 + 0x18),0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossController_HandleServiceMinionJumpToCombat__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060048DD RID: 18653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x9750", Offset = "0x9750", VA = "0x9750")]
		public void AttackMinion(ICombat combat)
		{
		/* --- GHIDRA: AttackMinion ---
		void Gameplay_Boss_Controller_BossController__AttackMinion
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_HandleServiceMinionAttackCancel__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578b5 = '\x01';
		  }
		  uVar1 = ServicesNamespace_BossService__ReadyToListen(*(undefined4 *)(param1 + 0x18),0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossController_HandleServiceMinionAttackCancel__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x9751", Offset = "0x9751", VA = "0x9751")]
		public void PayoffMinion(ICombat combat)
		{
		/* --- GHIDRA: PayoffMinion ---
		void Gameplay_Boss_Controller_BossController__PayoffMinion(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000024;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  uint *puVar6;
		  int *piVar7;
		  int iVar8;
		  undefined8 param3_00;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a578b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetInstanceListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_InstanceInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_InstanceInfo__GetEnumerator__);
		    DAT_ram_00a578b6 = '\x01';
		  }
		  piVar7 = *(int **)(param2 + 0x20);
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_BossInstance__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_BossInstance___ctor__);
		  if ((piVar7 != (int *)0x0) && (Protocol_Boss_GetInstanceListAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Boss_GetInstanceListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar7[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_InstanceInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80df4221:
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80df42b5;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80df465d:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df4665;
		    }
		code_r0x80df42b5:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80df465d;
		    if (iVar8 == 0) {
		      iVar8 = 6;
		      goto code_r0x80df46b2;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_InstanceInfo__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80df4399;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_InstanceInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80df455c:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df4665;
		    }
		code_r0x80df4399:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80df455c;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df4665;
		    }
		    param3_00 = *(undefined8 *)(iVar8 + 0x10);
		    if (DAT_ram_00a5788d == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a5788d = '\x01';
		          goto code_r0x80df4495;
		        }
		      }
		code_r0x80df4570:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df4665;
		    }
		code_r0x80df4495:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = param3_00;
		    iVar5 = unnamed_function_184070
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39c,
		                       *(undefined4 *)(iVar4 + 0xc),param3_00,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		    in_register_20000024 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80df4570;
		    if (iVar5 == 0) {
		code_r0x80df4520:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39e,param1,iVar8,iVar8)
		      ;
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80df4665;
		      }
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = unnamed_function_184070
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39d,
		                         *(undefined4 *)(iVar4 + 0xc),param3_00,
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                        );
		      in_register_20000024 = (undefined4)((ulonglong)param3_00 >> 0x20);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80df4570;
		      if (iVar5 == 0) goto code_r0x80df4520;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x39f,*(undefined4 *)(iVar5 + 8),
		                 iVar8,iVar8);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80df4665;
		      }
		    }
		    iVar8 = Method_System_Collections_Generic_List_BossInstance__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar2 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar10 * 4 + 0x10) = iVar5;
		      goto code_r0x80df4221;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar5,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80df4665:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(param1_00);
		    local_c = *piVar7;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80df46b2:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar10 = 0;
		        iVar5 = *piVar7;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80df472d;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80df472d:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		      }
		      if (local_c == 0) {
		        if ((iVar8 == 0) ||
		           ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		            (((iVar8 != 4 && (iVar8 != 5)) && (iVar8 == 6)))))) {
		          iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar8 = *(int *)(iVar8 + 0x14);
		          if (iVar8 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                      (*(undefined4 *)(iVar8 + 0x20),iVar2,
		                       CONCAT44(in_register_20000024,*(undefined4 *)(iVar8 + 0x14)));
		          }
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a0,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(param1_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x9752", Offset = "0x9752", VA = "0x9752")]
		private void HandleServiceGetInstanceList(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetInstanceList ---
		void Gameplay_Boss_Controller_BossController__HandleServiceGetInstanceList
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar4;
		  int *param1_01;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined8 param5;
		  uint uVar5;
		  
		  if (DAT_ram_00a578b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BossScope_AttackBossEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_BeginBattleAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_BossInstance__long__int__ICombat__get_Item1__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_BossInstance__long__int__ICombat__get_Item2__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_BossInstance__long__int__ICombat__get_Item3__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_BossInstance__long__int__ICombat__get_Item4__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Tuple_BossInstance__long__int__ICombat__TypeInfo);
		    DAT_ram_00a578b7 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Boss_BeginBattleAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Boss_BeginBattleAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(System_Tuple_BossInstance__long__int__ICombat__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(System_Tuple_BossInstance__long__int__ICombat__TypeInfo + 0xb8) * 4
		                + -4) != System_Tuple_BossInstance__long__int__ICombat__TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,System_Tuple_BossInstance__long__int__ICombat__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[4],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0 && iVar2 == 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x38) + 8);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      iVar2 = param1_01[6];
		      param5 = *(undefined8 *)(param1_01 + 4);
		      param4 = *(undefined4 *)(param1_01[2] + 8);
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_BossScope_AttackBossEventArgs_TypeInfo);
		      Core_Events_Scopes_ClansScope_ClanWarsDeclarationEventArgs__set_DefenderName
		                (param1_00,param2_00,param3_00,param4,param5,iVar2,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = System_Uri___ctor(0);
		    func_ii_8753(*(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x14),0);
		    return;
		  }
		  uVar5 = 0;
		  piVar4 = (int *)param1_01[7];
		  iVar1 = *piVar4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + iVar1 + 0xd8);
		        goto code_r0x80df4958;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80df4958:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar5 = 0;
		  piVar4 = (int *)param1_01[7];
		  iVar1 = *piVar4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80df49db;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80df49db:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x9753", Offset = "0x9753", VA = "0x9753")]
		private void BeginBattleServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BeginBattleServiceHandler ---
		void Gameplay_Boss_Controller_BossController__BeginBattleServiceHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param4;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  longlong lVar2;
		  int *param1_00;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param2_00;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar8;
		  undefined4 param3_00;
		  longlong param2_01;
		  uint uVar9;
		  undefined4 uVar3;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a578b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MinionAttackCancelAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BossScope_MinionEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578b8 = '\x01';
		  }
		  iVar4 = Gameplay_Combat_ICombat_TypeInfo;
		  param1_02 = *(int **)(param2 + 0x20);
		  if ((param1_02 != (int *)0x0) && (Protocol_Boss_MinionAttackCancelAns_TypeInfo != *param1_02)) {
		    System_Activator__CreateInstance(param1_02,Protocol_Boss_MinionAttackCancelAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar8 = *(int *)(param2 + 0xc);
		  if ((iVar8 != 0) &&
		     (param1_00 = (int *)func_ii_1082(iVar8,Gameplay_Combat_ICombat_TypeInfo),
		     param1_00 == (int *)0x0)) {
		    System_Activator__CreateInstance(iVar8,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_02[4],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  iVar8 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_02[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if ((iVar4 == 0) && (iVar8 == 0)) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar4 = *(int *)(iVar4 + 0x10);
		    uVar9 = 0;
		    iVar8 = *param1_00;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0xd8);
		          goto code_r0x80df4bfb;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80df4bfb:
		    uVar1 = CONCAT44(uVar3,puVar5[1]);
		    (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar9 = 0;
		    iVar8 = *param1_00;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80df4c77;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x80df4c77:
		    uVar1 = CONCAT44(uVar3,puVar5[1]);
		    (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar1);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar8 = *(int *)(iVar8 + 0x24);
		    if (iVar8 != 0) {
		      uVar1 = CONCAT44(uVar3,*(undefined4 *)(iVar8 + 0x14));
		      (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))(*(undefined4 *)(iVar8 + 0x20),uVar1);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    if (iVar4 != 0) {
		      iVar8 = System_Uri___ctor(0);
		      iVar8 = *(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0x38) + 0x10) + 0x38) + 0x10);
		      if (iVar8 != 0) {
		        param2_00 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        param4 = 0;
		        uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104));
		        iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		        uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        param2_01 = *(longlong *)(iVar6 + 0x18);
		        if (0 < param2_01) {
		          if (DAT_ram_00a5788d == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__)
		            ;
		            DAT_ram_00a5788d = '\x01';
		          }
		          lVar2 = param2_01;
		          iVar7 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                            (*(undefined4 *)(iVar6 + 0xc),param2_01,
		                             Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                            );
		          uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		          param4 = 0;
		          if (iVar7 != 0) {
		            iVar6 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                              (*(undefined4 *)(iVar6 + 0xc),param2_01,
		                               Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                              );
		            uVar3 = (undefined4)((ulonglong)param2_01 >> 0x20);
		            if (iVar6 != 0) {
		              param4 = *(undefined4 *)(iVar6 + 8);
		            }
		          }
		        }
		        param1_01 = unnamed_function_1417(Core_Events_Scopes_BossScope_MinionEventArgs_TypeInfo);
		        Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                  (param1_01,param2_00,param3_00,param4,iVar4,0);
		        (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                  (*(undefined4 *)(iVar8 + 0x20),CONCAT44(uVar3,param1_01),
		                   *(undefined4 *)(iVar8 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x9754", Offset = "0x9754", VA = "0x9754")]
		private void HandleServiceMinionAttackCancel(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceMinionAttackCancel ---
		void Gameplay_Boss_Controller_BossController__HandleServiceMinionAttackCancel
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  int iVar2;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a578b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_MinionJumpToCombatAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578b9 = '\x01';
		  }
		  iVar2 = Gameplay_Combat_ICombat_TypeInfo;
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_MinionJumpToCombatAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_MinionJumpToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param2 + 0xc);
		  if ((iVar4 != 0) &&
		     (param1_00 = (int *)func_ii_1082(iVar4,Gameplay_Combat_ICombat_TypeInfo),
		     param1_00 == (int *)0x0)) {
		    System_Activator__CreateInstance(iVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[4],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  iVar4 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar2 == 0 && iVar4 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x28);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  uVar1 = 0;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80df4eef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80df4eef:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar1 = 0;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80df4f6b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x80df4f6b:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x9755", Offset = "0x9755", VA = "0x9755")]
		private void HandleServiceMinionJumpToCombat(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceMinionJumpToCombat ---
		void Gameplay_Boss_Controller_BossController__HandleServiceMinionJumpToCombat
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  longlong lVar2;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  longlong lVar7;
		  undefined4 uVar3;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a578ba == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3958);
		    DAT_ram_00a578ba = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  lVar7 = *(longlong *)(iVar4 + 0x18);
		  if (0 < lVar7) {
		    if (DAT_ram_00a5788d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		      DAT_ram_00a5788d = '\x01';
		    }
		    iVar5 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                      (*(undefined4 *)(iVar4 + 0xc),lVar7,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		    if ((iVar5 != 0) &&
		       (iVar4 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                          (*(undefined4 *)(iVar4 + 0xc),lVar7,
		                           Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                          ), iVar4 != 0)) {
		      uVar1 = CONCAT44((int)((ulonglong)lVar7 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      lVar7 = *(longlong *)(iVar4 + 0x18);
		      if (0 < lVar7) {
		        if (DAT_ram_00a5788d == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                    );
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		          DAT_ram_00a5788d = '\x01';
		        }
		        lVar2 = lVar7;
		        iVar5 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                          (*(undefined4 *)(iVar4 + 0xc),lVar7,
		                           Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                          );
		        uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		        if (iVar5 != 0) {
		          iVar6 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                            (*(undefined4 *)(iVar4 + 0xc),lVar7,
		                             Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                            );
		          uVar3 = (undefined4)((ulonglong)lVar7 >> 0x20);
		        }
		      }
		      iVar4 = *(int *)(*(int *)(iVar6 + 8) + 0x28);
		      if (*(longlong *)(param2 + 0x10) == *(longlong *)(iVar4 + 0x28)) {
		        return;
		      }
		      *(longlong *)(iVar4 + 0x28) = *(longlong *)(param2 + 0x10);
		      iVar6 = *(int *)(*(int *)(iVar6 + 0x10) + 0x18);
		      if (iVar6 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                (*(undefined4 *)(iVar6 + 0x20),CONCAT44(uVar3,*(undefined4 *)(iVar6 + 0x14)));
		      return;
		    }
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(StringLiteral_3958,0);
		  return;
		}
		*/

		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x9756", Offset = "0x9756", VA = "0x9756")]
		private void BossServiceOnMonsterHealthChangedEvent(MonsterHealthEvt monsterHealthEvt)
		{
		/* --- GHIDRA: BossServiceOnMonsterHealthChangedEvent ---
		void Gameplay_Boss_Controller_BossController__BossServiceOnMonsterHealthChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  longlong lVar6;
		  int *piVar7;
		  undefined4 param1_00;
		  undefined8 uVar8;
		  longlong lVar9;
		  int iVar10;
		  uint uVar11;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Base_IIsle_TypeInfo);
		    DAT_ram_00a578bb = '\x01';
		  }
		  uVar8 = *(undefined8 *)(*(int *)(param2 + 0xc) + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (DAT_ram_00a5788d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    DAT_ram_00a5788d = '\x01';
		  }
		  uVar1 = uVar8;
		  iVar4 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                    (*(undefined4 *)(iVar3 + 0xc),uVar8,
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__)
		  ;
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (iVar4 != 0) {
		    iVar3 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(iVar3 + 0xc),uVar8,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    if (iVar3 != 0) {
		      Gameplay_Boss_Controller_BossController__AddBoss
		                (*(undefined4 *)(iVar3 + 8),*(undefined4 *)(param2 + 0xc),param2);
		      goto code_r0x80df5208;
		    }
		  }
		  iVar3 = System_Collections_Generic_Dictionary_long__object___get_Item
		                    (param1,*(undefined4 *)(param2 + 0xc),param2);
		code_r0x80df5208:
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar7;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80df52a1;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar11);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80df52a1:
		  uVar8 = CONCAT44(uVar2,puVar5[1]);
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,uVar8);
		  uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  piVar7 = (int *)Gameplay_World_Model_WorldModel__GetIsleByTypeAndId
		                            (*(undefined4 *)(iVar4 + 0x14),0);
		  if (piVar7 != (int *)0x0) {
		    iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 8) + 0x28) + 0x20) + 0xc);
		    iVar10 = *piVar7;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + iVar10 + 0xe0);
		          goto code_r0x80df5341;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Isles_Base_IIsle_TypeInfo,4);
		code_r0x80df5341:
		    uVar8 = CONCAT44(uVar2,puVar5[1]);
		    iVar10 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,uVar8);
		    uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		    if (iVar10 == iVar4) {
		      uVar11 = 0;
		      lVar9 = *(longlong *)(*(int *)(*(int *)(*(int *)(iVar3 + 8) + 0x28) + 0x20) + 0x10);
		      iVar4 = *piVar7;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8)) {
		            puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80df53d2;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar11);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80df53d2:
		      uVar8 = CONCAT44(uVar2,puVar5[1]);
		      lVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,uVar8);
		      uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      if (lVar6 == lVar9) {
		        uVar8 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar8);
		        *(undefined8 *)(iVar4 + 0x18) = *(undefined8 *)(*(int *)(*(int *)(iVar3 + 8) + 0x28) + 0x10)
		        ;
		        uVar8 = CONCAT44((int)((ulonglong)uVar8 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar8);
		        uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		        iVar4 = *(int *)(iVar4 + 0x18);
		        if (iVar4 != 0) {
		          uVar8 = *(undefined8 *)(*(int *)(*(int *)(iVar3 + 8) + 0x28) + 0x10);
		          (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                    (*(undefined4 *)(iVar4 + 0x20),uVar8,*(undefined4 *)(iVar4 + 0x14));
		          uVar2 = (undefined4)((ulonglong)uVar8 >> 0x20);
		        }
		      }
		    }
		  }
		  param1_00 = *(undefined4 *)(iVar3 + 0xc);
		  iVar4 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(iVar4 + 0x104)));
		  uVar8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 8),0);
		  Gameplay_Boss_Controller_BossInstanceController__BuyLicence(param1_00,uVar8,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x9757", Offset = "0x9757", VA = "0x9757")]
		private void BossServiceOnInstanceInfoEvent(InstanceInfoEvt instanceInfo)
		{
		/* --- GHIDRA: BossServiceOnInstanceInfoEvent ---
		void Gameplay_Boss_Controller_BossController__BossServiceOnInstanceInfoEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossCreateRequestData_TypeInfo);
		    DAT_ram_00a578bc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Model_BossCreateRequestData_TypeInfo);
		  Gameplay_Boss_Model_BossCreateRequestData__set_AprDic(param1_00,param2,param1);
		  *(undefined4 *)(iVar1 + 0x20) = param1_00;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x9758", Offset = "0x9758", VA = "0x9758")]
		private void BossServiceOnCreateRequestEvent(CreateRequestEvt createRequestEvt)
		{
		/* --- GHIDRA: BossServiceOnCreateRequestEvent ---
		void Gameplay_Boss_Controller_BossController__BossServiceOnCreateRequestEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Controller_BossController__HandleExternalMinionAttack(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x9759", Offset = "0x9759", VA = "0x9759")]
		public void HandleExternalMinionAttack(MinionAttackEvt evt)
		{
		/* --- GHIDRA: HandleExternalMinionAttack ---
		void Gameplay_Boss_Controller_BossController__HandleExternalMinionAttack
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  longlong lVar3;
		  float param2_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param1_00;
		  undefined4 uVar10;
		  int *piVar11;
		  int iVar12;
		  undefined4 param3_00;
		  undefined8 uVar13;
		  longlong param2_01;
		  uint uVar14;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a578bd == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BossScope_MinionEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a578bd = '\x01';
		  }
		  local_4 = 0;
		  uVar13 = *(undefined8 *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar13,0);
		  uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		  uVar10 = *(undefined4 *)(param2 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8 + 4) * 8 + iVar12 + 0x178);
		        goto code_r0x80df570d;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar14);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80df570d:
		  uVar13 = CONCAT44(uVar1,piVar11);
		  uVar2 = CONCAT44(in_register_20000014,puVar5[1]);
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(uVar13,uVar2);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar6 = Core_Data_MonsterData__GetDifficultyLocaleKey(uVar10,uVar6,0);
		  uVar13 = CONCAT44(uVar1,param1);
		  uVar2 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0x104));
		  iVar12 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar13,uVar2);
		  uVar10 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  *(undefined4 *)(iVar12 + 0x10) = uVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar14 = 0;
		  piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8 + 4) * 8 + iVar12 + 0x1e0);
		        goto code_r0x80df57f7;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar14);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df57f7:
		  uVar13 = CONCAT44(uVar1,piVar11);
		  uVar2 = CONCAT44(uVar10,puVar5[1]);
		  uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(uVar13,uVar2);
		  uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  uVar10 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar12 = Core_Gameplay_Managers_BossManager__TryRunBossCombat(uVar7,uVar4,&local_4,0);
		  if (iVar12 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar14 = 0;
		    piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar12 = *piVar11;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8 + 4) * 8 + iVar12 + 0x1e0)
		          ;
		          goto code_r0x80df58b3;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar14);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df58b3:
		    uVar13 = CONCAT44(uVar1,piVar11);
		    uVar2 = CONCAT44(uVar10,puVar5[1]);
		    uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(uVar13,uVar2);
		    uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		    uVar10 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    Core_Gameplay_Managers_BossManager__ShowBossRewardingWindow(uVar7,local_4,uVar6,uVar4,0);
		    iVar12 = System_Uri___ctor(0);
		    iVar12 = *(int *)(*(int *)(*(int *)(*(int *)(iVar12 + 0x38) + 0x10) + 0x38) + 0xc);
		    if (iVar12 != 0) {
		      uVar4 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar7 = 0;
		      uVar13 = CONCAT44(uVar1,param1);
		      uVar2 = CONCAT44(uVar10,*(undefined4 *)(*param1 + 0x104));
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar13,uVar2);
		      uVar10 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar1 = (undefined4)((ulonglong)uVar13 >> 0x20);
		      param2_01 = *(longlong *)(iVar8 + 0x18);
		      if (0 < param2_01) {
		        if (DAT_ram_00a5788d == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                    );
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		          DAT_ram_00a5788d = '\x01';
		        }
		        lVar3 = param2_01;
		        iVar9 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                          (*(undefined4 *)(iVar8 + 0xc),param2_01,
		                           Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                          );
		        uVar10 = (undefined4)((ulonglong)lVar3 >> 0x20);
		        uVar7 = 0;
		        if (iVar9 != 0) {
		          iVar8 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                            (*(undefined4 *)(iVar8 + 0xc),param2_01,
		                             Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                            );
		          uVar10 = (undefined4)((ulonglong)param2_01 >> 0x20);
		          if (iVar8 != 0) {
		            uVar7 = *(undefined4 *)(iVar8 + 8);
		          }
		        }
		      }
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_BossScope_MinionEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,uVar4,param3_00,uVar7,uVar6,0);
		      (**(code **)((ulonglong)*(uint *)(iVar12 + 0xc) * 4))
		                (CONCAT44(uVar1,*(undefined4 *)(iVar12 + 0x20)),CONCAT44(uVar10,param1_00),
		                 *(undefined4 *)(iVar12 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x975A", Offset = "0x975A", VA = "0x975A")]
		private void BossServiceOnMinionAttackEvent(MinionAttackEvt evt)
		{
		/* --- GHIDRA: BossServiceOnMinionAttackEvent ---
		void Gameplay_Boss_Controller_BossController__BossServiceOnMinionAttackEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a578be == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3960);
		    DAT_ram_00a578be = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_3960,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x975B", Offset = "0x975B", VA = "0x975B")]
		private void BossServiceOnMinionAttackServerCancelationEvent(MinionAttackServerCancelationEvt evt)
		{
		/* --- GHIDRA: BossServiceOnMinionAttackServerCancelationEvent ---
		void Gameplay_Boss_Controller_BossController__BossServiceOnMinionAttackServerCancelationEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a578bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossGuestView___ctor__
		              );
		    DAT_ram_00a578bf = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossGuestView___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x18")]
		private BossService _bossService;
	}
}
