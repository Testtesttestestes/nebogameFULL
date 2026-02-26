using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UI.Elements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ThemeDuelCombat.View
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	public class ThemeDuelCombatView : OneOnOneCombatView
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000546")]
		public CommonElements.IconLabel ThemeDuelPointsLeft
		{
			[Token(Token = "0x6001D76")]
			[Address(RVA = "0x6EF5", Offset = "0x6EF5", VA = "0x6EF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000547")]
		public CommonElements.IconLabel ThemeDuelPointsRight
		{
			[Token(Token = "0x6001D77")]
			[Address(RVA = "0x6EF6", Offset = "0x6EF6", VA = "0x6EF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000548")]
		public Button TdShopButton
		{
			[Token(Token = "0x6001D78")]
			[Address(RVA = "0x6EF7", Offset = "0x6EF7", VA = "0x6EF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x6EF8", Offset = "0x6EF8", VA = "0x6EF8", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_ThemeDuelCombat_View_ThemeDuelCombatView__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x78);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,param2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x6EF9", Offset = "0x6EF9", VA = "0x6EF9")]
		public void ShowThemeDuelPoints(bool value)
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x6EFA", Offset = "0x6EFA", VA = "0x6EFA")]
		public ThemeDuelCombatView()
		{
		}

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonElements.IconLabel _themeDuelPointsLeft;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private CommonElements.IconLabel _themeDuelPointsRight;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform[] _themeDuelPoints;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Button _tdShopButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TdShopButton ---
		void Gameplay_ThemeDuelCombat_View_ThemeDuelCombatView__get_TdShopButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int local_4;
		  
		  if (DAT_ram_00a585a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a585a0 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xe,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(local_4 + 0xc);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f0b09a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x80f0b09a:
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
		            goto code_r0x80f0b13c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,iVar2,0);
		code_r0x80f0b13c:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar5,param1,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

}
