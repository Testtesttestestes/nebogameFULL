using System;
using CloudsFly.Movement;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DB RID: 4571
	[Token(Token = "0x20011DB")]
	public class Home : AbstractPathNode
	{
		// Token: 0x06006CBE RID: 27838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0xB7AA", Offset = "0xB7AA", VA = "0xB7AA", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__ExecuteTransition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a71d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a71d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x812617cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812617cd:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 8);
		  param1_01 = *(undefined4 *)(iVar6 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		             ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0xc) = 0;
		    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__TransitionCanceled(param1,0)
		    ;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar6 != 0) {
		      Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__TransitionCanceled
		                (param1,iVar5);
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0xB7AB", Offset = "0xB7AB", VA = "0xB7AB")]
		private void MovCompleteEvent(WorldMovementTypes obj)
		{
		/* --- GHIDRA: MovCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__MovCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a71e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a71e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81261914;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261914:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 8);
		  param1_01 = *(undefined4 *)(iVar6 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		             ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0xc) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0xB7AC", Offset = "0xB7AC", VA = "0xB7AC", Slot = "6")]
		protected override void TransitionCanceled()
		{
		/* --- GHIDRA: TransitionCanceled ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__TransitionCanceled
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *local_4;
		  
		  if (DAT_ram_00a5a71f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo);
		    DAT_ram_00a5a71f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = Utils_OpTokenRepository___ctor(*(undefined4 *)(param1 + 0x14),param1,&local_4,0);
		  if (iVar1 != 0) {
		    if (local_4 != (int *)0x0) {
		      if (((uint)*(byte *)(*local_4 + 0xb8) <
		           (uint)*(byte *)(Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*local_4 + 100) +
		                   (uint)*(byte *)(Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo + 0xb8)
		                   * 4 + -4) != Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo)) {
		        System_Activator__CreateInstance
		                  (local_4,Utils_OpToken_LocatorPayload__AbstractPathNode__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    Core_ExternAppMethods__OpenPaymentWindow
		              (local_4,*(undefined4 *)(param1 + 0x18),
		               Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		    return;
		  }
		  param2_00 = *(undefined4 *)(param1 + 8);
		  uVar2 = unnamed_function_2232(&StringLiteral_680);
		  uVar3 = unnamed_function_2232(&StringLiteral_19467);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__(uVar2,param2_00,uVar3,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232
		                    (&
		                     Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_Complete__
		                    );
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0xB7AD", Offset = "0xB7AD", VA = "0xB7AD")]
		private void Complete()
		{
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0xB7AE", Offset = "0xB7AE", VA = "0xB7AE")]
		public Home()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a720 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a720 = '\x01';
		  }
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x18")]
		private LocatorPayload _payload;
	}
}
