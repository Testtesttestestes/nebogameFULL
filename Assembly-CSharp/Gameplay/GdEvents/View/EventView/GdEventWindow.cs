using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	public class GdEventWindow : ClosableBaseWindow<GdEventWindow.GdEventWindowArgs>
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000876")]
		public override string WindowId
		{
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0x7CE9", Offset = "0x7CE9", VA = "0x7CE9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000877")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0x7CEA", Offset = "0x7CEA", VA = "0x7CEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000878")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x7CEB", Offset = "0x7CEB", VA = "0x7CEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000879")]
		public ContentContainerView Content
		{
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x7CEC", Offset = "0x7CEC", VA = "0x7CEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x7CED", Offset = "0x7CED", VA = "0x7CED", Slot = "22")]
		protected override void OnShow(GdEventWindow.GdEventWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_GdEvents_View_EventView_GdEventWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2bc = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs__OnClose__)
		  ;
		  param1_00 = *(int **)(param1 + 0x48);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811f5d9a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x811f5d9a:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x7CEE", Offset = "0x7CEE", VA = "0x7CEE", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_GdEvents_View_EventView_GdEventWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs___ctor__);
		    DAT_ram_00a5a2bd = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x7CEF", Offset = "0x7CEF", VA = "0x7CEF")]
		public GdEventWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_EventView_GdEventWindow___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a2be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23035);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23033);
		    DAT_ram_00a5a2be = '\x01';
		  }
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(int **)(param1 + 0x18) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x104));
		  uVar2 = Core_Extensions_Dict_GameActivityDicExt__GetWidgetImageAssetId
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0x10),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_23035,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  iVar1 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x4c) + 0x10) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_23033,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  return;
		}
		*/

		}

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/GdEventWindow";

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ContentContainerView _content;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x48")]
		private IViewMediator _mediator;

		// Token: 0x02000747 RID: 1863
		[Token(Token = "0x2000747")]
		public class GdEventWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002C61 RID: 11361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x7CF0", Offset = "0x7CF0", VA = "0x7CF0")]
			public GdEventWindowArgs(GdEventsController controller)
			{
			}

			// Token: 0x04001859 RID: 6233
			[Token(Token = "0x4001859")]
			[FieldOffset(Offset = "0x18")]
			public GdEventsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Content ---
		void Gameplay_GdEvents_View_EventView_GdEventWindow__get_Content
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param4;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventWindowViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2bb = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GdEventWindow_GdEventWindowArgs__OnShow__);
		  iVar3 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar3 + 0x104));
		  iVar3 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar3 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_GdEvents_Control_GdEventWindowViewMediator_TypeInfo);
		  if (DAT_ram_00a5a2fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventWindow___ctor__
		              );
		    DAT_ram_00a5a2fb = '\x01';
		  }
		  uVar1 = 0;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventWindow___ctor__
		            );
		  *(int **)(param1 + 0x48) = param1_00;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x811f5ca6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f5ca6:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

}
