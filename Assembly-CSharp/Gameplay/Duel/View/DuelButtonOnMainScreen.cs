using System;
using Gameplay.Duel.Controller;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	public class DuelButtonOnMainScreen : MonoBehaviour
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E5")]
		public Button DuelButton
		{
			[Token(Token = "0x6003231")]
			[Address(RVA = "0x8287", Offset = "0x8287", VA = "0x8287")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x8288", Offset = "0x8288", VA = "0x8288")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Duel_View_DuelButtonOnMainScreen__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57bc9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57bc9 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1d8);
		        goto code_r0x80e32440;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e32440:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x140) * 4))
		            (piVar4,uVar3,*(undefined4 *)(iVar5 + 0x144));
		  iVar5 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x160) * 4))
		            (*(int **)(param1 + 0x14),param1,*(undefined4 *)(iVar5 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003233")]
		[Address(RVA = "0x8289", Offset = "0x8289", VA = "0x8289")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Duel_View_DuelButtonOnMainScreen__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		            (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar1 + 0x144));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06003234 RID: 12852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003234")]
		[Address(RVA = "0x828A", Offset = "0x828A", VA = "0x828A")]
		private void OnDisable()
		{
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x828B", Offset = "0x828B", VA = "0x828B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003236")]
		[Address(RVA = "0x828C", Offset = "0x828C", VA = "0x828C")]
		public DuelButtonOnMainScreen()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_View_DuelButtonOnMainScreen___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  int local_4;
		  
		  param1_01 = (int *)0x0;
		  if (DAT_ram_00a57bca == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a57bca = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,10,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  param2_00 = Gameplay_Combat_IManageCombat_TypeInfo;
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(local_4 + 0xc);
		    if ((iVar2 != 0) &&
		       (param1_01 = (int *)func_ii_1082(iVar2,Gameplay_Combat_IManageCombat_TypeInfo),
		       param1_01 == (int *)0x0)) {
		      System_Activator__CreateInstance(iVar2,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (param2_00 == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e325e2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,param2_00,0);
		code_r0x80e325e2:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001B6C RID: 7020
		[Token(Token = "0x4001B6C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _duelButton;

		// Token: 0x04001B6D RID: 7021
		[Token(Token = "0x4001B6D")]
		[FieldOffset(Offset = "0x14")]
		private DuelEnterPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DuelButton ---
		void Gameplay_Duel_View_DuelButtonOnMainScreen__get_DuelButton(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57bc8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Controller_DuelEnterPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57bc8 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1d8);
		        goto code_r0x80e32137;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e32137:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(iVar4 + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x228);
		        goto code_r0x80e321e6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2d);
		code_r0x80e321e6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x1c);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                        (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x110) * 4))
		                     (piVar3,*(undefined4 *)(*piVar3 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80e322c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e322c5:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = *(int *)(iVar4 + 0x14);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Duel_Controller_DuelEnterPointViewMediator_TypeInfo);
		  if (DAT_ram_00a57bfe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen___ctor__
		              );
		    DAT_ram_00a57bfe = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen___ctor__
		            );
		  piVar3[6] = iVar4;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x14) = piVar3;
		  return;
		}
		*/

}
