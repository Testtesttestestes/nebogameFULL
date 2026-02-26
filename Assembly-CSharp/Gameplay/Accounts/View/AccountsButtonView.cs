using System;
using Gameplay.Accounts.Control;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC7 RID: 3527
	[Token(Token = "0x2000DC7")]
	public class AccountsButtonView : MonoBehaviour
	{
		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117C")]
		public IndexButtonBasic Button
		{
			[Token(Token = "0x6005607")]
			[Address(RVA = "0xA3A7", Offset = "0xA3A7", VA = "0xA3A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005608")]
		[Address(RVA = "0xA3A8", Offset = "0xA3A8", VA = "0xA3A8")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Accounts_View_AccountsButtonView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  int *param4;
		  
		  if (DAT_ram_00a58885 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountEntryPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58885 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80f37d9d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f37d9d:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(int **)(iVar4 + 0x14);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                        (param4,*(undefined4 *)(*param4 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                     (param4,*(undefined4 *)(*param4 + 0x114));
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Accounts_Control_AccountEntryPointViewMediator_TypeInfo);
		  if (DAT_ram_00a588c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView___ctor__
		              );
		    DAT_ram_00a588c4 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView___ctor__
		            );
		  *(int **)(param1 + 0x14) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005609")]
		[Address(RVA = "0xA3A9", Offset = "0xA3A9", VA = "0xA3A9")]
		private void Awake()
		{
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560A")]
		[Address(RVA = "0xA3AA", Offset = "0xA3AA", VA = "0xA3AA")]
		public AccountsButtonView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_View_AccountsButtonView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58886 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a58886 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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

		// Token: 0x04002EA3 RID: 11939
		[Token(Token = "0x4002EA3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IndexButtonBasic _button;

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x14")]
		private AccountEntryPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Button ---
		void Gameplay_Accounts_View_AccountsButtonView__get_Button(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

}
