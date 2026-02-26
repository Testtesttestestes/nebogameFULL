using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuelCombat;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D45 RID: 3397
	[Token(Token = "0x2000D45")]
	public sealed class ThemeDuelCombatEventStatisticsObserver : CombatEventStatisticsObserver<ThemeDuelCombatEvents>
	{
		// Token: 0x140001FB RID: 507
		// (add) Token: 0x0600533A RID: 21306 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600533B RID: 21307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FB")]
		public event Action<long> OnScoreChanged
		{
			[Token(Token = "0x600533A")]
			[Address(RVA = "0xA0F9", Offset = "0xA0F9", VA = "0xA0F9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600533B")]
			[Address(RVA = "0xA0FA", Offset = "0xA0FA", VA = "0xA0FA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533C")]
		[Address(RVA = "0xA0FB", Offset = "0xA0FB", VA = "0xA0FB")]
		public ThemeDuelCombatEventStatisticsObserver(ThemeDuelCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a593ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__ListenEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_HandleThemeScoreChangedEvent__
		              );
		    DAT_ram_00a593ca = '\x01';
		  }
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___Dispose
		            (param1,param2,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__ListenEvents__
		            );
		  param1_01 = *(undefined4 *)(param2 + 0x70);
		  uVar1 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_HandleThemeScoreChangedEvent__
		             ,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar1,0);
		  uVar1 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x70) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x70) = iVar2;
		  uVar1 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533D")]
		[Address(RVA = "0xA0FC", Offset = "0xA0FC", VA = "0xA0FC", Slot = "5")]
		protected override void ListenEvents(ThemeDuelCombatEvents events)
		{
		/* --- GHIDRA: ListenEvents ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__ListenEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a593cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__UnlistenEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_HandleThemeScoreChangedEvent__
		              );
		    DAT_ram_00a593cb = '\x01';
		  }
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___OnSwitchTurn
		            (param1,param2,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__UnlistenEvents__
		            );
		  param1_01 = *(undefined4 *)(param2 + 0x70);
		  uVar1 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver_HandleThemeScoreChangedEvent__
		             ,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x70) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x70) = iVar2;
		  uVar1 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533E")]
		[Address(RVA = "0xA0FD", Offset = "0xA0FD", VA = "0xA0FD", Slot = "6")]
		protected override void UnlistenEvents(ThemeDuelCombatEvents events)
		{
		/* --- GHIDRA: UnlistenEvents ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__UnlistenEvents
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  
		  lVar2 = *(longlong *)(param2 + 0x18);
		  if (lVar2 != *(longlong *)(param1 + 0x28)) {
		    *(longlong *)(param1 + 0x28) = lVar2;
		    iVar1 = *(int *)(param1 + 0x30);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),lVar2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533F")]
		[Address(RVA = "0xA0FE", Offset = "0xA0FE", VA = "0xA0FE")]
		private void HandleThemeScoreChangedEvent(ProtoThemeScoreChangedEvt msg)
		{
		/* --- GHIDRA: HandleThemeScoreChangedEvent ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__HandleThemeScoreChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int local_4;
		  
		  if (DAT_ram_00a593cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a593cc = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,3,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(local_4 + 0xc);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80ff9ba4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x80ff9ba4:
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
		            goto code_r0x80ff9c46;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,iVar2,0);
		code_r0x80ff9c46:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar5,param1,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x28")]
		private long _score;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnScoreChanged ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__add_OnScoreChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    DAT_ram_00a593c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_long__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_long__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_OnScoreChanged ---
		void Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__remove_OnScoreChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a593c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents___ctor__
		              );
		    DAT_ram_00a593c9 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___get_CombatService
		            (param1,param2,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents___ctor__
		            );
		  return;
		}
		*/

}
