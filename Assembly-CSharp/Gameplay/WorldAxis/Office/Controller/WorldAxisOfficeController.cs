using System;
using DG.Tweening;
using Gameplay.WorldAxis.Controller;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public class WorldAxisOfficeController : AbstractController<WorldAxisOfficeModel, WorldAxisOfficeEvents>
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x6386", Offset = "0x6386", VA = "0x6386")]
		public WorldAxisOfficeController(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisController worldAxisController)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_WorldAxisOfficeModel__WorldAxisOfficeEvents__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_RepopulateSchedule__
		              );
		    DAT_ram_00a58b69 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar4 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_RepopulateSchedule__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar4 + 0x14) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[5] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar4 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_RepopulateSchedule__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar4 + 0x14) = piVar3, *piVar3 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000296 RID: 662
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000296")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x600118A")]
			[Address(RVA = "0x6387", Offset = "0x6387", VA = "0x6387", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x6388", Offset = "0x6388", VA = "0x6388", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x20),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x6389", Offset = "0x6389", VA = "0x6389", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  float param1_00;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58b6a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusBattleData__float__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IEnumerableExt_MinOrDefault_ColossusBattleData__float___);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c__RepopulateSchedule_b__8_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_UpdateSchedule__
		              );
		    DAT_ram_00a58b6a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__GetTabBarItemData(uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x18);
		  if (*(int *)(Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo + 0x5c);
		  iVar2 = puVar3[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo + 0x5c)
		      ;
		    }
		    param2_00 = *puVar3;
		    iVar2 = unnamed_function_1417(System_Func_ColossusBattleData__float__TypeInfo);
		    System_Func_object__SerializableProjectConfiguration___Invoke
		              (iVar2,param2_00,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c__RepopulateSchedule_b__8_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo +
		                     0x5c) + 4) = iVar2;
		  }
		  param1_00 = Core_Extensions_ICollectionExt__ContainsAny___Il2CppFullySharedGenericType_
		                        (uVar1,iVar2,
		                         Method_Core_Extensions_IEnumerableExt_MinOrDefault_ColossusBattleData__float___
		                        );
		  if (param1[8] != 0) {
		    func_ii_7891(param1[8],0,0);
		  }
		  if (0.0 < param1_00) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_UpdateSchedule__
		               ,0);
		    iVar2 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar1,1,0);
		    param1[8] = iVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x638A", Offset = "0x638A", VA = "0x638A")]
		private void RepopulateSchedule()
		{
		/* --- GHIDRA: RepopulateSchedule ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__RepopulateSchedule
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *param2_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58b6b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b6b = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80f7c6f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f7c6f6:
		  iVar2 = (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param2_00[1]);
		  if (*(int *)(*(int *)(iVar2 + 0x14) + 0x1c) != 4) {
		    Gameplay_WorldAxis_Controller_WorldAxisController__InventoryChangedEventHandler
		              (*(undefined4 *)(param1 + 0x18),param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x638B", Offset = "0x638B", VA = "0x638B")]
		private void UpdateSchedule()
		{
		/* --- GHIDRA: UpdateSchedule ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__UpdateSchedule
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58b6c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_GetColossusRatingResultHandler__
		              );
		    DAT_ram_00a58b6c = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetSchedule(*(undefined4 *)(param1 + 0x1c),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_GetColossusRatingResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x638C", Offset = "0x638C", VA = "0x638C")]
		public void GetColossusRating(uint colossusId)
		{
		/* --- GHIDRA: GetColossusRating ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__GetColossusRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58b6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo);
		    DAT_ram_00a58b6d = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    puVar1 = (undefined4 *)func_ii_15774(param1_02);
		    param3_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__RepopulateColossusBattles
		              (param1_00,param1_01[3],param3_00,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x638D", Offset = "0x638D", VA = "0x638D")]
		private void GetColossusRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetColossusRatingResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__GetColossusRatingResultHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_WorldAxisOfficeModel__WorldAxisOfficeEvents__Dispose__
		              );
		    DAT_ram_00a58b6e = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_WorldAxisOfficeModel__WorldAxisOfficeEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x638E", Offset = "0x638E", VA = "0x638E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__Dispose(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo);
		    DAT_ram_00a58b6f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo);
		  **(undefined4 **)
		    (Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldAxisController _worldAxisController;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x1C")]
		private ColossusService _service;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x20")]
		private Tween _timer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController__set_Events
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Controller_WorldAxisController__InventoryChangedEventHandler
		            (*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

}
