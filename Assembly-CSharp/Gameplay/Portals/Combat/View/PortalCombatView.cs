using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.Combat.View
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	public class PortalCombatView : OneOnOneCombatView
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DD")]
		public Button GetRewardButton
		{
			[Token(Token = "0x60024C3")]
			[Address(RVA = "0x7611", Offset = "0x7611", VA = "0x7611")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006DE")]
		public Button ShopButton
		{
			[Token(Token = "0x60024C4")]
			[Address(RVA = "0x7612", Offset = "0x7612", VA = "0x7612")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x7613", Offset = "0x7613", VA = "0x7613", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x7614", Offset = "0x7614", VA = "0x7614")]
		public PortalCombatView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Combat_View_PortalCombatView___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9,
		               undefined4 param10)
		
		{
		  Gameplay_Combat_Model_CombatModel__Dispose(param1,param6,param7,param8,param9,0);
		  *(undefined4 *)(param1 + 0x68) = param4;
		  *(undefined4 *)(param1 + 0x60) = param3;
		  *(undefined4 *)(param1 + 100) = param2;
		  *(undefined4 *)(param1 + 0x5c) = param5;
		  return;
		}
		*/

		}

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _shopButton;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _getRewardButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ShopButton ---
		void Gameplay_Portals_Combat_View_PortalCombatView__get_ShopButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int local_4;
		  
		  if (DAT_ram_00a57d5f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a57d5f = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xf,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(local_4 + 0xc);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e53a27;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x80e53a27:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar2 = Gameplay_Combat_IManageCombat_TypeInfo;
		    if (iVar4 != 0) {
		      piVar5 = (int *)0x0;
		      iVar4 = *(int *)(local_4 + 0xc);
		      if ((iVar4 != 0) &&
		         (piVar5 = (int *)func_ii_1082(iVar4,Gameplay_Combat_IManageCombat_TypeInfo),
		         piVar5 == (int *)0x0)) {
		        System_Activator__CreateInstance(iVar4,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = *piVar5;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (iVar2 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e53ac9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,iVar2,0);
		code_r0x80e53ac9:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar5,param1,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

}
