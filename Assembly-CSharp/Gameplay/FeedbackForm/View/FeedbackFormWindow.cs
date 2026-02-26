using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.FeedbackForm.Model;
using Gameplay.FeedbackForm.Model.Controll;
using Gameplay.FeedbackForm.Model.Source;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;
using UnityEngine;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public class FeedbackFormWindow : ClosableBaseWindow<FeedbackFormWindow.FeedbackFormWindowArgs>
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000988")]
		public override string WindowId
		{
			[Token(Token = "0x60030D1")]
			[Address(RVA = "0x8136", Offset = "0x8136", VA = "0x8136", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000989")]
		public FeedbackFormView View
		{
			[Token(Token = "0x60030D2")]
			[Address(RVA = "0x8137", Offset = "0x8137", VA = "0x8137")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x8138", Offset = "0x8138", VA = "0x8138", Slot = "22")]
		protected override void OnShow(FeedbackFormWindow.FeedbackFormWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a575ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__OnClose__
		              );
		    DAT_ram_00a575ec = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__OnClose__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x40),0);
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x48) = 0;
		  *(undefined8 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x8139", Offset = "0x8139", VA = "0x8139", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FeedbackFormWindow__HandleCloseButton_d__12___
		              );
		    DAT_ram_00a575ed = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_FeedbackFormWindow__HandleBackButton_d__13_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FeedbackFormWindow__HandleCloseButton_d__12___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x813A", Offset = "0x813A", VA = "0x813A", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow__HandleCloseButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FeedbackFormWindow__HandleBackButton_d__13___
		              );
		    DAT_ram_00a575ee = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_ExpectedLoginErrors__HandleTestModeWindowOnClose_d__3_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_FeedbackFormWindow__HandleBackButton_d__13___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x813B", Offset = "0x813B", VA = "0x813B", Slot = "29")]
		protected override void HandleBackButton()
		{
		/* --- GHIDRA: HandleBackButton ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow__HandleBackButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a575ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs___ctor__
		              );
		    DAT_ram_00a575ef = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D7")]
		[Address(RVA = "0x813C", Offset = "0x813C", VA = "0x813C")]
		public FeedbackFormWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a575f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__HandleCloseButton__
		              );
		    DAT_ram_00a575f0 = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___FeedbackFormWindow__HandleCloseButton_d__12_
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__HandleCloseButton__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/FeedbackForm/FeedbackFormWindow";

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FeedbackFormView _view;

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x40")]
		private FeedbackFormController _controller;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x44")]
		private FeedbackFormViewMediator _mediator;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x48")]
		private FeedbackFormModel _model;

		// Token: 0x02000817 RID: 2071
		[Token(Token = "0x2000817")]
		public class FeedbackFormWindowArgs : BaseWindowArgs
		{
			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x060030D9 RID: 12505 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700098A")]
			[NotNull]
			public new IFeedbackFormSource Source
			{
				[Token(Token = "0x60030D9")]
				[Address(RVA = "0x813E", Offset = "0x813E", VA = "0x813E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060030DA RID: 12506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0x813F", Offset = "0x813F", VA = "0x813F")]
			public FeedbackFormWindowArgs(IFeedbackFormSource source)
			{
			}

			// Token: 0x04001AA3 RID: 6819
			[Token(Token = "0x4001AA3")]
			[FieldOffset(Offset = "0x18")]
			[CanBeNull]
			public UserData User;

			// Token: 0x04001AA5 RID: 6821
			[Token(Token = "0x4001AA5")]
			[FieldOffset(Offset = "0x20")]
			public Themes Theme;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_FeedbackForm_View_FeedbackFormWindow__get_View
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 param3_00;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a575eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_FeedbackFormEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_FeedbackFormModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Service_FeedbackFormService_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a575eb = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_FeedbackFormWindow_FeedbackFormWindowArgs__OnShow__
		              );
		  *(undefined1 *)(*(int *)(param1 + 0x3c) + 0x2c) = *(undefined1 *)(param2 + 0x20);
		  param3_00 = unnamed_function_1417(Gameplay_FeedbackForm_FeedbackFormEvents_TypeInfo);
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(Gameplay_FeedbackForm_Model_FeedbackFormModel_TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__Dispose(uVar1,uVar5,0xb,uVar4,uVar4);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  piVar6 = *(int **)(param2 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x80db2deb;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,3);
		code_r0x80db2deb:
		  uVar8 = 0;
		  uVar3 = CONCAT44(in_register_20000004,piVar6);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar3,puVar2[1]);
		  uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  piVar6 = *(int **)(param2 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80db2e70;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,4);
		code_r0x80db2e70:
		  uVar3 = CONCAT44(uVar1,piVar6);
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(uVar3,puVar2[1]);
		  uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar8 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x80db2ef2;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x80db2ef2:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar1,piVar6),puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar7 + 0x24);
		  uVar1 = unnamed_function_1417(Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(uVar1,uVar5,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  uVar5 = 0x405e0000;
		  uVar3 = System_Threading_CancellationTokenSource___ctor(120.0,0);
		  param1_00 = unnamed_function_1417(Gameplay_FeedbackForm_Service_FeedbackFormService_TypeInfo);
		  Core_Gameplay_AuthTokenSourceEternal___ctor(param1_00,uVar4,uVar1,uVar3,0);
		  uVar1 = *(undefined4 *)(param1 + 0x48);
		  iVar7 = unnamed_function_1417
		                    (Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_TypeInfo);
		  if (DAT_ram_00a57607 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents___ctor__);
		    DAT_ram_00a57607 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar7,uVar1,param3_00,
		             Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents___ctor__);
		  *(undefined4 *)(iVar7 + 0x18) = param1_00;
		  *(int *)(param1 + 0x40) = iVar7;
		  uVar1 = *(undefined4 *)(param1 + 0x48);
		  piVar6 = (int *)unnamed_function_1417
		                            (Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a5760d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView___ctor__
		              );
		    DAT_ram_00a5760d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar6,uVar1,param3_00,iVar7,
		             Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView___ctor__
		            );
		  *(int **)(param1 + 0x44) = piVar6;
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (CONCAT44(uVar5,piVar6),*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar6 + 0x164))
		  ;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x40),0);
		  return;
		}
		*/

}
