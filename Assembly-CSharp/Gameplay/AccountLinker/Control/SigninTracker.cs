using System;
using Il2CppDummyDll;
using UI.ConfirmationMessage;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E26 RID: 3622
	[Token(Token = "0x2000E26")]
	public class SigninTracker : IDisposable
	{
		// Token: 0x0600585F RID: 22623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585F")]
		[Address(RVA = "0xA5CD", Offset = "0xA5CD", VA = "0xA5CD")]
		public SigninTracker(ConfirmationMessageController confirmationMessageController, AccountLinkerEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_Control_SigninTracker___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63bb2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_2791);
		    DAT_ram_00a63bb2 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 8);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2791,1,0,1,0,0,0,0);
		  UI_ConfirmationMessage_ConfirmationMessageController__Show(uVar4,uVar2,5.0,0);
		  iVar5 = *(int *)(param1 + 0xc);
		  uVar2 = *(undefined4 *)(iVar5 + 0x28);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar4,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x28) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(iVar5 + 0x28) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = *(int *)(param1 + 0xc);
		  uVar2 = *(undefined4 *)(iVar5 + 0x2c);
		  uVar4 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar4,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x2c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x2c) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005860")]
		[Address(RVA = "0xA5CE", Offset = "0xA5CE", VA = "0xA5CE")]
		private void SigninTargetProviderStartedEventHandler()
		{
		/* --- GHIDRA: SigninTargetProviderStartedEventHandler ---
		void Gameplay_AccountLinker_Control_SigninTracker__SigninTargetProviderStartedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63bb3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__)
		    ;
		    DAT_ram_00a63bb3 = '\x01';
		  }
		  UI_ConfirmationMessage_ConfirmationMessageController__Show(*(undefined4 *)(param1 + 8),0);
		  iVar4 = *(int *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x28) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_AccountLinker_Control_SigninTracker_Unsubscribe__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar4 + 0x2c) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005861")]
		[Address(RVA = "0xA5CF", Offset = "0xA5CF", VA = "0xA5CF")]
		private void Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		void Gameplay_AccountLinker_Control_SigninTracker__Unsubscribe(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a63bb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_SigninTracker_SigninTargetProviderStartedEventHandler__
		              );
		    DAT_ram_00a63bb4 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_SigninTracker__SigninTargetProviderStartedEventHandler
		            (param1,param1);
		  iVar1 = *(int *)(param1 + 0xc);
		  param1_02 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_SigninTracker_SigninTargetProviderStartedEventHandler__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x20) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(iVar1 + 0x20) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005862")]
		[Address(RVA = "0xA5D0", Offset = "0xA5D0", VA = "0xA5D0", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_Control_SigninTracker__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63bb5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		    DAT_ram_00a63bb5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GameAnimatedButton__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameAnimatedButton__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x8")]
		private readonly ConfirmationMessageController _confirmationMessageController;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0xC")]
		private readonly AccountLinkerEvents _events;
	}
}
