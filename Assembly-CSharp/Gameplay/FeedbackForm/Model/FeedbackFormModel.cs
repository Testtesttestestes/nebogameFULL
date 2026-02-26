using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.FeedbackForm.Model.Source;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Utils;

namespace Gameplay.FeedbackForm.Model
{
	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	public class FeedbackFormModel : AbstractModel
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098B")]
		public FeedbackThemeOption CurrentTheme
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x814E", Offset = "0x814E", VA = "0x814E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x814F", Offset = "0x814F", VA = "0x814F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700098C")]
		[CanBeNull]
		public string UserEmail
		{
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x8150", Offset = "0x8150", VA = "0x8150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		[CanBeNull]
		public IOpToken CurrentSubmitRequest
		{
			[Token(Token = "0x60030EF")]
			[Address(RVA = "0x8151", Offset = "0x8151", VA = "0x8151")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x8152", Offset = "0x8152", VA = "0x8152")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700098E")]
		[CanBeNull]
		public new UserData User
		{
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0x8153", Offset = "0x8153", VA = "0x8153")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098F")]
		[NotNull]
		public IFeedbackFormSource Source
		{
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x8154", Offset = "0x8154", VA = "0x8154")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0x8155", Offset = "0x8155", VA = "0x8155")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x8156", Offset = "0x8156", VA = "0x8156", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <GetUid>b__20_0 ---
		void Gameplay_FeedbackForm_Model_FeedbackFormModel___GetUid_b__20_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 local_4;
		  
		  if (DAT_ram_00a575ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Themes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a575ff = '\x01';
		  }
		  TMPro_TMP_Dropdown_OptionData__set_color(param1,0);
		  *(undefined1 *)(param1 + 0x20) = (undefined1)param2;
		  local_8 = 0xffffffff;
		  local_c = Gameplay_FeedbackForm_Model_Themes_TypeInfo;
		  local_4 = (undefined1)param2;
		  param1_00 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  iVar1 = StringLiteral_5;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (param1_00 == 0) {
		    param1_00 = iVar1;
		  }
		  uVar2 = func_ii_7508(param1_00,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 8) = uVar2;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_FeedbackForm_Model_FeedbackFormModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  int *piVar3;
		  uint uVar4;
		  int param1_00;
		  uint uVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a575fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_FeedbackThemeOption_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FeedbackThemeOption__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FeedbackThemeOption___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FeedbackThemeOption__TypeInfo);
		    DAT_ram_00a575fc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_FeedbackThemeOption__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,6,Method_System_Collections_Generic_List_FeedbackThemeOption___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(int **)(param1 + 0x18) = param2;
		  do {
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar3 = (int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8);
		        if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo == *piVar3) {
		          puVar2 = (uint *)(iVar7 + piVar3[1] * 8 + 0xc0);
		          goto code_r0x80db3107;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,0)
		    ;
		code_r0x80db3107:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (*(int *)(iVar7 + 0xc) <= iVar6) {
		      return;
		    }
		    piVar3 = *(int **)(param1 + 0x18);
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8);
		        if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo == *piVar8) {
		          puVar2 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80db318a;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,0)
		    ;
		code_r0x80db318a:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar4 = (uint)*(byte *)(iVar7 + iVar6 + 0x10);
		    uVar1 = unnamed_function_1417(Gameplay_FeedbackForm_Model_FeedbackThemeOption_TypeInfo);
		    Gameplay_FeedbackForm_Model_FeedbackFormModel___GetUid_b__20_0(uVar1,uVar4,puVar2);
		    iVar7 = Method_System_Collections_Generic_List_FeedbackThemeOption__Add__;
		    param1_00 = *(int *)(param1 + 0x1c);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    }
		    piVar3 = *(int **)(param1 + 0x18);
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar5 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar5 * 8);
		        if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo == *piVar8) {
		          puVar2 = (uint *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x80db3285;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,1)
		    ;
		code_r0x80db3285:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (uVar5 == uVar4) {
		      *(undefined4 *)(param1 + 0x10) = uVar1;
		    }
		    iVar6 = iVar6 + 1;
		    param2 = *(int **)(param1 + 0x18);
		  } while( true );
		}
		*/

		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x8157", Offset = "0x8157", VA = "0x8157")]
		public FeedbackFormModel([NotNull] IFeedbackFormSource source, int messageMinCharsCount, [CanBeNull] UserData user)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_FeedbackForm_Model_FeedbackFormModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a575fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    DAT_ram_00a575fe = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0xc);
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		        goto code_r0x80db5521;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,6);
		code_r0x80db5521:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80db55a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,2)
		  ;
		code_r0x80db55a5:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  return (uint)(iVar3 == *(int *)(iVar5 + 0xc));
		}
		*/

		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x1AEB", Offset = "0x1AEB", VA = "0x1AEB")]
		public string GetUid()
		{
		/* --- GHIDRA: GetUid ---
		void Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid(undefined4 param1,undefined4 param2)
		
		{
		  Utils_OpToken__Dispose(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0xC")]
		public readonly int MessageMinCharsCount;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x1C")]
		[NotNull]
		public readonly List<FeedbackThemeOption> ThemesOptions;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentTheme ---
		undefined4
		Gameplay_FeedbackForm_Model_FeedbackFormModel__set_CurrentTheme(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a575fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    DAT_ram_00a575fa = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf8);
		        goto code_r0x80db52fa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,7);
		code_r0x80db52fa:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (piVar3 == (int *)0x0) {
		    return 0;
		  }
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80db5383;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x80db5383:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == 0) {
		    return 0;
		  }
		  return *(undefined4 *)(iVar4 + 0x10);
		}
		*/


		/* --- GHIDRA: set_Source ---
		void Gameplay_FeedbackForm_Model_FeedbackFormModel__set_Source(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a575fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FeedbackThemeOption__Clear__);
		    DAT_ram_00a575fb = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar1 = *(int *)(param1 + 0x1c);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
