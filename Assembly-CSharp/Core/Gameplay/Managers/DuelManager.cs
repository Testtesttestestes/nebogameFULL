using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Duel.Controller;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Gameplay.Duel.View;
using Il2CppDummyDll;
using Protocol.Duel;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001165 RID: 4453
	[Token(Token = "0x2001165")]
	public class DuelManager : IGameManager, IBaseManager
	{
		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001580")]
		public string Name
		{
			[Token(Token = "0x6006908")]
			[Address(RVA = "0xB42C", Offset = "0xB42C", VA = "0xB42C", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000282 RID: 642
		// (add) Token: 0x06006909 RID: 26889 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600690A RID: 26890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000282")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006909")]
			[Address(RVA = "0xB42D", Offset = "0xB42D", VA = "0xB42D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600690A")]
			[Address(RVA = "0xB42E", Offset = "0xB42E", VA = "0xB42E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000283 RID: 643
		// (add) Token: 0x0600690B RID: 26891 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600690C RID: 26892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000283")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600690B")]
			[Address(RVA = "0xB42F", Offset = "0xB42F", VA = "0xB42F", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600690C")]
			[Address(RVA = "0xB430", Offset = "0xB430", VA = "0xB430", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600690E RID: 26894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001581")]
		public DuelController Controller
		{
			[Token(Token = "0x600690D")]
			[Address(RVA = "0xB431", Offset = "0xB431", VA = "0xB431")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600690E")]
			[Address(RVA = "0xB432", Offset = "0xB432", VA = "0xB432")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600690F")]
		[Address(RVA = "0xB433", Offset = "0xB433", VA = "0xB433", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: <GetUserDataResultHandler>b__19_0 ---
		undefined4
		Core_Gameplay_Managers_DuelManager___GetUserDataResultHandler_b__19_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637cd == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_7699);
		    DAT_ram_00a637cd = '\x01';
		  }
		  return StringLiteral_7699;
		}
		*/

		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_DuelManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a637c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Controller_DuelController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Events_DuelEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Model_DuelModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a637c9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82300afb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82300afb:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  uVar4 = unnamed_function_1417(Gameplay_Duel_Model_DuelModel_TypeInfo);
		  Gameplay_Duel_Model_DuelModel__set_RequirementDic(uVar4,uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  uVar2 = unnamed_function_1417(Gameplay_Duel_Events_DuelEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_Duel_Controller_DuelController_TypeInfo);
		  Gameplay_Duel_Controller_DuelCombatViewMediator___HandleGameOver_b__1_0(uVar4,param2_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  MVC_AbstractController__Dispose(uVar4,0);
		  iVar5 = *(int *)(param1 + 8);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006910")]
		[Address(RVA = "0xB434", Offset = "0xB434", VA = "0xB434", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_DuelManager__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int *piVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  piVar4 = (int *)0x0;
		  if (DAT_ram_00a637ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_View_DuelWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12613);
		    DAT_ram_00a637ca = '\x01';
		  }
		  Gameplay_Duel_Model_DuelModel___ctor(*(undefined4 *)(param1 + 0x10),param2,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x1c) = 1;
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  piVar2 = (int *)UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12613,param1_00,0,0)
		  ;
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Duel_View_DuelWindow_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (piVar4 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Gameplay_Duel_View_DuelWindow_TypeInfo + 0xb8) * 4 + -4) !=
		       Gameplay_Duel_View_DuelWindow_TypeInfo)) {
		      piVar4 = (int *)0x0;
		    }
		  }
		  *(int **)(param1 + 0x18) = piVar4;
		  return;
		}
		*/

		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006911")]
		[Address(RVA = "0xB435", Offset = "0xB435", VA = "0xB435")]
		public void ShowDuelWindow(UserData opponent)
		{
		/* --- GHIDRA: ShowDuelWindow ---
		void Core_Gameplay_Managers_DuelManager__ShowDuelWindow
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a637cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_DuelManager__GetUserDataResultHandler_b__19_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12613);
		    DAT_ram_00a637cc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Func_UserData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_DuelManager__GetUserDataResultHandler_b__19_0__,0);
		  uVar1 = func_ii_7423(param3,uVar1,Method_System_Linq_Enumerable_First_UserData___);
		  Gameplay_Duel_Model_DuelModel___ctor(uVar2,uVar1,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x1c) = 2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12613,param1_00,0,0);
		  return;
		}
		*/

		/* --- GHIDRA: ShowDuelWindow ---
		void Core_Gameplay_Managers_DuelManager__ShowDuelWindow
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a637cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_DuelManager__GetUserDataResultHandler_b__19_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12613);
		    DAT_ram_00a637cc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Func_UserData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_DuelManager__GetUserDataResultHandler_b__19_0__,0);
		  uVar1 = func_ii_7423(param3,uVar1,Method_System_Linq_Enumerable_First_UserData___);
		  Gameplay_Duel_Model_DuelModel___ctor(uVar2,uVar1,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Duel_View_DuelWindow_DuelWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x1c) = 2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12613,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006912")]
		[Address(RVA = "0xB436", Offset = "0xB436", VA = "0xB436")]
		public void ShowDuelWindow(DuelStateInfo state)
		{
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006913")]
		[Address(RVA = "0xB437", Offset = "0xB437", VA = "0xB437")]
		private void GetUserDataResultHandler(long operationIndex, UserData[] data)
		{
		/* --- GHIDRA: GetUserDataResultHandler ---
		void Core_Gameplay_Managers_DuelManager__GetUserDataResultHandler(int param1,undefined4 param2)
		
		{
		  Gameplay_Duel_Controller_DuelController___ctor(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006914")]
		[Address(RVA = "0xB438", Offset = "0xB438", VA = "0xB438")]
		public void StartCombat()
		{
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006915")]
		[Address(RVA = "0xB439", Offset = "0xB439", VA = "0xB439")]
		public DuelManager()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_DuelManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  lVar2 = Gameplay_Isles_User_Model_UserIsleModel__set_RequestFlags
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		  return (uint)(lVar1 != lVar2);
		}
		*/

		}

		// Token: 0x040037C5 RID: 14277
		[Token(Token = "0x40037C5")]
		[FieldOffset(Offset = "0x10")]
		private DuelModel _model;

		// Token: 0x040037C6 RID: 14278
		[Token(Token = "0x40037C6")]
		[FieldOffset(Offset = "0x14")]
		private Gameplay.Duel.Events.DuelEvents _events;

		// Token: 0x040037C7 RID: 14279
		[Token(Token = "0x40037C7")]
		[FieldOffset(Offset = "0x18")]
		private DuelWindow _view;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_DuelManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637c5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_DuelManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_DuelManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_DuelManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: set_Controller ---
		void Core_Gameplay_Managers_DuelManager__set_Controller(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x1c),0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
