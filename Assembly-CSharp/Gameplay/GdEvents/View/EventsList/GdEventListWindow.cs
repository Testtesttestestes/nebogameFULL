using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	public class GdEventListWindow : ClosableBaseWindow<GdEventListWindow.GdEventListWindowArgs>
	{
		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000862")]
		public override string WindowId
		{
			[Token(Token = "0x6002C09")]
			[Address(RVA = "0x7C99", Offset = "0x7C99", VA = "0x7C99", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x7C9A", Offset = "0x7C9A", VA = "0x7C9A", Slot = "22")]
		protected override void OnShow(GdEventListWindow.GdEventListWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_GdEvents_View_EventsList_GdEventListWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 param4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a295 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_GdEventListWindow_GdEventListWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsListViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a295 = '\x01';
		  }
		  piVar4 = *(int **)(*(int *)(param1 + 0x3c) + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__,0);
		  iVar6 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2a0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar6 + 0x2a4));
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_GdEventListWindow_GdEventListWindowArgs__get_WindowArgs__
		                      );
		  iVar5 = **(int **)(iVar6 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_GdEventListWindow_GdEventListWindowArgs__get_WindowArgs__
		                      );
		  iVar5 = **(int **)(iVar6 + 0x18);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar6 + 0x18),*(undefined4 *)(iVar5 + 0x114));
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_GdEventListWindow_GdEventListWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar6 + 0x18);
		  piVar4 = (int *)unnamed_function_1417(Gameplay_GdEvents_Control_GdEventsListViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a5a30f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView___ctor__
		              );
		    DAT_ram_00a5a30f = '\x01';
		  }
		  uVar1 = 0;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar4,uVar2,param3,param4,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView___ctor__
		            );
		  *(int **)(param1 + 0x40) = piVar4;
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x100);
		        goto code_r0x811f43b4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f43b4:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x7C9B", Offset = "0x7C9B", VA = "0x7C9B")]
		private void ListOnInitialized()
		{
		/* --- GHIDRA: ListOnInitialized ---
		void Gameplay_GdEvents_View_EventsList_GdEventListWindow__ListOnInitialized
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a296 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a296 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 0x3c) + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__,0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2a0) * 4))
		            (piVar3,param1_00,*(undefined4 *)(iVar4 + 0x2a4));
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs__OnClose__
		            );
		  piVar3 = *(int **)(param1 + 0x40);
		  if (piVar3 != (int *)0x0) {
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811f44f7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x811f44f7:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x7C9C", Offset = "0x7C9C", VA = "0x7C9C", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_GdEvents_View_EventsList_GdEventListWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a297 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs___ctor__
		              );
		    DAT_ram_00a5a297 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x7C9D", Offset = "0x7C9D", VA = "0x7C9D")]
		public GdEventListWindow()
		{
		}

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/GdEventListWindow";

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GdEventsListView _view;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x02000736 RID: 1846
		[Token(Token = "0x2000736")]
		public class GdEventListWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002C0E RID: 11278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C0E")]
			[Address(RVA = "0x7C9E", Offset = "0x7C9E", VA = "0x7C9E")]
			public GdEventListWindowArgs(GdEventsController controller)
			{
			}

			// Token: 0x04001822 RID: 6178
			[Token(Token = "0x4001822")]
			[FieldOffset(Offset = "0x18")]
			public GdEventsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_GdEvents_View_EventsList_GdEventListWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  
		  if (DAT_ram_00a5a294 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___get_IsInitialized__
		              );
		    DAT_ram_00a5a294 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GdEventListWindow_GdEventListWindowArgs__OnShow__
		              );
		  piVar1 = *(int **)(*(int *)(param1 + 0x3c) + 0x14);
		  if ((char)piVar1[0x14] != '\0') {
		    Gameplay_GdEvents_View_EventsList_GdEventListWindow__OnShow(param1,param1);
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_EventsList_GdEventListWindow_ListOnInitialized__,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
