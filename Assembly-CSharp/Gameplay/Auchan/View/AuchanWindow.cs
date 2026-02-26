using System;
using Gameplay.Auchan.Controller;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	public class AuchanWindow : ClosableBaseWindow<AuchanWindow.AuchanWindowArgs>
	{
		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDB")]
		public override string WindowId
		{
			[Token(Token = "0x6004E4C")]
			[Address(RVA = "0x9C7E", Offset = "0x9C7E", VA = "0x9C7E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x9C7F", Offset = "0x9C7F", VA = "0x9C7F", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Auchan_View_AuchanWindow__Awake(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5985c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__OnShow__);
		    DAT_ram_00a5985c = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__OnShow__);
		  Gameplay_Auchan_View_AuchanWindow__OnClose(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x9C80", Offset = "0x9C80", VA = "0x9C80", Slot = "22")]
		protected override void OnShow(AuchanWindow.AuchanWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Auchan_View_AuchanWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5985d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__OnClose__);
		    DAT_ram_00a5985d = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__OnClose__);
		  if (*(char *)(param1 + 0x58) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x50);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x48);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x48),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x54),*(undefined4 *)(iVar2 + 0x134));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x48) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x9C81", Offset = "0x9C81", VA = "0x9C81", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Auchan_View_AuchanWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5985e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Events_AuchanEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_AuchanService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5985e = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x8107b4af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8107b4af:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x8107b561;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8107b561:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar5 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanModel_TypeInfo);
		    Gameplay_Auchan_Model_AuchanModel__get_Dict(uVar5,uVar3,piVar6,uVar4,uVar4);
		    *(undefined4 *)(param1 + 0x48) = uVar5;
		    uVar3 = unnamed_function_1417(Gameplay_Auchan_Events_AuchanEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x4c) = uVar3;
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_AuchanService___);
		    uVar5 = *(undefined4 *)(param1 + 0x4c);
		    param3 = *(undefined4 *)(param1 + 0x48);
		    uVar4 = unnamed_function_1417(Gameplay_Auchan_Controller_AuchanController_TypeInfo);
		    Gameplay_Auchan_Controller_AuchanArtifactComparers___c___CompareResourceAmount_b__3_1
		              (uVar4,uVar3,param3,uVar5,0);
		    *(undefined4 *)(param1 + 0x50) = uVar4;
		    uVar3 = *(undefined4 *)(param1 + 0x48);
		    uVar5 = *(undefined4 *)(param1 + 0x4c);
		    piVar6 = (int *)unnamed_function_1417(Gameplay_Auchan_Controller_AuchanViewMediator_TypeInfo);
		    Gameplay_Auchan_Controller_AuchanController___c__DisplayClass6_0___BuyAuchanItemHandler_b__1
		              (piVar6,uVar3,uVar5,uVar4,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		              (piVar6,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar6 + 0x164));
		    *(int **)(param1 + 0x54) = piVar6;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x50),0);
		    *(undefined1 *)(param1 + 0x58) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x9C82", Offset = "0x9C82", VA = "0x9C82")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Auchan_View_AuchanWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (*(char *)(param1 + 0x58) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x50);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x48);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x48),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x54),*(undefined4 *)(iVar2 + 0x134));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x48) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x9C83", Offset = "0x9C83", VA = "0x9C83")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Auchan_View_AuchanWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5985f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs___ctor__);
		    DAT_ram_00a5985f = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x9C84", Offset = "0x9C84", VA = "0x9C84")]
		public AuchanWindow()
		{
		}

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Auchan/AuchanWindow";

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private AuchanView _auchanView;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _auchanTitle;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x48")]
		private AuchanModel _model;

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x4C")]
		private AuchanEvents _events;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x50")]
		private AuchanController _controller;

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x54")]
		private AuchanViewMediator _mediator;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000C8D RID: 3213
		[Token(Token = "0x2000C8D")]
		public class AuchanWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004E53 RID: 20051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E53")]
			[Address(RVA = "0x9C85", Offset = "0x9C85", VA = "0x9C85")]
			public AuchanWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Auchan_View_AuchanWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5985b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__Awake__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2775);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2766);
		    DAT_ram_00a5985b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_AuchanWindow_AuchanWindowArgs__Awake__);
		  uVar2 = *(undefined4 *)(param1 + 0x40);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2775,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x44);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2766,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

}
