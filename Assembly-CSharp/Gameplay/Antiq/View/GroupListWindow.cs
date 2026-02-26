using System;
using Core.Data;
using Core.Dict;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D7F RID: 3455
	[Token(Token = "0x2000D7F")]
	[AddComponentMenu("Antiq/View/GroupListWindow")]
	internal class GroupListWindow : ClosableBaseWindow<GroupListWindow.WindowArgs>
	{
		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600549B RID: 21659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001135")]
		public override string WindowId
		{
			[Token(Token = "0x600549B")]
			[Address(RVA = "0xA24A", Offset = "0xA24A", VA = "0xA24A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549C")]
		[Address(RVA = "0xA24B", Offset = "0xA24B", VA = "0xA24B", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: <>n__0 ---
		void Gameplay_Antiq_View_GroupListWindow____n__0
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: OnClose ---
		void Gameplay_Antiq_View_GroupListWindow__OnClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59480 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GroupListWindow__OnShow_d__8___
		              );
		    DAT_ram_00a59480 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GroupListViewMediator__HandleSearchInputChangedEvent_d__9_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GroupListWindow__OnShow_d__8___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549D")]
		[Address(RVA = "0xA24C", Offset = "0xA24C", VA = "0xA24C", Slot = "22")]
		protected override void OnShow(GroupListWindow.WindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Antiq_View_GroupListWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59481 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs___ctor__);
		    DAT_ram_00a59481 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549E")]
		[Address(RVA = "0xA24D", Offset = "0xA24D", VA = "0xA24D")]
		public GroupListWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_View_GroupListWindow___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a59482 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs__OnShow__);
		    DAT_ram_00a59482 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs__OnShow__);
		  return;
		}
		*/

		}

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Antiq/GroupListWindow";

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GroupListView _view;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x44")]
		private Launch _launch;

		// Token: 0x02000D80 RID: 3456
		[Token(Token = "0x2000D80")]
		internal new class WindowArgs : BaseWindowArgs
		{
			// Token: 0x060054A0 RID: 21664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054A0")]
			[Address(RVA = "0xA24F", Offset = "0xA24F", VA = "0xA24F")]
			public WindowArgs(UserData user, IDictProvider dictProvider, PopupController popupController)
			{
			}

			// Token: 0x04002DCC RID: 11724
			[Token(Token = "0x4002DCC")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserData User;

			// Token: 0x04002DCD RID: 11725
			[Token(Token = "0x4002DCD")]
			[FieldOffset(Offset = "0x1C")]
			public readonly IDictProvider DictProvider;

			// Token: 0x04002DCE RID: 11726
			[Token(Token = "0x4002DCE")]
			[FieldOffset(Offset = "0x20")]
			public readonly PopupController PopupController;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Antiq_View_GroupListWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5947f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5947f = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_GroupListWindow_WindowArgs__OnClose__);
		  if (*(int *)(param1 + 0x44) != 0) {
		    Gameplay_Antiq_AntiqEvents___ctor(*(int *)(param1 + 0x44),param1);
		  }
		  param1_00 = *(int **)(param1 + 0x40);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8100c229;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x8100c229:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

}
