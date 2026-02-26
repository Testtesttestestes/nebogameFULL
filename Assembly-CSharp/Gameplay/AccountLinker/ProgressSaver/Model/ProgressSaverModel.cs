using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.AccountLinker.ProgressSaver.Model
{
	// Token: 0x02000E0D RID: 3597
	[Token(Token = "0x2000E0D")]
	public class ProgressSaverModel : AbstractModel
	{
		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E4")]
		public IGame Game
		{
			[Token(Token = "0x6005797")]
			[Address(RVA = "0xA512", Offset = "0xA512", VA = "0xA512")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005798")]
			[Address(RVA = "0xA513", Offset = "0xA513", VA = "0xA513")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600579A RID: 22426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E5")]
		public OptionsMenuButton[] Buttons
		{
			[Token(Token = "0x6005799")]
			[Address(RVA = "0xA514", Offset = "0xA514", VA = "0xA514")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600579A")]
			[Address(RVA = "0xA515", Offset = "0xA515", VA = "0xA515")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579B")]
		[Address(RVA = "0xA516", Offset = "0xA516", VA = "0xA516", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58934 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_OptionsMenuButton___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58934 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(int **)(param1 + 0x10) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f4a644;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f4a644:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = func_ii_6295(*(undefined4 *)(iVar4 + 0x2d8),
		                       Method_System_Linq_Enumerable_ToArray_OptionsMenuButton___);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579C")]
		[Address(RVA = "0xA517", Offset = "0xA517", VA = "0xA517")]
		public ProgressSaverModel(IGame game, IAuthDataProvider authDataProvider, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58935 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    DAT_ram_00a58935 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80f4a710;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4a710:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		        goto code_r0x80f4a792;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80f4a792:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f4a813;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,1)
		  ;
		code_r0x80f4a813:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E6")]
		public string PlatformNick
		{
			[Token(Token = "0x600579D")]
			[Address(RVA = "0xA518", Offset = "0xA518", VA = "0xA518")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x600579E")]
		[Address(RVA = "0xA519", Offset = "0xA519", VA = "0xA519")]
		public SignInVariants.States GetCurrentSigninState()
		{
		/* --- GHIDRA: GetCurrentSigninState ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58937 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a58937 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4ab9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x80f4ab9e:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return *(undefined4 *)(iVar3 + 0x10);
		}
		*/

			return SignInVariants.States.UNKNOWN;
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E7")]
		public string Email
		{
			[Token(Token = "0x600579F")]
			[Address(RVA = "0xA51A", Offset = "0xA51A", VA = "0xA51A")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A0")]
			[Address(RVA = "0xA51B", Offset = "0xA51B", VA = "0xA51B")]
			set
			{
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x170011E8")]
		public bool IsEmailActivated
		{
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0xA51C", Offset = "0xA51C", VA = "0xA51C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		public const float TOAST_DURATION_ABOUT_EMAIL_SUBMITED_SUCCESS = 4f;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0xC")]
		public readonly IAuthDataProvider AuthDataProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Buttons ---
		void Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Buttons
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_PlatformNick ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__get_PlatformNick
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58936 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    DAT_ram_00a58936 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80f4a8ca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4a8ca:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		        goto code_r0x80f4a94c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80f4a94c:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4a9cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,0)
		  ;
		code_r0x80f4a9cd:
		  uVar2 = 3;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (iVar5 != 1) {
		    if (((iVar5 != 2) && (iVar5 != 3)) && (iVar5 == 4)) {
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		            goto code_r0x80f4aa65;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4aa65:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      uVar1 = 0;
		      uVar2 = 4;
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		            goto code_r0x80f4aaeb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80f4aaeb:
		      param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      iVar5 = ICSharpCode_SharpZipLib_Zip_Compression_Streams_StreamManipulator__SkipToByteBoundary
		                        (param1_00,0);
		      if (iVar5 == 0) {
		        uVar2 = 2;
		      }
		      return uVar2;
		    }
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_Email ---
		void Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__get_Email
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58938 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a58938 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4ac48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x80f4ac48:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(iVar3 + 0x10) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_Email ---
		uint Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58939 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    DAT_ram_00a58939 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80f4ad04;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4ad04:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f4ad86;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,10);
		code_r0x80f4ad86:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80f4ae07;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x80f4ae07:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == 0) {
		    return 0;
		  }
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80f4ae91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f4ae91:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f4af13;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,10);
		code_r0x80f4af13:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80f4af94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x80f4af94:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  return (uint)(*(char *)(iVar4 + 0xc) != '\0');
		}
		*/


		/* --- GHIDRA: get_IsEmailActivated ---
		void Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__get_IsEmailActivated
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5893a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ProgressSaverModel__ProgressSaverEvents__Dispose__);
		    DAT_ram_00a5893a = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___ctor(param1,param1);
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ProgressSaverModel__ProgressSaverEvents__Dispose__
		            );
		  return;
		}
		*/

}
