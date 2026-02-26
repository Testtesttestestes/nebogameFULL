using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C32 RID: 3122
	[Token(Token = "0x2000C32")]
	public class AdOptionInBankValidatorView : MonoBehaviour
	{
		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F58")]
		public GameObject AdMarker
		{
			[Token(Token = "0x6004C24")]
			[Address(RVA = "0x9A68", Offset = "0x9A68", VA = "0x9A68")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x9A69", Offset = "0x9A69", VA = "0x9A69")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Bank_View_AdOptionInBankValidatorView__Start(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x14);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x9A6A", Offset = "0x9A6A", VA = "0x9A6A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x9A6B", Offset = "0x9A6B", VA = "0x9A6B")]
		public AdOptionInBankValidatorView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Bank_View_AdOptionInBankValidatorView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59758 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12568);
		    DAT_ram_00a59758 = '\x01';
		  }
		  return StringLiteral_12568;
		}
		*/

		}

		// Token: 0x04002975 RID: 10613
		[Token(Token = "0x4002975")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _adMarker;

		// Token: 0x04002976 RID: 10614
		[Token(Token = "0x4002976")]
		[FieldOffset(Offset = "0x14")]
		private AdOptionInBankValidatorViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AdMarker ---
		void Gameplay_Bank_View_AdOptionInBankValidatorView__get_AdMarker(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59757 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59757 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x810628d5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x810628d5:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x24);
		  param3 = *(undefined4 *)(iVar4 + 0x28);
		  param2_00 = *(undefined4 *)(iVar4 + 0x2c);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Bank_Controller_AdOptionInBankValidatorViewMediator_TypeInfo);
		  if (DAT_ram_00a597d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView___ctor__
		              );
		    DAT_ram_00a597d6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__AdOptionInBankValidatorView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x14) = piVar3;
		  return;
		}
		*/

}
