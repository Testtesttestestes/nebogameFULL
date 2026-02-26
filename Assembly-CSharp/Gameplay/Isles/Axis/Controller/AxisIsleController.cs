using System;
using Gameplay.Isles.Axis.Events;
using Gameplay.Isles.Axis.Model;
using Gameplay.Isles.Base.Controller;
using Il2CppDummyDll;

namespace Gameplay.Isles.Axis.Controller
{
	// Token: 0x02000D09 RID: 3337
	[Token(Token = "0x2000D09")]
	public class AxisIsleController : BaseIsleController<AxisIsleModel, AxisIsleEvents>
	{
		// Token: 0x0600516A RID: 20842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x9F49", Offset = "0x9F49", VA = "0x9F49")]
		public AxisIsleController(AxisIsleModel model, AxisIsleEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Axis_Controller_AxisIsleController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d05 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleController_ScheduleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d05 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 600);
		        goto code_r0x80f9cc47;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9cc47:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x18);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Isles_Axis_Controller_AxisIsleController_ScheduleChangedEventHandler__,
		             0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x9F4A", Offset = "0x9F4A", VA = "0x9F4A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Isles_Axis_Controller_AxisIsleController__HandleRun
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d06 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_Controller_AxisIsleController_ScheduleChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d06 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 600);
		        goto code_r0x80f9cd93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9cd93:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x18);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Isles_Axis_Controller_AxisIsleController_ScheduleChangedEventHandler__,
		             0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x9F4B", Offset = "0x9F4B", VA = "0x9F4B", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Isles_Axis_Controller_AxisIsleController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x9F4C", Offset = "0x9F4C", VA = "0x9F4C")]
		private void ScheduleChangedEventHandler()
		{
		/* --- GHIDRA: ScheduleChangedEventHandler ---
		void Gameplay_Isles_Axis_Controller_AxisIsleController__ScheduleChangedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58d07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView___ctor__
		              );
		    DAT_ram_00a58d07 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
