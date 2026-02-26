using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class AdOptionInBankValidatorViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, AdOptionInBankValidatorView>
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x9B8E", Offset = "0x9B8E", VA = "0x9B8E")]
		public AdOptionInBankValidatorViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		/* --- GHIDRA: <ValidateState>b__5_0 ---
		void Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator___ValidateState_b__5_0
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597db == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_BankModel__BankEvents__Dispose__);
		    DAT_ram_00a597db = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_BankModel__BankEvents__Dispose__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a597d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView__set_View__
		              );
		    DAT_ram_00a597d7 = '\x01';
		  }
		  param1[5] = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__set_Events(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FAB RID: 4011
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAB")]
		public override AdOptionInBankValidatorView View
		{
			[Token(Token = "0x6004D56")]
			[Address(RVA = "0x9B8F", Offset = "0x9B8F", VA = "0x9B8F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAC")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D57")]
			[Address(RVA = "0x9B90", Offset = "0x9B90", VA = "0x9B90", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D58")]
		[Address(RVA = "0x9B91", Offset = "0x9B91", VA = "0x9B91")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		undefined4
		Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__ValidateState
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a597da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    DAT_ram_00a597da = '\x01';
		  }
		  if (*(int *)(param2 + 0x28) == 0) {
		    uVar4 = 0;
		  }
		  else {
		    param1_00 = *(int **)(*(int *)(param1 + 8) + 0x18);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_Model_IOptionValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81070305;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		code_r0x81070305:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  }
		  return uVar4;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_ValidateState__)
		    ;
		    DAT_ram_00a597d8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_ValidateState__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_ValidateState__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_ValidateState__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_ValidateState__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a597d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__ValidateState_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    DAT_ram_00a597d9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x10);
		  iVar1 = param1[2];
		  uVar2 = unnamed_function_1417(System_Func_BankOptionData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,
		             Method_Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator__ValidateState_b__5_0__
		             ,0);
		  uVar2 = Gameplay_Bank_Model_BankModel__IsArtikulOptionActive(iVar1,uVar2,param1);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar2,0);
		  return;
		}
		*/

}
