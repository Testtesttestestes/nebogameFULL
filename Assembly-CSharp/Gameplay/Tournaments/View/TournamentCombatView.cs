using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public class TournamentCombatView : OneOnOneCombatView
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F1")]
		public Button CloseButton
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x6DA0", Offset = "0x6DA0", VA = "0x6DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F2")]
		public GameObject Blocker
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x6DA1", Offset = "0x6DA1", VA = "0x6DA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x6DA2", Offset = "0x6DA2", VA = "0x6DA2", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x6DA3", Offset = "0x6DA3", VA = "0x6DA3")]
		public TournamentCombatView()
		{
		}

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _blocker;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _closeButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Blocker ---
		void Gameplay_Tournaments_View_TournamentCombatView__get_Blocker
		               (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  int local_4;
		  
		  param1_01 = (int *)0x0;
		  if (DAT_ram_00a584f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a584f2 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,6,&local_4,
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
		          goto code_r0x80efb7a9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,param2_00,0);
		code_r0x80efb7a9:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  }
		  return;
		}
		*/

}
