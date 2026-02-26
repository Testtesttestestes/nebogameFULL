using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Data;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Gameplay.AccountLinker.View;
using Gameplay.RegisterV2.Control;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Auth2;
using UI.Tabs;

namespace Gameplay.AccountLinker.Model
{
	// Token: 0x02000E15 RID: 3605
	[Token(Token = "0x2000E15")]
	public class AccountLinkerModel : AbstractModel
	{
		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EE")]
		public LinkerUser CurrentSelectedUser
		{
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0xA556", Offset = "0xA556", VA = "0xA556")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E4")]
			[Address(RVA = "0xA557", Offset = "0xA557", VA = "0xA557")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060057E5 RID: 22501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E6 RID: 22502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EF")]
		public string CurrentCode
		{
			[Token(Token = "0x60057E5")]
			[Address(RVA = "0xA558", Offset = "0xA558", VA = "0xA558")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0xA559", Offset = "0xA559", VA = "0xA559")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060057E7 RID: 22503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057E8 RID: 22504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F0")]
		public OTPTokenGenCmd.Types.Ans CurrentOptTokenResult
		{
			[Token(Token = "0x60057E7")]
			[Address(RVA = "0xA55A", Offset = "0xA55A", VA = "0xA55A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057E8")]
			[Address(RVA = "0xA55B", Offset = "0xA55B", VA = "0xA55B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060057E9 RID: 22505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057EA RID: 22506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F1")]
		[CanBeNull]
		public IRegistration RegisterController
		{
			[Token(Token = "0x60057E9")]
			[Address(RVA = "0xA55C", Offset = "0xA55C", VA = "0xA55C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057EA")]
			[Address(RVA = "0xA55D", Offset = "0xA55D", VA = "0xA55D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EB")]
		[Address(RVA = "0xA55E", Offset = "0xA55E", VA = "0xA55E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_Model_AccountLinkerModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63b61 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_AccountLinkerView_States___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Tabs_TabBarItemData_AccountLinkerView_States__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_AccountLinkerView_States__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2503);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2499);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2497);
		    DAT_ram_00a63b61 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  *(undefined4 *)(param1 + 8) = param7;
		  *(undefined4 *)(param1 + 0x38) = param6;
		  *(undefined4 *)(param1 + 0x34) = param5;
		  *(undefined4 *)(param1 + 0x30) = param4;
		  *(undefined4 *)(param1 + 0x2c) = param3;
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_AccountLinkerView_States__TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2497,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x20) = 1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(int *)(param1 + 0xc) = iVar1;
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_AccountLinkerView_States__TypeInfo);
		  uVar2 = func_ii_7508(StringLiteral_2503,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x20) = 2;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(int *)(param1 + 0x10) = iVar1;
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_AccountLinkerView_States__TypeInfo);
		  uVar2 = func_ii_7508(StringLiteral_2499,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x20) = 3;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(int *)(param1 + 0x14) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0xA55F", Offset = "0xA55F", VA = "0xA55F")]
		public AccountLinkerModel(PlatformSigninManager platformSigninManager, ILoginProvider loginProvider, IRegistrationProvider registrationProvider, ILoggedUserIdSetter loggedUserIdSetter, IGameRestart gameRestart, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_AccountLinker_Model_AccountLinkerModel___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  uint *puVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 param2_00;
		  undefined4 uVar6;
		  uint uVar7;
		  int *piVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a63b62 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_RefAccountInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_RefAccountInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_Model_AccountLinkerModel___c__GetTabs_b__31_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo);
		    DAT_ram_00a63b62 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar8 == (int *)0x0) {
		    iVar2 = 0;
		  }
		  else {
		    uVar7 = 0;
		    iVar2 = *piVar8;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0x140);
		          goto code_r0x8235d694;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235d694:
		    iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		    if (iVar2 == 0) {
		      iVar2 = 0;
		    }
		    else {
		      iVar2 = func_ii_7112(iVar2,0);
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar8 != (int *)0x0) {
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar7 * 8 + 4) * 8 + iVar9 + 0xe0);
		          goto code_r0x8235d754;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235d754:
		    piVar8 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		    if (piVar8 != (int *)0x0) {
		      uVar7 = 0;
		      iVar9 = *piVar8;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar7 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar7 * 8 + 4) * 8 + iVar9 + 0x160);
		            goto code_r0x8235d7d5;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar7);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,0x14);
		code_r0x8235d7d5:
		      iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		      if (((iVar9 != 0) && (iVar2 != 0)) && (iVar9 = *(int *)(iVar9 + 0x14), iVar9 != 0)) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        uVar6 = unnamed_function_1417
		                          (Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		        Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose
		                  (uVar6,uVar4,iVar9,iVar2,0);
		        uVar7 = 1;
		        if (*(int *)(param1 + 8) != 0) {
		          uVar4 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		          if (*(int *)(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo);
		          }
		          puVar5 = *(undefined4 **)
		                    (Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x5c);
		          iVar2 = puVar5[1];
		          if (iVar2 == 0) {
		            if (*(int *)(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x74) == 0)
		            {
		              func_ii_306000(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo);
		              puVar5 = *(undefined4 **)
		                        (Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x5c);
		            }
		            param2_00 = *puVar5;
		            iVar2 = unnamed_function_1417(System_Func_RefAccountInfo__bool__TypeInfo);
		            System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                      (iVar2,param2_00,
		                       Method_Gameplay_AccountLinker_Model_AccountLinkerModel___c__GetTabs_b__31_0__
		                       ,0);
		            *(int *)(*(int *)(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x5c) +
		                    4) = iVar2;
		          }
		          iVar2 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                            (uVar4,iVar2,Method_System_Linq_Enumerable_Any_RefAccountInfo___);
		          if (iVar2 != 0) {
		            uVar7 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email
		                              (uVar6,0);
		            uVar7 = uVar7 ^ 1;
		          }
		        }
		        iVar2 = System_Uri___ctor(0);
		        iVar3 = ICSharpCode_SharpZipLib_Zip_Compression_Streams_StreamManipulator__SkipToByteBoundary
		                          (*(undefined4 *)(iVar2 + 0x54),0);
		        iVar2 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		        iVar9 = 0;
		        if (uVar7 == 0) {
		          iVar9 = iVar3;
		        }
		        if (iVar9 == 0) {
		          uVar6 = *(undefined4 *)(param1 + 0x14);
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar7 = *(uint *)(param1_00 + 0xc);
		          if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = uVar6;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar6,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          }
		        }
		        iVar2 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		        uVar6 = *(undefined4 *)(param1 + 0xc);
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar7 = *(uint *)(param1_00 + 0xc);
		        if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = uVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		    }
		  }
		  iVar2 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  uVar6 = *(undefined4 *)(param1 + 0x10);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_00 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = uVar6;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0xA560", Offset = "0xA560", VA = "0xA560")]
		public List<TabBarItemData> GetTabs()
		{
			return null;
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0xA561", Offset = "0xA561", VA = "0xA561")]
		public SignInVariants.States GetCurrentSigninState()
		{
		/* --- GHIDRA: GetCurrentSigninState ---
		void Gameplay_AccountLinker_Model_AccountLinkerModel__GetCurrentSigninState(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63b64 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo);
		    DAT_ram_00a63b64 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_AccountLinker_Model_AccountLinkerModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return SignInVariants.States.UNKNOWN;
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x488D", Offset = "0x488D", VA = "0x488D")]
		public SigninRecord GetSigninRecord()
		{
		/* --- GHIDRA: GetSigninRecord ---
		int * Gameplay_AccountLinker_Model_AccountLinkerModel__GetSigninRecord(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		public const string GET_CODE_TAB_LOCALE_KEY = "ACCOUNT_LINKER/GET_CODE_TAB_TITLE";

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		public const string SET_CODE_TAB_LOCALE_KEY = "ACCOUNT_LINKER/SET_CODE_TAB_TITLE";

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		public const string SAVE_PROGRESS_TAB_LOCALE_KEY = "ACCOUNT_LINKER/SAVE_PROGRESS_TAB_TITLE";

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0xC")]
		public TabBarItemData GetCodeTab;

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x10")]
		public TabBarItemData SetCodeTab;

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x14")]
		public TabBarItemData SigninTab;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x18")]
		public List<LinkerUser> CurrentAdditionalUsers;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x2C")]
		public readonly ILoginProvider LoginProvider;

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x30")]
		public readonly IRegistrationProvider RegistrationProvider;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x34")]
		public readonly ILoggedUserIdSetter LoggedUserIdSetter;

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x38")]
		public readonly IGameRestart GameRestart;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x3C")]
		public readonly PlatformSigninManager PlatformSigninManager;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x40")]
		public bool SignToTargetProviderInProgress;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_RegisterController ---
		void Gameplay_AccountLinker_Model_AccountLinkerModel__set_RegisterController
		               (int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

}
