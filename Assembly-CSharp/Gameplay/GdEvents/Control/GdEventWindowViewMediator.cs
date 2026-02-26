using System;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	public class GdEventWindowViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventWindow>
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x7D89", Offset = "0x7D89", VA = "0x7D89")]
		public GdEventWindowViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a2fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventWindow__set_Events__
		              );
		    DAT_ram_00a5a2fc = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  param1[3] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x170008AE RID: 2222
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AE")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D0C")]
			[Address(RVA = "0x7D8A", Offset = "0x7D8A", VA = "0x7D8A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008AF RID: 2223
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AF")]
		public override GdEventWindow View
		{
			[Token(Token = "0x6002D0D")]
			[Address(RVA = "0x7D8B", Offset = "0x7D8B", VA = "0x7D8B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x7D8C", Offset = "0x7D8C", VA = "0x7D8C")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a5a2ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__
		              );
		    DAT_ram_00a5a2ff = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x40);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  uVar4 = Core_Extensions_Dict_GameActivityDicExt__GetWidgetImageAssetId
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0x10),0);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__,0
		            );
		  UI_Tabs_CategoryTabBarItemView___ctor(param1_00,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x44);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a5a2b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_TryGetComponent_AbstractEventSectionView___);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_EventViewState__get_Configs__);
		    DAT_ram_00a5a2b7 = '\x01';
		  }
		  local_4 = 0;
		  if (*(char *)(iVar2 + 0x19) == '\0') {
		    *(undefined1 *)(iVar2 + 0x19) = 1;
		    iVar2 = *(int *)(iVar2 + 0x10);
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      iVar1 = 0;
		      do {
		        iVar5 = func_ii_8014(*(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 8),&local_4,
		                             Method_UnityEngine_GameObject_TryGetComponent_AbstractEventSectionView___
		                            );
		        if ((iVar5 != 0) && (*(char *)(local_4 + 0x14) == '\0')) {
		          *(undefined1 *)(local_4 + 0x14) = 1;
		          *(undefined4 *)(local_4 + 0x18) = uVar4;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar2 + 0xc));
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x3c);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  UI_Tabs_TabBar__HandleSelected(uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x4c) + 8) + 8),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar2 + 0x3c),0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x7D8D", Offset = "0x7D8D", VA = "0x7D8D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a300 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_EventViewState__set_CurrentState__);
		    DAT_ram_00a5a300 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x44);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,(uint)*(byte *)(iVar1 + 0x14),
		             Method_UI_MonoBehaviourWithStates_EventViewState__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x7D8E", Offset = "0x7D8E", VA = "0x7D8E")]
		private void HandleTabBarChangedEvent()
		{
		/* --- GHIDRA: HandleTabBarChangedEvent ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator__HandleTabBarChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a301 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_GdEventsModel__GdEventsEvents___ctor__);
		    DAT_ram_00a5a301 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_GdEventsModel__GdEventsEvents___ctor__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a2fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventWindow__set_View__
		              );
		    DAT_ram_00a5a2fd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a2fe == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__
		                );
		      DAT_ram_00a5a2fe = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_GdEventWindowViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_GdEventWindowViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__
		              );
		    DAT_ram_00a5a2fe = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x3c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_GdEventWindowViewMediator_HandleTabBarChangedEvent__,0
		            );
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
